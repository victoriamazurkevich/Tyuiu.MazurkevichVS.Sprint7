namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    partial class FormChart
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
            tableLayoutPanel1 = new TableLayoutPanel();
            chart_MVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonBuildChart_MVS = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MVS).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(chart_MVS, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonBuildChart_MVS, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chart_MVS
            // 
            chartArea1.Name = "ChartArea1";
            chart_MVS.ChartAreas.Add(chartArea1);
            chart_MVS.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_MVS.Legends.Add(legend1);
            chart_MVS.Location = new Point(3, 3);
            chart_MVS.Name = "chart_MVS";
            chart_MVS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Количество филиалов";
            chart_MVS.Series.Add(series1);
            chart_MVS.Size = new Size(794, 395);
            chart_MVS.TabIndex = 0;
            chart_MVS.Text = "chart1";
            // 
            // buttonBuildChart_MVS
            // 
            buttonBuildChart_MVS.BackColor = Color.LightBlue;
            buttonBuildChart_MVS.Dock = DockStyle.Right;
            buttonBuildChart_MVS.Font = new Font("Segoe UI", 10F);
            buttonBuildChart_MVS.Location = new Point(675, 404);
            buttonBuildChart_MVS.Name = "buttonBuildChart_MVS";
            buttonBuildChart_MVS.Size = new Size(122, 43);
            buttonBuildChart_MVS.TabIndex = 1;
            buttonBuildChart_MVS.Text = "Построить";
            buttonBuildChart_MVS.UseVisualStyleBackColor = false;
            buttonBuildChart_MVS.Click += buttonBuildChart_MVS_Click;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormChart";
            Text = "График";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MVS;
        private Button buttonBuildChart_MVS;
    }
}