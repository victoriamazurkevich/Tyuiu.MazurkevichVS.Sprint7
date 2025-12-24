namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanelTextBox_MVS = new TableLayoutPanel();
            textBoxMenu_MVS = new TextBox();
            tableLayoutPanelButtons_MVS = new TableLayoutPanel();
            buttonInfo_MVS = new Button();
            buttonOpen_MVS = new Button();
            toolTipProject_MVS = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanelTextBox_MVS.SuspendLayout();
            tableLayoutPanelButtons_MVS.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelTextBox_MVS
            // 
            tableLayoutPanelTextBox_MVS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelTextBox_MVS.ColumnCount = 1;
            tableLayoutPanelTextBox_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox_MVS.Controls.Add(textBoxMenu_MVS, 0, 0);
            tableLayoutPanelTextBox_MVS.Location = new Point(3, 1);
            tableLayoutPanelTextBox_MVS.Name = "tableLayoutPanelTextBox_MVS";
            tableLayoutPanelTextBox_MVS.RowCount = 1;
            tableLayoutPanelTextBox_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox_MVS.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTextBox_MVS.Size = new Size(377, 76);
            tableLayoutPanelTextBox_MVS.TabIndex = 0;
            // 
            // textBoxMenu_MVS
            // 
            textBoxMenu_MVS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMenu_MVS.BackColor = SystemColors.Control;
            textBoxMenu_MVS.BorderStyle = BorderStyle.None;
            textBoxMenu_MVS.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxMenu_MVS.Location = new Point(3, 18);
            textBoxMenu_MVS.Multiline = true;
            textBoxMenu_MVS.Name = "textBoxMenu_MVS";
            textBoxMenu_MVS.ReadOnly = true;
            textBoxMenu_MVS.Size = new Size(371, 39);
            textBoxMenu_MVS.TabIndex = 0;
            textBoxMenu_MVS.Text = "Главное меню";
            textBoxMenu_MVS.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanelButtons_MVS
            // 
            tableLayoutPanelButtons_MVS.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons_MVS.ColumnCount = 2;
            tableLayoutPanelButtons_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons_MVS.Controls.Add(buttonInfo_MVS, 1, 0);
            tableLayoutPanelButtons_MVS.Controls.Add(buttonOpen_MVS, 0, 0);
            tableLayoutPanelButtons_MVS.Location = new Point(3, 83);
            tableLayoutPanelButtons_MVS.Name = "tableLayoutPanelButtons_MVS";
            tableLayoutPanelButtons_MVS.RowCount = 1;
            tableLayoutPanelButtons_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons_MVS.Size = new Size(377, 95);
            tableLayoutPanelButtons_MVS.TabIndex = 1;
            // 
            // buttonInfo_MVS
            // 
            buttonInfo_MVS.BackColor = Color.SkyBlue;
            buttonInfo_MVS.Dock = DockStyle.Left;
            buttonInfo_MVS.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_MVS.Location = new Point(191, 3);
            buttonInfo_MVS.Name = "buttonInfo_MVS";
            buttonInfo_MVS.Size = new Size(130, 89);
            buttonInfo_MVS.TabIndex = 1;
            buttonInfo_MVS.Text = "?";
            toolTipProject_MVS.SetToolTip(buttonInfo_MVS, "Справка");
            buttonInfo_MVS.UseVisualStyleBackColor = false;
            buttonInfo_MVS.Click += buttonInfo_MVS_Click;
            // 
            // buttonOpen_MVS
            // 
            buttonOpen_MVS.BackColor = Color.SkyBlue;
            buttonOpen_MVS.Dock = DockStyle.Right;
            buttonOpen_MVS.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpen_MVS.Location = new Point(51, 3);
            buttonOpen_MVS.Name = "buttonOpen_MVS";
            buttonOpen_MVS.Size = new Size(134, 89);
            buttonOpen_MVS.TabIndex = 0;
            buttonOpen_MVS.Text = "Открыть";
            toolTipProject_MVS.SetToolTip(buttonOpen_MVS, "Начать работу с приложением");
            buttonOpen_MVS.UseVisualStyleBackColor = false;
            buttonOpen_MVS.Click += buttonOpen_MVS_Click;
            // 
            // toolTipProject_MVS
            // 
            toolTipProject_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTipProject_MVS.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogProject_MVS";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 203);
            Controls.Add(tableLayoutPanelTextBox_MVS);
            Controls.Add(tableLayoutPanelButtons_MVS);
            Name = "FormMenu";
            Text = "Спринт 7  |  Тех. Задание |  Вариант 2 |  Мазуркевич В. С.";
            tableLayoutPanelTextBox_MVS.ResumeLayout(false);
            tableLayoutPanelTextBox_MVS.PerformLayout();
            tableLayoutPanelButtons_MVS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelTextBox_MVS;
        private TextBox textBoxMenu_MVS;
        private TableLayoutPanel tableLayoutPanelButtons_MVS;
        private Button buttonInfo_MVS;
        private Button buttonOpen_MVS;
        private ToolTip toolTipProject_MVS;
        private OpenFileDialog openFileDialog1;
    }
}
