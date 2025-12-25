namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            tableLayoutPanelMainTop_MVS = new TableLayoutPanel();
            textBoxMainTitle_MVS = new TextBox();
            buttonHelp_MVS = new Button();
            buttontoChart_MVS = new Button();
            openFileDialog_MVS = new OpenFileDialog();
            toolTip_MVS = new ToolTip(components);
            buttonLoadFileDepartments_MVS = new Button();
            buttonLoadEmployees_MVS = new Button();
            buttonLoadProviders_MVS = new Button();
            buttonSaveDepartments_MVS = new Button();
            buttonSaveEmployees_MVS = new Button();
            buttonSaveProviders_MVS = new Button();
            buttonMinEmployees_MVS = new Button();
            buttonMaxEmployees_MVS = new Button();
            buttonMinProviders_MVS = new Button();
            buttonMaxProviders_MVS = new Button();
            buttonSearch_MVS = new Button();
            buttonMidEmployees_MVS = new Button();
            buttonMidProviders_MVS = new Button();
            saveFileDialog_MVS = new SaveFileDialog();
            tableLayoutPanelMainBottom_MVS = new TableLayoutPanel();
            dataGridViewEmployees_MVS = new DataGridView();
            dataGridViewDepartments_MVS = new DataGridView();
            dataGridViewProviders_MVS = new DataGridView();
            tableLayoutPanelMainCenter_MVS = new TableLayoutPanel();
            textBoxMidEmployees_MVS = new TextBox();
            textBoxMaxEmployees_MVS = new TextBox();
            textBoxMinEmployees_MVS = new TextBox();
            textBoxMaxProviders_MVS = new TextBox();
            textBoxMinProviders_MVS = new TextBox();
            comboBoxSearchColumn_MVS = new ComboBox();
            textBoxSearch_MVS = new TextBox();
            comboBoxSearchTable_MVS = new ComboBox();
            textBoxTableSearch_MVS = new TextBox();
            textBoxColumnSearch_MVS = new TextBox();
            textBoxItemSearch_MVS = new TextBox();
            textBoxMidProviders_MVS = new TextBox();
            tableLayoutPanelMainTop_MVS.SuspendLayout();
            tableLayoutPanelMainBottom_MVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees_MVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_MVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders_MVS).BeginInit();
            tableLayoutPanelMainCenter_MVS.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMainTop_MVS
            // 
            tableLayoutPanelMainTop_MVS.ColumnCount = 6;
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.2087F));
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.791295767F));
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            tableLayoutPanelMainTop_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelMainTop_MVS.Controls.Add(textBoxMainTitle_MVS, 0, 0);
            tableLayoutPanelMainTop_MVS.Controls.Add(buttonHelp_MVS, 5, 0);
            tableLayoutPanelMainTop_MVS.Controls.Add(buttontoChart_MVS, 4, 0);
            tableLayoutPanelMainTop_MVS.Dock = DockStyle.Top;
            tableLayoutPanelMainTop_MVS.Location = new Point(0, 0);
            tableLayoutPanelMainTop_MVS.Name = "tableLayoutPanelMainTop_MVS";
            tableLayoutPanelMainTop_MVS.RowCount = 1;
            tableLayoutPanelMainTop_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 49.68944F));
            tableLayoutPanelMainTop_MVS.Size = new Size(1448, 87);
            tableLayoutPanelMainTop_MVS.TabIndex = 0;
            tableLayoutPanelMainTop_MVS.Paint += tableLayoutPanel1_Paint;
            // 
            // textBoxMainTitle_MVS
            // 
            textBoxMainTitle_MVS.BackColor = Color.PowderBlue;
            textBoxMainTitle_MVS.BorderStyle = BorderStyle.FixedSingle;
            textBoxMainTitle_MVS.Dock = DockStyle.Top;
            textBoxMainTitle_MVS.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            textBoxMainTitle_MVS.Location = new Point(3, 3);
            textBoxMainTitle_MVS.Multiline = true;
            textBoxMainTitle_MVS.Name = "textBoxMainTitle_MVS";
            textBoxMainTitle_MVS.ReadOnly = true;
            textBoxMainTitle_MVS.Size = new Size(997, 81);
            textBoxMainTitle_MVS.TabIndex = 0;
            textBoxMainTitle_MVS.Text = "Информация о сети магазинов";
            textBoxMainTitle_MVS.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonHelp_MVS
            // 
            buttonHelp_MVS.BackColor = Color.PowderBlue;
            buttonHelp_MVS.BackgroundImage = Properties.Resources.help;
            buttonHelp_MVS.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_MVS.Dock = DockStyle.Top;
            buttonHelp_MVS.Location = new Point(1250, 3);
            buttonHelp_MVS.Name = "buttonHelp_MVS";
            buttonHelp_MVS.Size = new Size(195, 81);
            buttonHelp_MVS.TabIndex = 2;
            toolTip_MVS.SetToolTip(buttonHelp_MVS, "Краткое руководство");
            buttonHelp_MVS.UseVisualStyleBackColor = false;
            buttonHelp_MVS.Click += buttonHelp_MVS_Click;
            // 
            // buttontoChart_MVS
            // 
            buttontoChart_MVS.BackColor = Color.DarkTurquoise;
            buttontoChart_MVS.Dock = DockStyle.Top;
            buttontoChart_MVS.Font = new Font("Segoe UI", 14F);
            buttontoChart_MVS.Location = new Point(1031, 3);
            buttontoChart_MVS.Name = "buttontoChart_MVS";
            buttontoChart_MVS.Size = new Size(213, 81);
            buttontoChart_MVS.TabIndex = 1;
            buttontoChart_MVS.Text = "График";
            toolTip_MVS.SetToolTip(buttontoChart_MVS, "Перейти к построению графика");
            buttontoChart_MVS.UseVisualStyleBackColor = false;
            buttontoChart_MVS.Click += buttontoChart_MVS_Click;
            // 
            // openFileDialog_MVS
            // 
            openFileDialog_MVS.FileName = "openFileDialog1";
            // 
            // toolTip_MVS
            // 
            toolTip_MVS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MVS.ToolTipTitle = "Подсказка";
            // 
            // buttonLoadFileDepartments_MVS
            // 
            buttonLoadFileDepartments_MVS.BackColor = Color.GhostWhite;
            buttonLoadFileDepartments_MVS.Dock = DockStyle.Fill;
            buttonLoadFileDepartments_MVS.Location = new Point(3, 3);
            buttonLoadFileDepartments_MVS.Name = "buttonLoadFileDepartments_MVS";
            buttonLoadFileDepartments_MVS.Size = new Size(476, 54);
            buttonLoadFileDepartments_MVS.TabIndex = 1;
            buttonLoadFileDepartments_MVS.Text = "Открыть таблицу филиалов";
            toolTip_MVS.SetToolTip(buttonLoadFileDepartments_MVS, "Выберите файл");
            buttonLoadFileDepartments_MVS.UseVisualStyleBackColor = false;
            buttonLoadFileDepartments_MVS.Click += buttonLoadFileDepartments_MVS_Click;
            // 
            // buttonLoadEmployees_MVS
            // 
            buttonLoadEmployees_MVS.BackColor = Color.GhostWhite;
            buttonLoadEmployees_MVS.Dock = DockStyle.Fill;
            buttonLoadEmployees_MVS.Location = new Point(485, 3);
            buttonLoadEmployees_MVS.Name = "buttonLoadEmployees_MVS";
            buttonLoadEmployees_MVS.Size = new Size(476, 54);
            buttonLoadEmployees_MVS.TabIndex = 2;
            buttonLoadEmployees_MVS.Text = "Открыть таблицу сотрудников";
            toolTip_MVS.SetToolTip(buttonLoadEmployees_MVS, "Выберите файл");
            buttonLoadEmployees_MVS.UseVisualStyleBackColor = false;
            buttonLoadEmployees_MVS.Click += buttonLoadEmployees_MVS_Click;
            // 
            // buttonLoadProviders_MVS
            // 
            buttonLoadProviders_MVS.BackColor = Color.GhostWhite;
            buttonLoadProviders_MVS.Dock = DockStyle.Fill;
            buttonLoadProviders_MVS.Location = new Point(967, 3);
            buttonLoadProviders_MVS.Name = "buttonLoadProviders_MVS";
            buttonLoadProviders_MVS.Size = new Size(478, 54);
            buttonLoadProviders_MVS.TabIndex = 3;
            buttonLoadProviders_MVS.Text = "Открыть таблицу поставщиков";
            toolTip_MVS.SetToolTip(buttonLoadProviders_MVS, "Выберите файл");
            buttonLoadProviders_MVS.UseVisualStyleBackColor = false;
            buttonLoadProviders_MVS.Click += buttonLoadProviders_MVS_Click;
            // 
            // buttonSaveDepartments_MVS
            // 
            buttonSaveDepartments_MVS.BackColor = Color.Thistle;
            buttonSaveDepartments_MVS.Dock = DockStyle.Fill;
            buttonSaveDepartments_MVS.Location = new Point(3, 176);
            buttonSaveDepartments_MVS.Name = "buttonSaveDepartments_MVS";
            buttonSaveDepartments_MVS.Size = new Size(235, 53);
            buttonSaveDepartments_MVS.TabIndex = 12;
            buttonSaveDepartments_MVS.Text = "Сохранить";
            toolTip_MVS.SetToolTip(buttonSaveDepartments_MVS, "Сохраните файл");
            buttonSaveDepartments_MVS.UseVisualStyleBackColor = false;
            buttonSaveDepartments_MVS.Click += buttonSaveDepartments_MVS_Click;
            // 
            // buttonSaveEmployees_MVS
            // 
            buttonSaveEmployees_MVS.BackColor = Color.Thistle;
            buttonSaveEmployees_MVS.Dock = DockStyle.Fill;
            buttonSaveEmployees_MVS.Location = new Point(485, 176);
            buttonSaveEmployees_MVS.Name = "buttonSaveEmployees_MVS";
            buttonSaveEmployees_MVS.Size = new Size(235, 53);
            buttonSaveEmployees_MVS.TabIndex = 18;
            buttonSaveEmployees_MVS.Text = "Сохранить";
            toolTip_MVS.SetToolTip(buttonSaveEmployees_MVS, "Сохраните файл");
            buttonSaveEmployees_MVS.UseVisualStyleBackColor = false;
            buttonSaveEmployees_MVS.Click += buttonSaveEmployees_MVS_Click;
            // 
            // buttonSaveProviders_MVS
            // 
            buttonSaveProviders_MVS.BackColor = Color.Thistle;
            buttonSaveProviders_MVS.Dock = DockStyle.Fill;
            buttonSaveProviders_MVS.Location = new Point(967, 176);
            buttonSaveProviders_MVS.Name = "buttonSaveProviders_MVS";
            buttonSaveProviders_MVS.Size = new Size(235, 53);
            buttonSaveProviders_MVS.TabIndex = 19;
            buttonSaveProviders_MVS.Text = "Сохранить";
            toolTip_MVS.SetToolTip(buttonSaveProviders_MVS, "Сохраните файл");
            buttonSaveProviders_MVS.UseVisualStyleBackColor = false;
            buttonSaveProviders_MVS.Click += buttonSaveProviders_MVS_Click;
            // 
            // buttonMinEmployees_MVS
            // 
            buttonMinEmployees_MVS.BackColor = Color.Thistle;
            buttonMinEmployees_MVS.Dock = DockStyle.Fill;
            buttonMinEmployees_MVS.Location = new Point(485, 61);
            buttonMinEmployees_MVS.Name = "buttonMinEmployees_MVS";
            buttonMinEmployees_MVS.Size = new Size(235, 52);
            buttonMinEmployees_MVS.TabIndex = 8;
            buttonMinEmployees_MVS.Text = "Min";
            toolTip_MVS.SetToolTip(buttonMinEmployees_MVS, "Найти минимум");
            buttonMinEmployees_MVS.UseVisualStyleBackColor = false;
            buttonMinEmployees_MVS.Click += buttonMinEmployees_MVS_Click;
            // 
            // buttonMaxEmployees_MVS
            // 
            buttonMaxEmployees_MVS.BackColor = Color.Thistle;
            buttonMaxEmployees_MVS.Dock = DockStyle.Fill;
            buttonMaxEmployees_MVS.Location = new Point(485, 3);
            buttonMaxEmployees_MVS.Name = "buttonMaxEmployees_MVS";
            buttonMaxEmployees_MVS.Size = new Size(235, 52);
            buttonMaxEmployees_MVS.TabIndex = 3;
            buttonMaxEmployees_MVS.Text = "Max";
            toolTip_MVS.SetToolTip(buttonMaxEmployees_MVS, "Найти максимум");
            buttonMaxEmployees_MVS.UseVisualStyleBackColor = false;
            buttonMaxEmployees_MVS.Click += buttonMaxEmployees_MVS_Click;
            // 
            // buttonMinProviders_MVS
            // 
            buttonMinProviders_MVS.BackColor = Color.Thistle;
            buttonMinProviders_MVS.Dock = DockStyle.Fill;
            buttonMinProviders_MVS.Location = new Point(967, 61);
            buttonMinProviders_MVS.Name = "buttonMinProviders_MVS";
            buttonMinProviders_MVS.Size = new Size(235, 52);
            buttonMinProviders_MVS.TabIndex = 10;
            buttonMinProviders_MVS.Text = "Min";
            toolTip_MVS.SetToolTip(buttonMinProviders_MVS, "Найти минимум");
            buttonMinProviders_MVS.UseVisualStyleBackColor = false;
            buttonMinProviders_MVS.Click += buttonMinProviders_MVS_Click;
            // 
            // buttonMaxProviders_MVS
            // 
            buttonMaxProviders_MVS.BackColor = Color.Thistle;
            buttonMaxProviders_MVS.Dock = DockStyle.Fill;
            buttonMaxProviders_MVS.Location = new Point(967, 3);
            buttonMaxProviders_MVS.Name = "buttonMaxProviders_MVS";
            buttonMaxProviders_MVS.Size = new Size(235, 52);
            buttonMaxProviders_MVS.TabIndex = 5;
            buttonMaxProviders_MVS.Text = "Max";
            toolTip_MVS.SetToolTip(buttonMaxProviders_MVS, "Найти максимум");
            buttonMaxProviders_MVS.UseVisualStyleBackColor = false;
            buttonMaxProviders_MVS.Click += buttonMaxProviders_MVS_Click;
            // 
            // buttonSearch_MVS
            // 
            buttonSearch_MVS.BackColor = Color.Thistle;
            buttonSearch_MVS.Dock = DockStyle.Fill;
            buttonSearch_MVS.Location = new Point(244, 176);
            buttonSearch_MVS.Name = "buttonSearch_MVS";
            buttonSearch_MVS.Size = new Size(235, 53);
            buttonSearch_MVS.TabIndex = 1;
            buttonSearch_MVS.Text = "Поиск";
            toolTip_MVS.SetToolTip(buttonSearch_MVS, "Найти значение");
            buttonSearch_MVS.UseVisualStyleBackColor = false;
            // 
            // buttonMidEmployees_MVS
            // 
            buttonMidEmployees_MVS.BackColor = Color.Thistle;
            buttonMidEmployees_MVS.Dock = DockStyle.Fill;
            buttonMidEmployees_MVS.Location = new Point(485, 119);
            buttonMidEmployees_MVS.Name = "buttonMidEmployees_MVS";
            buttonMidEmployees_MVS.Size = new Size(235, 51);
            buttonMidEmployees_MVS.TabIndex = 32;
            buttonMidEmployees_MVS.Text = "Среднее";
            toolTip_MVS.SetToolTip(buttonMidEmployees_MVS, "Найти среднее значение");
            buttonMidEmployees_MVS.UseVisualStyleBackColor = false;
            buttonMidEmployees_MVS.Click += buttonMidEmployees_MVS_Click;
            // 
            // buttonMidProviders_MVS
            // 
            buttonMidProviders_MVS.BackColor = Color.Thistle;
            buttonMidProviders_MVS.Dock = DockStyle.Fill;
            buttonMidProviders_MVS.Location = new Point(967, 119);
            buttonMidProviders_MVS.Name = "buttonMidProviders_MVS";
            buttonMidProviders_MVS.Size = new Size(235, 51);
            buttonMidProviders_MVS.TabIndex = 33;
            buttonMidProviders_MVS.Text = "Среднее";
            toolTip_MVS.SetToolTip(buttonMidProviders_MVS, "Найти среднее значение");
            buttonMidProviders_MVS.UseVisualStyleBackColor = false;
            buttonMidProviders_MVS.Click += buttonMidProviders_MVS_Click;
            // 
            // tableLayoutPanelMainBottom_MVS
            // 
            tableLayoutPanelMainBottom_MVS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMainBottom_MVS.AutoSize = true;
            tableLayoutPanelMainBottom_MVS.ColumnCount = 3;
            tableLayoutPanelMainBottom_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMainBottom_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMainBottom_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMainBottom_MVS.Controls.Add(buttonLoadProviders_MVS, 2, 0);
            tableLayoutPanelMainBottom_MVS.Controls.Add(buttonLoadFileDepartments_MVS, 0, 0);
            tableLayoutPanelMainBottom_MVS.Controls.Add(dataGridViewEmployees_MVS, 1, 1);
            tableLayoutPanelMainBottom_MVS.Controls.Add(dataGridViewDepartments_MVS, 0, 1);
            tableLayoutPanelMainBottom_MVS.Controls.Add(dataGridViewProviders_MVS, 2, 1);
            tableLayoutPanelMainBottom_MVS.Controls.Add(buttonLoadEmployees_MVS, 1, 0);
            tableLayoutPanelMainBottom_MVS.Location = new Point(0, 322);
            tableLayoutPanelMainBottom_MVS.Name = "tableLayoutPanelMainBottom_MVS";
            tableLayoutPanelMainBottom_MVS.RowCount = 2;
            tableLayoutPanelMainBottom_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMainBottom_MVS.RowStyles.Add(new RowStyle(SizeType.Absolute, 1729F));
            tableLayoutPanelMainBottom_MVS.Size = new Size(1448, 1789);
            tableLayoutPanelMainBottom_MVS.TabIndex = 0;
            // 
            // dataGridViewEmployees_MVS
            // 
            dataGridViewEmployees_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees_MVS.Dock = DockStyle.Fill;
            dataGridViewEmployees_MVS.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewEmployees_MVS.Location = new Point(485, 63);
            dataGridViewEmployees_MVS.Name = "dataGridViewEmployees_MVS";
            dataGridViewEmployees_MVS.RowHeadersWidth = 62;
            dataGridViewEmployees_MVS.Size = new Size(476, 1723);
            dataGridViewEmployees_MVS.TabIndex = 1;
            // 
            // dataGridViewDepartments_MVS
            // 
            dataGridViewDepartments_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments_MVS.Dock = DockStyle.Fill;
            dataGridViewDepartments_MVS.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDepartments_MVS.Location = new Point(3, 63);
            dataGridViewDepartments_MVS.Name = "dataGridViewDepartments_MVS";
            dataGridViewDepartments_MVS.RowHeadersWidth = 62;
            dataGridViewDepartments_MVS.Size = new Size(476, 1723);
            dataGridViewDepartments_MVS.TabIndex = 0;
            // 
            // dataGridViewProviders_MVS
            // 
            dataGridViewProviders_MVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProviders_MVS.Dock = DockStyle.Fill;
            dataGridViewProviders_MVS.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewProviders_MVS.Location = new Point(967, 63);
            dataGridViewProviders_MVS.Name = "dataGridViewProviders_MVS";
            dataGridViewProviders_MVS.RowHeadersWidth = 62;
            dataGridViewProviders_MVS.Size = new Size(478, 1723);
            dataGridViewProviders_MVS.TabIndex = 2;
            // 
            // tableLayoutPanelMainCenter_MVS
            // 
            tableLayoutPanelMainCenter_MVS.ColumnCount = 6;
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMainCenter_MVS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMidProviders_MVS, 4, 2);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMidEmployees_MVS, 2, 2);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMidEmployees_MVS, 3, 2);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonSaveProviders_MVS, 4, 3);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonSaveEmployees_MVS, 2, 3);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonSaveDepartments_MVS, 0, 3);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMinProviders_MVS, 4, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMinEmployees_MVS, 2, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMaxProviders_MVS, 4, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonMaxEmployees_MVS, 2, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMaxEmployees_MVS, 3, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMinEmployees_MVS, 3, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMaxProviders_MVS, 5, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMinProviders_MVS, 5, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(comboBoxSearchColumn_MVS, 1, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxSearch_MVS, 1, 2);
            tableLayoutPanelMainCenter_MVS.Controls.Add(comboBoxSearchTable_MVS, 0, 1);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxTableSearch_MVS, 0, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxColumnSearch_MVS, 1, 0);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxItemSearch_MVS, 0, 2);
            tableLayoutPanelMainCenter_MVS.Controls.Add(buttonSearch_MVS, 1, 3);
            tableLayoutPanelMainCenter_MVS.Controls.Add(textBoxMidProviders_MVS, 5, 2);
            tableLayoutPanelMainCenter_MVS.Dock = DockStyle.Top;
            tableLayoutPanelMainCenter_MVS.Location = new Point(0, 87);
            tableLayoutPanelMainCenter_MVS.Name = "tableLayoutPanelMainCenter_MVS";
            tableLayoutPanelMainCenter_MVS.RowCount = 4;
            tableLayoutPanelMainCenter_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006142F));
            tableLayoutPanelMainCenter_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanelMainCenter_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 24.998127F));
            tableLayoutPanelMainCenter_MVS.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanelMainCenter_MVS.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMainCenter_MVS.Size = new Size(1448, 232);
            tableLayoutPanelMainCenter_MVS.TabIndex = 1;
            tableLayoutPanelMainCenter_MVS.Paint += tableLayoutPanelMainCenter_MVS_Paint;
            // 
            // textBoxMidEmployees_MVS
            // 
            textBoxMidEmployees_MVS.Dock = DockStyle.Fill;
            textBoxMidEmployees_MVS.Location = new Point(726, 119);
            textBoxMidEmployees_MVS.Multiline = true;
            textBoxMidEmployees_MVS.Name = "textBoxMidEmployees_MVS";
            textBoxMidEmployees_MVS.Size = new Size(235, 51);
            textBoxMidEmployees_MVS.TabIndex = 31;
            // 
            // textBoxMaxEmployees_MVS
            // 
            textBoxMaxEmployees_MVS.Dock = DockStyle.Fill;
            textBoxMaxEmployees_MVS.Location = new Point(726, 3);
            textBoxMaxEmployees_MVS.Multiline = true;
            textBoxMaxEmployees_MVS.Name = "textBoxMaxEmployees_MVS";
            textBoxMaxEmployees_MVS.Size = new Size(235, 52);
            textBoxMaxEmployees_MVS.TabIndex = 20;
            // 
            // textBoxMinEmployees_MVS
            // 
            textBoxMinEmployees_MVS.Dock = DockStyle.Fill;
            textBoxMinEmployees_MVS.Location = new Point(726, 61);
            textBoxMinEmployees_MVS.Multiline = true;
            textBoxMinEmployees_MVS.Name = "textBoxMinEmployees_MVS";
            textBoxMinEmployees_MVS.Size = new Size(235, 52);
            textBoxMinEmployees_MVS.TabIndex = 21;
            // 
            // textBoxMaxProviders_MVS
            // 
            textBoxMaxProviders_MVS.Dock = DockStyle.Fill;
            textBoxMaxProviders_MVS.Location = new Point(1208, 3);
            textBoxMaxProviders_MVS.Multiline = true;
            textBoxMaxProviders_MVS.Name = "textBoxMaxProviders_MVS";
            textBoxMaxProviders_MVS.Size = new Size(237, 52);
            textBoxMaxProviders_MVS.TabIndex = 22;
            // 
            // textBoxMinProviders_MVS
            // 
            textBoxMinProviders_MVS.Dock = DockStyle.Fill;
            textBoxMinProviders_MVS.Location = new Point(1208, 61);
            textBoxMinProviders_MVS.Multiline = true;
            textBoxMinProviders_MVS.Name = "textBoxMinProviders_MVS";
            textBoxMinProviders_MVS.Size = new Size(237, 52);
            textBoxMinProviders_MVS.TabIndex = 23;
            // 
            // comboBoxSearchColumn_MVS
            // 
            comboBoxSearchColumn_MVS.Dock = DockStyle.Fill;
            comboBoxSearchColumn_MVS.FormattingEnabled = true;
            comboBoxSearchColumn_MVS.Location = new Point(244, 61);
            comboBoxSearchColumn_MVS.Name = "comboBoxSearchColumn_MVS";
            comboBoxSearchColumn_MVS.Size = new Size(235, 33);
            comboBoxSearchColumn_MVS.TabIndex = 25;
            // 
            // textBoxSearch_MVS
            // 
            textBoxSearch_MVS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch_MVS.Location = new Point(244, 139);
            textBoxSearch_MVS.Name = "textBoxSearch_MVS";
            textBoxSearch_MVS.Size = new Size(235, 31);
            textBoxSearch_MVS.TabIndex = 26;
            // 
            // comboBoxSearchTable_MVS
            // 
            comboBoxSearchTable_MVS.Dock = DockStyle.Fill;
            comboBoxSearchTable_MVS.FormattingEnabled = true;
            comboBoxSearchTable_MVS.Location = new Point(3, 61);
            comboBoxSearchTable_MVS.Name = "comboBoxSearchTable_MVS";
            comboBoxSearchTable_MVS.Size = new Size(235, 33);
            comboBoxSearchTable_MVS.TabIndex = 24;
            // 
            // textBoxTableSearch_MVS
            // 
            textBoxTableSearch_MVS.BorderStyle = BorderStyle.None;
            textBoxTableSearch_MVS.Dock = DockStyle.Bottom;
            textBoxTableSearch_MVS.Location = new Point(3, 31);
            textBoxTableSearch_MVS.Name = "textBoxTableSearch_MVS";
            textBoxTableSearch_MVS.Size = new Size(235, 24);
            textBoxTableSearch_MVS.TabIndex = 27;
            textBoxTableSearch_MVS.Text = "Выберите таблицу:";
            // 
            // textBoxColumnSearch_MVS
            // 
            textBoxColumnSearch_MVS.BorderStyle = BorderStyle.None;
            textBoxColumnSearch_MVS.Dock = DockStyle.Bottom;
            textBoxColumnSearch_MVS.Location = new Point(244, 31);
            textBoxColumnSearch_MVS.Name = "textBoxColumnSearch_MVS";
            textBoxColumnSearch_MVS.Size = new Size(235, 24);
            textBoxColumnSearch_MVS.TabIndex = 28;
            textBoxColumnSearch_MVS.Text = "Выберите столбец:";
            // 
            // textBoxItemSearch_MVS
            // 
            textBoxItemSearch_MVS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxItemSearch_MVS.BorderStyle = BorderStyle.None;
            textBoxItemSearch_MVS.Location = new Point(88, 146);
            textBoxItemSearch_MVS.Name = "textBoxItemSearch_MVS";
            textBoxItemSearch_MVS.Size = new Size(150, 24);
            textBoxItemSearch_MVS.TabIndex = 29;
            textBoxItemSearch_MVS.Text = "Что ищем:";
            // 
            // textBoxMidProviders_MVS
            // 
            textBoxMidProviders_MVS.Dock = DockStyle.Fill;
            textBoxMidProviders_MVS.Location = new Point(1208, 119);
            textBoxMidProviders_MVS.Multiline = true;
            textBoxMidProviders_MVS.Name = "textBoxMidProviders_MVS";
            textBoxMidProviders_MVS.Size = new Size(237, 51);
            textBoxMidProviders_MVS.TabIndex = 30;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1448, 900);
            Controls.Add(tableLayoutPanelMainCenter_MVS);
            Controls.Add(tableLayoutPanelMainBottom_MVS);
            Controls.Add(tableLayoutPanelMainTop_MVS);
            Name = "FormMain";
            Text = "Спринт 7  |  Тех. Задание |  Вариант 2 |  Мазуркевич В. С.";
            tableLayoutPanelMainTop_MVS.ResumeLayout(false);
            tableLayoutPanelMainTop_MVS.PerformLayout();
            tableLayoutPanelMainBottom_MVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees_MVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_MVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders_MVS).EndInit();
            tableLayoutPanelMainCenter_MVS.ResumeLayout(false);
            tableLayoutPanelMainCenter_MVS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonMidProviders_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMidEmployees_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSearch_MVS_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMinProviders_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMaxProviders_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMaxEmployees_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMinEmployees_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSaveDepartments_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSaveProviders_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSaveEmployees_MVS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMainTop_MVS;
        private TextBox textBoxMainTitle_MVS;
        private Button buttontoChart_MVS;
        private OpenFileDialog openFileDialog_MVS;
        private ToolTip toolTip_MVS;
        private SaveFileDialog saveFileDialog_MVS;
        private TableLayoutPanel tableLayoutPanelMainBottom_MVS;
        private Button buttonLoadFileDepartments_MVS;
        private DataGridView dataGridViewDepartments_MVS;
        private DataGridView dataGridViewProviders_MVS;
        private DataGridView dataGridViewEmployees_MVS;
        private Button buttonLoadEmployees_MVS;
        private Button buttonLoadProviders_MVS;
        private TableLayoutPanel tableLayoutPanelMainCenter_MVS;
        private Button buttonSearch_MVS;
        private Button buttonMinProviders_MVS;
        private Button buttonMinEmployees_MVS;
        private Button buttonMaxProviders_MVS;
        private Button buttonMaxEmployees_MVS;
        private Button buttonHelp_MVS;
        private Button buttonSaveDepartments_MVS;
        private Button buttonSaveProviders_MVS;
        private Button buttonSaveEmployees_MVS;
        private TextBox textBoxMaxEmployees_MVS;
        private TextBox textBoxMinEmployees_MVS;
        private TextBox textBoxMaxProviders_MVS;
        private TextBox textBoxMinProviders_MVS;
        private ComboBox comboBoxSearchTable_MVS;
        private ComboBox comboBoxSearchColumn_MVS;
        private TextBox textBoxSearch_MVS;
        private TextBox textBoxTableSearch_MVS;
        private TextBox textBoxColumnSearch_MVS;
        private TextBox textBoxItemSearch_MVS;
        private Button buttonMidEmployees_MVS;
        private TextBox textBoxMidEmployees_MVS;
        private TextBox textBoxMidProviders_MVS;
        private Button buttonMidProviders_MVS;
    }
}