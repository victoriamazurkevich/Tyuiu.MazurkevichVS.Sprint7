namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            tableLayoutPanelAbout_MVS = new TableLayoutPanel();
            pictureBoxAbout_MVS = new PictureBox();
            textBoxAbout_MVS = new TextBox();
            tableLayoutPanelAbout_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MVS).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelAbout_MVS
            // 
            tableLayoutPanelAbout_MVS.ColumnCount = 2;
            tableLayoutPanelAbout_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.875F));
            tableLayoutPanelAbout_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.125F));
            tableLayoutPanelAbout_MVS.Controls.Add(pictureBoxAbout_MVS, 0, 0);
            tableLayoutPanelAbout_MVS.Controls.Add(textBoxAbout_MVS, 1, 0);
            tableLayoutPanelAbout_MVS.Dock = DockStyle.Fill;
            tableLayoutPanelAbout_MVS.Location = new Point(0, 0);
            tableLayoutPanelAbout_MVS.Name = "tableLayoutPanelAbout_MVS";
            tableLayoutPanelAbout_MVS.RowCount = 1;
            tableLayoutPanelAbout_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAbout_MVS.Size = new Size(779, 323);
            tableLayoutPanelAbout_MVS.TabIndex = 0;
            // 
            // pictureBoxAbout_MVS
            // 
            pictureBoxAbout_MVS.BackgroundImage = Properties.Resources.photo_2025_12_10_23_20_06;
            pictureBoxAbout_MVS.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAbout_MVS.Dock = DockStyle.Fill;
            pictureBoxAbout_MVS.Location = new Point(3, 3);
            pictureBoxAbout_MVS.Name = "pictureBoxAbout_MVS";
            pictureBoxAbout_MVS.Size = new Size(281, 317);
            pictureBoxAbout_MVS.TabIndex = 0;
            pictureBoxAbout_MVS.TabStop = false;
            // 
            // textBoxAbout_MVS
            // 
            textBoxAbout_MVS.BackColor = SystemColors.Control;
            textBoxAbout_MVS.BorderStyle = BorderStyle.None;
            textBoxAbout_MVS.Dock = DockStyle.Fill;
            textBoxAbout_MVS.Location = new Point(290, 3);
            textBoxAbout_MVS.Multiline = true;
            textBoxAbout_MVS.Name = "textBoxAbout_MVS";
            textBoxAbout_MVS.Size = new Size(486, 317);
            textBoxAbout_MVS.TabIndex = 1;
            textBoxAbout_MVS.Text = resources.GetString("textBoxAbout_MVS.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 323);
            Controls.Add(tableLayoutPanelAbout_MVS);
            Name = "FormAbout";
            Text = "О программе";
            tableLayoutPanelAbout_MVS.ResumeLayout(false);
            tableLayoutPanelAbout_MVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAbout_MVS;
        private PictureBox pictureBoxAbout_MVS;
        private TextBox textBoxAbout_MVS;
    }
}