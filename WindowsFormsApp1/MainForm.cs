using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        int N = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (NTextBox.Text != "")
            {
                if (NTextBox.Text.All(char.IsDigit))
                {
                    int parsedN = int.Parse(NTextBox.Text);
                    if (parsedN >= 1 && parsedN <= 1000)
                    {
                        N = parsedN;
                        int[] input = new int[N];
                        Random rand = new Random();
                        for (int i = 0; i < N; i++)
                        {
                            input[i] = rand.Next(200);
                            GeneratedSequenceTextBox.Text = GeneratedSequenceTextBox.Text + input[i] + ' ';
                        }
                        BubbleButton.Enabled = true;
                        InsertButton.Enabled = true;
                        QuickButton.Enabled = true;
                        CombButton.Enabled = true;
                        GraphButton.Enabled = true;
                    }
                    else
                    {
                        ErrorForm ErrorForm = new ErrorForm();
                        ErrorForm.ErrorLabel.Text = "N должно находиться в интервале [1, 1000]";
                        ErrorForm.ShowDialog();
                    }
                }
                else
                {
                    ErrorForm ErrorForm = new ErrorForm();
                    ErrorForm.ErrorLabel.Text = "Встречен отличный от цифры символ.";
                    ErrorForm.ShowDialog();
                }
            }
            else
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.ErrorLabel.Text = "N не было задано.";
                ErrorForm.ShowDialog();
            }
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            int[] BubbleSort(int[] mas)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                            Swap(ref mas[i], ref mas[j]);
                    }
                }
                return mas;
            }
            string[] param = GeneratedSequenceTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);
            stopwatch.Start();
            BubbleSort(arr);
            stopwatch.Stop();
            TimeTextBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
            SortedSequenceTextBox.Text = "N = " + N + Environment.NewLine + "Способ сортировки: " + BubbleButton.Text + Environment.NewLine + "Время сортировки: " + TimeTextBox.Text + Environment.NewLine;
            for (int i = 0; i < N; i++)
            {
                SortedSequenceTextBox.Text = SortedSequenceTextBox.Text + arr[i] + ' ';
            }
            SaveButton.Enabled = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int[] InsertionSort(int[] inputArray)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (inputArray[j - 1] > inputArray[j])
                            Swap(ref inputArray[j - 1], ref inputArray[j]);
                    }
                }
                return inputArray;
            }
            string[] param = GeneratedSequenceTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);
            stopwatch.Start();
            InsertionSort(arr);
            stopwatch.Stop();
            TimeTextBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
            SortedSequenceTextBox.Text = "N = " + N + Environment.NewLine + "Способ сортировки: " + InsertButton.Text + Environment.NewLine + "Время сортировки: " + TimeTextBox.Text + Environment.NewLine;
            for (int i = 0; i < N; i++)
            {
                SortedSequenceTextBox.Text = SortedSequenceTextBox.Text + arr[i] + ' ';
            }
            SaveButton.Enabled = true;
        }

        private void QuickButton_Click(object sender, EventArgs e)
        {
            //метод, возвращающий индекс опорного элемента
            int Partition(int[] array, int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }
                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
            int[] QuickSort(int[] array, int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return array;
                }
                var pivotIndex = Partition(array, minIndex, maxIndex);
                QuickSort(array, minIndex, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, maxIndex);

                return array;
            }
            string[] param = GeneratedSequenceTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);
            stopwatch.Start();
            QuickSort(arr, 0, N - 1);
            stopwatch.Stop();
            TimeTextBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
            SortedSequenceTextBox.Text = "N = " + N + Environment.NewLine + "Способ сортировки: " + QuickButton.Text + Environment.NewLine + "Время сортировки: " + TimeTextBox.Text + Environment.NewLine;
            for (int i = 0; i < N; i++)
            {
                SortedSequenceTextBox.Text = SortedSequenceTextBox.Text + arr[i] + ' ';
            }
            SaveButton.Enabled = true;
        }

        private void CombButton_Click(object sender, EventArgs e)
        {
            int[] CombSort(int[] inputArray)
            {
                /*for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (inputArray[j - 1] > inputArray[j])
                        {
                            int temp = inputArray[j - 1];
                            inputArray[j - 1] = inputArray[j];
                            inputArray[j] = temp;
                        }
                    }
                }*/
                return inputArray;
            }
            string[] param = GeneratedSequenceTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);
            stopwatch.Start();
            CombSort(arr);
            stopwatch.Stop();
            TimeTextBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
            SortedSequenceTextBox.Text = "N = " + N + Environment.NewLine + "Способ сортировки: " + InsertButton.Text + Environment.NewLine + "Время сортировки: " + TimeTextBox.Text + Environment.NewLine;
            for (int i = 0; i < N; i++)
            {
                SortedSequenceTextBox.Text = SortedSequenceTextBox.Text + arr[i] + ' ';
            }
            SaveButton.Enabled = true;
        }

        private void GraphButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog
            {
                DefaultExt = "*.txt",
                Filter = "Text|*.txt"
            };
            if (saveFile1.ShowDialog() == DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(SortedSequenceTextBox.Text);
                    sw.Close();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            N = 0;
            GeneratedSequenceTextBox.Clear();
            SortedSequenceTextBox.Clear();
            TimeTextBox.Clear();
            NTextBox.Clear();
            BubbleButton.Enabled = true;
            InsertButton.Enabled = true;
            QuickButton.Enabled = true;
            CombButton.Enabled = true;
            GraphButton.Enabled = true;
            SaveButton.Enabled = false;
        }
    }
}
