namespace Millionaire.Forms
{
    partial class AudienceResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            this.resultChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(20, 60);
            this.resultChart.Name = "resultChart";
            this.resultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number of Audience";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(527, 301);
            this.resultChart.TabIndex = 0;
            this.resultChart.Text = "Result Chart";
            // 
            // AudienceResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 381);
            this.Controls.Add(this.resultChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudienceResultForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audience Result";
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
    }
}