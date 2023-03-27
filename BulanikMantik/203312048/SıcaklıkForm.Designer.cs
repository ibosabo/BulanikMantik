namespace YAPAY_ZEKA
{
    partial class SıcaklıkForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_Sıcaklık = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Sıcaklık)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Sıcaklık
            // 
            this.Chart_Sıcaklık.BackColor = System.Drawing.Color.LightGray;
            this.Chart_Sıcaklık.BackSecondaryColor = System.Drawing.Color.Silver;
            this.Chart_Sıcaklık.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.Chart_Sıcaklık.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_Sıcaklık.Legends.Add(legend2);
            this.Chart_Sıcaklık.Location = new System.Drawing.Point(93, 144);
            this.Chart_Sıcaklık.Name = "Chart_Sıcaklık";
            this.Chart_Sıcaklık.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "çoksoğuk";
            series7.ShadowColor = System.Drawing.Color.Transparent;
            series7.YValuesPerPoint = 2;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "soğuk";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "orta";
            series9.YValuesPerPoint = 2;
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "sıcak";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.SystemColors.ActiveCaption;
            series11.Legend = "Legend1";
            series11.Name = "çoksıcak";
            series11.XValueMember = "5";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "degerrr";
            this.Chart_Sıcaklık.Series.Add(series7);
            this.Chart_Sıcaklık.Series.Add(series8);
            this.Chart_Sıcaklık.Series.Add(series9);
            this.Chart_Sıcaklık.Series.Add(series10);
            this.Chart_Sıcaklık.Series.Add(series11);
            this.Chart_Sıcaklık.Series.Add(series12);
            this.Chart_Sıcaklık.Size = new System.Drawing.Size(777, 408);
            this.Chart_Sıcaklık.TabIndex = 111;
            this.Chart_Sıcaklık.Text = "chart2";
            this.Chart_Sıcaklık.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(93, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 75);
            this.label1.TabIndex = 112;
            this.label1.Text = "Sıcaklık Grafiği";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SıcaklıkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart_Sıcaklık);
            this.Name = "SıcaklıkForm";
            this.Text = "SıcaklıkForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.SıcaklıkForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Sıcaklık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Chart_Sıcaklık;
        private System.Windows.Forms.Label label1;
    }
}