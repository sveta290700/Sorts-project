
namespace SortsProjectApp
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.Graph = new LiveCharts.WinForms.CartesianChart();
            this.GraphLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.Location = new System.Drawing.Point(12, 116);
            this.Graph.MaximumSize = new System.Drawing.Size(760, 405);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(760, 405);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "График-сравнение времени";
            // 
            // GraphLabel
            // 
            this.GraphLabel.AutoSize = true;
            this.GraphLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GraphLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GraphLabel.Location = new System.Drawing.Point(34, 54);
            this.GraphLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GraphLabel.Name = "GraphLabel";
            this.GraphLabel.Size = new System.Drawing.Size(729, 21);
            this.GraphLabel.TabIndex = 0;
            this.GraphLabel.Text = "График для сравнительного анализа времени, затраченного на сортировку различными " +
    "способами:";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GraphLabel);
            this.Controls.Add(this.Graph);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График-сравнение времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart Graph;
        private System.Windows.Forms.Label GraphLabel;
    }
}