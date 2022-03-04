using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             int[] BubbleSort(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }

            string[] param = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort(arr);
            sw.Stop();
            textBox4.Text = ((sw.Elapsed.TotalMilliseconds).ToString());

            int SIZE = Int32.Parse(textBox3.Text);
            textBox2.Text = label1.Text + ' ' + textBox3.Text + Environment.NewLine + button1.Text + Environment.NewLine + label2.Text + ' ' + textBox4.Text + Environment.NewLine;
            for (int i = 0; i < SIZE; i++)
            { 
                textBox2.Text = textBox2.Text + arr[i] + ' ';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int SIZE = Int32.Parse(textBox3.Text);
            int [] input = new int [SIZE];
            Random rand = new Random();
            for (int i = 0; i < SIZE; i++)
            { 
                input[i] = rand.Next(100);
                textBox1.Text = textBox1.Text + input[i] + ' ';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SIZE = Int32.Parse(textBox3.Text);
            int[] InsertionSort(int[] inputArray)
            {
                for (int i = 0; i < SIZE - 1; i++)
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
                }
                return inputArray;
            }

            string[] param = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            InsertionSort(arr);
            sw.Stop();
            textBox4.Text = ((sw.Elapsed.TotalMilliseconds).ToString());

            textBox2.Text = label1.Text + ' ' + textBox3.Text + Environment.NewLine + button2.Text + Environment.NewLine + label2.Text + ' ' + textBox4.Text + Environment.NewLine;
            for (int i = 0; i < SIZE; i++)
            {
                textBox2.Text = textBox2.Text + arr[i] + ' ';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SIZE = Int32.Parse(textBox3.Text);
            void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }

            //метод возвращающий индекс опорного элемента
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

            //быстрая сортировка
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

            string[] param = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSort(arr, 0, SIZE - 1);
            sw.Stop();
            textBox4.Text = ((sw.Elapsed.TotalMilliseconds).ToString());

            textBox2.Text = label1.Text + ' ' + textBox3.Text + Environment.NewLine + button3.Text + Environment.NewLine + label2.Text + ' ' + textBox4.Text + Environment.NewLine;
            for (int i = 0; i < SIZE; i++)
            {
                textBox2.Text = textBox2.Text + arr[i] + ' ';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
