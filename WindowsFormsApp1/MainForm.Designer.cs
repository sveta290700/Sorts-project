namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GeneratedSequenceTextBox = new System.Windows.Forms.TextBox();
            this.SortedSequenceTextBox = new System.Windows.Forms.TextBox();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.QuickButton = new System.Windows.Forms.Button();
            this.NLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.GenerateLabel = new System.Windows.Forms.Label();
            this.GeneratedSequenceLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.GraphLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.CombButton = new System.Windows.Forms.Button();
            this.GraphButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CleanLabel = new System.Windows.Forms.Label();
            this.TimerPictureBox = new System.Windows.Forms.PictureBox();
            this.NTextBox = new DietProject.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratedSequenceTextBox
            // 
            this.GeneratedSequenceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GeneratedSequenceTextBox.Location = new System.Drawing.Point(15, 143);
            this.GeneratedSequenceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GeneratedSequenceTextBox.Multiline = true;
            this.GeneratedSequenceTextBox.Name = "GeneratedSequenceTextBox";
            this.GeneratedSequenceTextBox.ReadOnly = true;
            this.GeneratedSequenceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratedSequenceTextBox.Size = new System.Drawing.Size(338, 196);
            this.GeneratedSequenceTextBox.TabIndex = 6;
            // 
            // SortedSequenceTextBox
            // 
            this.SortedSequenceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SortedSequenceTextBox.Location = new System.Drawing.Point(435, 143);
            this.SortedSequenceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortedSequenceTextBox.Multiline = true;
            this.SortedSequenceTextBox.Name = "SortedSequenceTextBox";
            this.SortedSequenceTextBox.ReadOnly = true;
            this.SortedSequenceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SortedSequenceTextBox.Size = new System.Drawing.Size(338, 196);
            this.SortedSequenceTextBox.TabIndex = 15;
            // 
            // BubbleButton
            // 
            this.BubbleButton.Enabled = false;
            this.BubbleButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BubbleButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BubbleButton.Location = new System.Drawing.Point(15, 399);
            this.BubbleButton.Margin = new System.Windows.Forms.Padding(2);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(108, 39);
            this.BubbleButton.TabIndex = 8;
            this.BubbleButton.Text = "Пузырёк";
            this.BubbleButton.UseVisualStyleBackColor = true;
            this.BubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Enabled = false;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InsertButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InsertButton.Location = new System.Drawing.Point(15, 448);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 39);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "Вставками";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // QuickButton
            // 
            this.QuickButton.Enabled = false;
            this.QuickButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QuickButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QuickButton.Location = new System.Drawing.Point(138, 399);
            this.QuickButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuickButton.Name = "QuickButton";
            this.QuickButton.Size = new System.Drawing.Size(108, 39);
            this.QuickButton.TabIndex = 9;
            this.QuickButton.Text = "Быстрая";
            this.QuickButton.UseVisualStyleBackColor = true;
            this.QuickButton.Click += new System.EventHandler(this.QuickButton_Click);
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NLabel.Location = new System.Drawing.Point(341, 18);
            this.NLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(37, 21);
            this.NLabel.TabIndex = 1;
            this.NLabel.Text = "N =";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenerateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenerateButton.Location = new System.Drawing.Point(382, 55);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(135, 39);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClearButton.Location = new System.Drawing.Point(544, 448);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 39);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimeTextBox.Location = new System.Drawing.Point(631, 356);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(136, 29);
            this.TimeTextBox.TabIndex = 17;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LengthLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LengthLabel.Location = new System.Drawing.Point(11, 18);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(326, 21);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "1) Длина сортируемой последовательности:";
            // 
            // GenerateLabel
            // 
            this.GenerateLabel.AutoSize = true;
            this.GenerateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenerateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenerateLabel.Location = new System.Drawing.Point(11, 61);
            this.GenerateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenerateLabel.Name = "GenerateLabel";
            this.GenerateLabel.Size = new System.Drawing.Size(355, 21);
            this.GenerateLabel.TabIndex = 3;
            this.GenerateLabel.Text = "2) Сгенерировать последовательность длины N:";
            // 
            // GeneratedSequenceLabel
            // 
            this.GeneratedSequenceLabel.AutoSize = true;
            this.GeneratedSequenceLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GeneratedSequenceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeneratedSequenceLabel.Location = new System.Drawing.Point(11, 104);
            this.GeneratedSequenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GeneratedSequenceLabel.Name = "GeneratedSequenceLabel";
            this.GeneratedSequenceLabel.Size = new System.Drawing.Size(308, 21);
            this.GeneratedSequenceLabel.TabIndex = 5;
            this.GeneratedSequenceLabel.Text = "3) Сгенерированная последовательность:";
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SortLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SortLabel.Location = new System.Drawing.Point(11, 359);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(184, 21);
            this.SortLabel.TabIndex = 7;
            this.SortLabel.Text = "4.1) Способ сортировки:";
            // 
            // GraphLabel
            // 
            this.GraphLabel.AutoSize = true;
            this.GraphLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GraphLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GraphLabel.Location = new System.Drawing.Point(11, 507);
            this.GraphLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GraphLabel.Name = "GraphLabel";
            this.GraphLabel.Size = new System.Drawing.Size(255, 21);
            this.GraphLabel.TabIndex = 12;
            this.GraphLabel.Text = "4.2) Построить график-сравнение:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResultLabel.Location = new System.Drawing.Point(430, 105);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(101, 21);
            this.ResultLabel.TabIndex = 14;
            this.ResultLabel.Text = "5) Результат:";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveLabel.Location = new System.Drawing.Point(430, 408);
            this.SaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(159, 21);
            this.SaveLabel.TabIndex = 18;
            this.SaveLabel.Text = "6) Сохранить в файл:";
            // 
            // CombButton
            // 
            this.CombButton.Enabled = false;
            this.CombButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CombButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CombButton.Location = new System.Drawing.Point(138, 448);
            this.CombButton.Margin = new System.Windows.Forms.Padding(2);
            this.CombButton.Name = "CombButton";
            this.CombButton.Size = new System.Drawing.Size(108, 39);
            this.CombButton.TabIndex = 11;
            this.CombButton.Text = "Расчёска";
            this.CombButton.UseVisualStyleBackColor = true;
            this.CombButton.Click += new System.EventHandler(this.CombButton_Click);
            // 
            // GraphButton
            // 
            this.GraphButton.Enabled = false;
            this.GraphButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GraphButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GraphButton.Location = new System.Drawing.Point(272, 499);
            this.GraphButton.Margin = new System.Windows.Forms.Padding(2);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(153, 39);
            this.GraphButton.TabIndex = 13;
            this.GraphButton.Text = "Построить график";
            this.GraphButton.UseVisualStyleBackColor = true;
            this.GraphButton.Click += new System.EventHandler(this.GraphButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeLabel.Location = new System.Drawing.Point(481, 359);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(146, 21);
            this.TimeLabel.TabIndex = 16;
            this.TimeLabel.Text = "Время сортировки:";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveButton.Location = new System.Drawing.Point(605, 399);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 39);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CleanLabel
            // 
            this.CleanLabel.AutoSize = true;
            this.CleanLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CleanLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CleanLabel.Location = new System.Drawing.Point(430, 457);
            this.CleanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CleanLabel.Name = "CleanLabel";
            this.CleanLabel.Size = new System.Drawing.Size(99, 21);
            this.CleanLabel.TabIndex = 20;
            this.CleanLabel.Text = "7) Очистить:";
            // 
            // TimerPictureBox
            // 
            this.TimerPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Timer;
            this.TimerPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimerPictureBox.Location = new System.Drawing.Point(447, 358);
            this.TimerPictureBox.Name = "TimerPictureBox";
            this.TimerPictureBox.Size = new System.Drawing.Size(29, 27);
            this.TimerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TimerPictureBox.TabIndex = 20;
            this.TimerPictureBox.TabStop = false;
            // 
            // NTextBox
            // 
            this.NTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTextBox.Location = new System.Drawing.Point(383, 15);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(105, 29);
            this.NTextBox.TabIndex = 2;
            this.NTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.NTextBox.WaterMarkText = "[1, 1000]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.CleanLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimerPictureBox);
            this.Controls.Add(this.GraphButton);
            this.Controls.Add(this.CombButton);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GraphLabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.GeneratedSequenceLabel);
            this.Controls.Add(this.GenerateLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.QuickButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.BubbleButton);
            this.Controls.Add(this.SortedSequenceTextBox);
            this.Controls.Add(this.GeneratedSequenceTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировщик";
            ((System.ComponentModel.ISupportInitialize)(this.TimerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GeneratedSequenceTextBox;
        private System.Windows.Forms.TextBox SortedSequenceTextBox;
        private System.Windows.Forms.Button BubbleButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button QuickButton;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label GenerateLabel;
        private System.Windows.Forms.Label GeneratedSequenceLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label GraphLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button CombButton;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.PictureBox TimerPictureBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CleanLabel;
        private DietProject.WaterMarkTextBox NTextBox;
    }
}

