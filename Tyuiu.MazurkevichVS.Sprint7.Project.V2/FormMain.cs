using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MazurkevichVS.Sprint7.Project.V2.Lib;

namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_MVS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_MVS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            InitializeSearchSimple(); 
            AttachColumnHeaderClickHandlers();
        }

        DataService ds = new DataService();
        static string openFilePath;
        static int rowsDepartmens = 0;
        static int columnsDepartmens = 0;

        static int rowsEmployees = 0;
        static int columnsEmployees = 0;
        static int rowsProviders = 0;
        static int columnsProviders = 0;

        private Dictionary<string, bool> sortDirections = new Dictionary<string, bool>(); 
        private string lastSortedColumn = "";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // кнопка формы с графиком
        private void buttontoChart_MVS_Click(object sender, EventArgs e)
        {
            FormChart form = new FormChart();
            form.ShowDialog();
        }

        // кнопка краткого руководства пользователя
        private void buttonHelp_MVS_Click(Object sender, EventArgs e)
        {
            FormHelpUser form = new FormHelpUser();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // кнопка загрузки для таблицы поставщиков
        private void buttonLoadProviders_MVS_Click(object sender, EventArgs e)
        {
            openFileDialog_MVS.ShowDialog();
            openFilePath = openFileDialog_MVS.FileName;
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewProviders_MVS.DefaultCellStyle.Font = newFont;
                string[,] MatrixProviders = ds.LoadDataFromFile(openFilePath);
                int actualRows = MatrixProviders.GetLength(0);
                int actualColumns = MatrixProviders.GetLength(1);

                rowsProviders = actualRows;
                columnsProviders = actualColumns;

                dataGridViewProviders_MVS.Rows.Clear();
                dataGridViewProviders_MVS.Columns.Clear();

                dataGridViewProviders_MVS.ColumnCount = actualColumns;
                dataGridViewProviders_MVS.RowCount = actualRows + 1;


                dataGridViewProviders_MVS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                dataGridViewProviders_MVS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                dataGridViewProviders_MVS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewProviders_MVS.DefaultCellStyle.ForeColor = Color.Black;

                dataGridViewProviders_MVS.Columns[0].Width = 45;
                dataGridViewProviders_MVS.Columns[0].HeaderText = "№";

                dataGridViewProviders_MVS.Columns[1].Width = 150;
                dataGridViewProviders_MVS.Columns[1].HeaderText = "Фамилия";

                dataGridViewProviders_MVS.Columns[2].Width = 60;
                dataGridViewProviders_MVS.Columns[2].HeaderText = "И. О.";

                dataGridViewProviders_MVS.Columns[3].Width = 200;
                dataGridViewProviders_MVS.Columns[3].HeaderText = "Адрес";

                dataGridViewProviders_MVS.Columns[4].Width = 170;
                dataGridViewProviders_MVS.Columns[4].HeaderText = "Телефон";

                dataGridViewProviders_MVS.Columns[5].Width = 200;
                dataGridViewProviders_MVS.Columns[5].HeaderText = "Стоимость поставки";

                for (int r = 0; r < rowsProviders; r++)
                {
                    for (int c = 0; c < columnsProviders; c++)
                    {
                        dataGridViewProviders_MVS.Rows[r + 1].Cells[c].Value = MatrixProviders[r, c];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateSearchColumnsSimple();
        }

        // кнопка загрузки для таблицы сотрудников
        private void buttonLoadEmployees_MVS_Click(object sender, EventArgs e)
        {
            openFileDialog_MVS.ShowDialog();
            openFilePath = openFileDialog_MVS.FileName;
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewEmployees_MVS.DefaultCellStyle.Font = newFont;
                string[,] MatrixEmployees = ds.LoadDataFromFile(openFilePath);
                int actualRows = MatrixEmployees.GetLength(0);
                int actualColumns = MatrixEmployees.GetLength(1);

                rowsEmployees = actualRows;
                columnsEmployees = actualColumns;

                dataGridViewEmployees_MVS.Rows.Clear();
                dataGridViewEmployees_MVS.Columns.Clear();

                dataGridViewEmployees_MVS.ColumnCount = actualColumns;
                dataGridViewEmployees_MVS.RowCount = actualRows + 1;


                dataGridViewEmployees_MVS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                dataGridViewEmployees_MVS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                dataGridViewEmployees_MVS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewEmployees_MVS.DefaultCellStyle.ForeColor = Color.Black;

                dataGridViewEmployees_MVS.Columns[0].Width = 45;
                dataGridViewEmployees_MVS.Columns[0].HeaderText = "№";

                dataGridViewEmployees_MVS.Columns[1].Width = 150;
                dataGridViewEmployees_MVS.Columns[1].HeaderText = "Фамилия";

                dataGridViewEmployees_MVS.Columns[2].Width = 60;
                dataGridViewEmployees_MVS.Columns[2].HeaderText = "И. О.";

                dataGridViewEmployees_MVS.Columns[3].Width = 200;
                dataGridViewEmployees_MVS.Columns[3].HeaderText = "Адрес";

                dataGridViewEmployees_MVS.Columns[4].Width = 170;
                dataGridViewEmployees_MVS.Columns[4].HeaderText = "Телефон";

                dataGridViewEmployees_MVS.Columns[5].Width = 200;
                dataGridViewEmployees_MVS.Columns[5].HeaderText = "Капитал";

                for (int r = 0; r < rowsEmployees; r++)
                {
                    for (int c = 0; c < columnsEmployees; c++)
                    {
                        dataGridViewEmployees_MVS.Rows[r + 1].Cells[c].Value = MatrixEmployees[r, c];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateSearchColumnsSimple();
        }

        // кнопка загрузки для таблицы филиалов
        private void buttonLoadFileDepartments_MVS_Click(Object sender, EventArgs e)
        {
            openFileDialog_MVS.ShowDialog();
            openFilePath = openFileDialog_MVS.FileName;
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewDepartments_MVS.DefaultCellStyle.Font = newFont;
                string[,] MatrixDepartmens = ds.LoadDataFromFile(openFilePath);
                int actualRows = MatrixDepartmens.GetLength(0);
                int actualColumns = MatrixDepartmens.GetLength(1);

                rowsDepartmens = actualRows;
                columnsDepartmens = actualColumns;

                dataGridViewDepartments_MVS.Rows.Clear();
                dataGridViewDepartments_MVS.Columns.Clear();

                dataGridViewDepartments_MVS.ColumnCount = actualColumns;
                dataGridViewDepartments_MVS.RowCount = actualRows + 1;


                dataGridViewDepartments_MVS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                dataGridViewDepartments_MVS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                dataGridViewDepartments_MVS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewDepartments_MVS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewDepartments_MVS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewDepartments_MVS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewDepartments_MVS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                dataGridViewDepartments_MVS.DefaultCellStyle.ForeColor = Color.Black;

                dataGridViewDepartments_MVS.Columns[0].Width = 45;
                dataGridViewDepartments_MVS.Columns[0].HeaderText = "№";

                dataGridViewDepartments_MVS.Columns[1].Width = 200;
                dataGridViewDepartments_MVS.Columns[1].HeaderText = "Город";

                dataGridViewDepartments_MVS.Columns[2].Width = 200;
                dataGridViewDepartments_MVS.Columns[2].HeaderText = "Адрес";

                dataGridViewDepartments_MVS.Columns[3].Width = 200;
                dataGridViewDepartments_MVS.Columns[3].HeaderText = "Телефон";

                dataGridViewDepartments_MVS.Columns[4].Width = 200;
                dataGridViewDepartments_MVS.Columns[4].HeaderText = "Год открытия филиала";

                for (int r = 0; r < rowsDepartmens; r++)
                {
                    for (int c = 0; c < columnsDepartmens; c++)
                    {
                        dataGridViewDepartments_MVS.Rows[r + 1].Cells[c].Value = MatrixDepartmens[r, c];
                    }
                }

                UpdateSearchColumnsSimple();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка сохранения для таблицы филиалов
        private void buttonSaveDepartments_MVS_Click(object sender, EventArgs e)
        {
            saveFileDialog_MVS.FileName = "NewDepartments.csv";
            saveFileDialog_MVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MVS.ShowDialog();
            int rows = dataGridViewDepartments_MVS.RowCount;
            int columns = dataGridViewDepartments_MVS.ColumnCount;
            string path = saveFileDialog_MVS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewDepartments_MVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewDepartments_MVS.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        // кнопка сохранения для таблицы сотрудников
        private void buttonSaveEmployees_MVS_Click(object sender, EventArgs e)
        {
            saveFileDialog_MVS.FileName = "NewEmployees.csv";
            saveFileDialog_MVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MVS.ShowDialog();
            int rows = dataGridViewEmployees_MVS.RowCount;
            int columns = dataGridViewEmployees_MVS.ColumnCount;
            string path = saveFileDialog_MVS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewEmployees_MVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewEmployees_MVS.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        // кнопка сохранения для таблицы поставщиков
        private void buttonSaveProviders_MVS_Click(object sender, EventArgs e)
        {
            saveFileDialog_MVS.FileName = "NewProviders.csv";
            saveFileDialog_MVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MVS.ShowDialog();
            int rows = dataGridViewProviders_MVS.RowCount;
            int columns = dataGridViewProviders_MVS.ColumnCount;
            string path = saveFileDialog_MVS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewProviders_MVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewProviders_MVS.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        // кнопка минимума для таблицы сотрудников
        private void buttonMinEmployees_MVS_Click(object sender, EventArgs e)
        {
            int minimum = 123456789;
            for (int i = 0; i < dataGridViewEmployees_MVS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value) < minimum) && (Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value) != 0))
                {
                    minimum = Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value);
                }
            }
            textBoxMinEmployees_MVS.Text = minimum.ToString();
        }

        // кнопка максимума для таблицы сотрудников
        private void buttonMaxEmployees_MVS_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            for (int i = 0; i < dataGridViewEmployees_MVS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value) > maximum) && (Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value) != 0))
                {
                    maximum = Convert.ToInt32(dataGridViewEmployees_MVS.Rows[i].Cells[5].Value);
                }
            }
            textBoxMaxEmployees_MVS.Text = maximum.ToString();
        }

        // кнопка максимума для таблицы поставщиков
        private void buttonMaxProviders_MVS_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            for (int i = 0; i < dataGridViewProviders_MVS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value) > maximum) && (Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value) != 0))
                {
                    maximum = Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value);
                }
            }
            textBoxMaxProviders_MVS.Text = maximum.ToString();
        }

        // кнопка минимума для таблицы поставщиков
        private void buttonMinProviders_MVS_Click(object sender, EventArgs e)
        {
            int minimum = 123456789;
            for (int i = 0; i < dataGridViewProviders_MVS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value) < minimum) && (Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value) != 0))
                {
                    minimum = Convert.ToInt32(dataGridViewProviders_MVS.Rows[i].Cells[5].Value);
                }
            }
            textBoxMinProviders_MVS.Text = minimum.ToString();
        }

        // кнопка среднего значения для таблицы сотрудников
        private void buttonMidEmployees_MVS_Click(object sender, EventArgs e)
            {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewEmployees_MVS.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    sum += value;
                    count++;
                }
            }

            textBoxMidEmployees_MVS.Text = count > 0 ? Math.Round(sum / count, 2).ToString() : "Нет данных";
        }

        // кнопка среднего значения для таблицы поставщиков
        private void buttonMidProviders_MVS_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewProviders_MVS.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    sum += value;
                    count++;
                }
            }

            textBoxMidProviders_MVS.Text = count > 0 ? Math.Round(sum / count, 2).ToString() : "Нет данных";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // поиск
        private void InitializeSearchSimple()
        {
            try
            {
               
                if (comboBoxSearchTable_MVS != null)
                {
                    comboBoxSearchTable_MVS.Items.Clear();
                    comboBoxSearchTable_MVS.Items.Add("Филиалы");
                    comboBoxSearchTable_MVS.Items.Add("Сотрудники");
                    comboBoxSearchTable_MVS.Items.Add("Поставщики");
                    comboBoxSearchTable_MVS.SelectedIndex = 0;

                    
                    comboBoxSearchTable_MVS.SelectedIndexChanged += (s, e) => UpdateSearchColumnsSimple();
                }

                
                if (buttonSearch_MVS != null)
                {
                    buttonSearch_MVS.Click += (s, e) => SearchSimple();
                }

                
                if (textBoxSearch_MVS != null)
                {
                    textBoxSearch_MVS.KeyPress += (s, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            SearchSimple();
                            e.Handled = true;
                        }
                    };
                }

                
                UpdateSearchColumnsSimple();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка инициализации поиска: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void UpdateSearchColumnsSimple()
        {
            if (comboBoxSearchColumn_MVS == null || comboBoxSearchTable_MVS == null) return;

            comboBoxSearchColumn_MVS.Items.Clear();

            int tableIndex = comboBoxSearchTable_MVS.SelectedIndex;

            switch (tableIndex)
            {
                case 0: // филиалы
                    comboBoxSearchColumn_MVS.Items.Add("Все столбцы");
                    comboBoxSearchColumn_MVS.Items.Add("Город");
                    comboBoxSearchColumn_MVS.Items.Add("Адрес");
                    comboBoxSearchColumn_MVS.Items.Add("Телефон");
                    comboBoxSearchColumn_MVS.Items.Add("Год открытия филиала");
                    break;

                case 1: // сотрудники
                    comboBoxSearchColumn_MVS.Items.Add("Все столбцы");
                    comboBoxSearchColumn_MVS.Items.Add("Фамилия");
                    comboBoxSearchColumn_MVS.Items.Add("И.О.");
                    comboBoxSearchColumn_MVS.Items.Add("Адрес");
                    comboBoxSearchColumn_MVS.Items.Add("Телефон");
                    comboBoxSearchColumn_MVS.Items.Add("Капитал");
                    break;

                case 2: // поставщики
                    comboBoxSearchColumn_MVS.Items.Add("Все столбцы");
                    comboBoxSearchColumn_MVS.Items.Add("Фамилия");
                    comboBoxSearchColumn_MVS.Items.Add("И.О.");
                    comboBoxSearchColumn_MVS.Items.Add("Адрес");
                    comboBoxSearchColumn_MVS.Items.Add("Телефон");
                    comboBoxSearchColumn_MVS.Items.Add("Стоимость поставки");
                    break;
            }

            if (comboBoxSearchColumn_MVS.Items.Count > 0)
                comboBoxSearchColumn_MVS.SelectedIndex = 0;
        }

        private void SearchSimple()
        {
            try
            {
                
                if (comboBoxSearchTable_MVS == null || comboBoxSearchColumn_MVS == null || textBoxSearch_MVS == null)
                {
                    MessageBox.Show("Элементы поиска не найдены", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string searchText = textBoxSearch_MVS.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Введите текст для поиска", "Внимание",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                int tableIndex = comboBoxSearchTable_MVS.SelectedIndex;
                int columnIndex = comboBoxSearchColumn_MVS.SelectedIndex;
                string columnName = comboBoxSearchColumn_MVS.SelectedItem?.ToString() ?? "";



                
                int foundCount = 0;

                switch (tableIndex)
                {
                    case 0: // филиалы
                        foundCount = SearchInDataGridView(dataGridViewDepartments_MVS, searchText, columnName);
                        break;

                    case 1: // сотрудники
                        foundCount = SearchInDataGridView(dataGridViewEmployees_MVS, searchText, columnName);
                        break;

                    case 2: // поставщики
                        foundCount = SearchInDataGridView(dataGridViewProviders_MVS, searchText, columnName);
                        break;
                }

                
                if (foundCount > 0)
                {
                    MessageBox.Show($"Найдено {foundCount} совпадений", "Результат поиска",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено", "Результат поиска",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private int SearchInDataGridView(DataGridView dataGridView, string searchText, string columnName)
        {
            if (dataGridView == null)
            {
                MessageBox.Show("Таблица не найдена", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            int foundCount = 0;

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                
                if (row == null) continue;

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i] != null)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(204, 187, 231);
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
               
                if (row == null || row.IsNewRow) continue;
                // поиск по всем столбцам
                if (columnName == "Все столбцы")
                {
                   
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        var cell = row.Cells[i];
                        if (cell != null && cell.Value != null)
                        {
                            string cellValue = cell.Value.ToString();
                            if (!string.IsNullOrEmpty(cellValue) &&
                                cellValue.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                cell.Style.BackColor = Color.Yellow;
                                cell.Style.ForeColor = Color.Black;
                                foundCount++;

                            }
                        }
                    }
                }
                else
                {
                    // поиск по конкретному столбцу
                    int columnIndex = GetActualColumnIndex(dataGridView, columnName);

                    if (columnIndex >= 0 && columnIndex < row.Cells.Count)
                    {
                        var cell = row.Cells[columnIndex];
                        if (cell != null && cell.Value != null)
                        {
                            string cellValue = cell.Value.ToString();
                            if (!string.IsNullOrEmpty(cellValue) &&
                                cellValue.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                cell.Style.BackColor = Color.Yellow;
                                cell.Style.ForeColor = Color.Black;
                                foundCount++;

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Столбец '{columnName}' не найден в таблице", "Внимание",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            return foundCount;
        }

        // метод для правильного индекса столбца
        private int GetActualColumnIndex(DataGridView dataGridView, string columnDisplayName)
        {
            if (dataGridView == null) return -1;

           
            Dictionary<string, int> columnMapping = new Dictionary<string, int>();

           
            switch (columnDisplayName)
            {
                case "Город":
                    return 1; 

                case "Адрес":
                    return 2; 

                case "Телефон":
                    return 3; 

                case "Год открытия":
                    return 4; 

                case "Фамилия":
                    return 1; 

                case "И.О.":
                    return 2;

                case "Капитал":
                    return 5; 

                case "Стоимость поставки":
                    return 5; 

                default:
                    
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        if (dataGridView.Columns[i].HeaderText == columnDisplayName)
                            return i;
                    }
                    return -1;
            }
        }

        // сортировка внутри таблиц
        private string GetTableName(DataGridView dataGridView)
        {
            if (dataGridView == dataGridViewDepartments_MVS) return "Филиалы";
            if (dataGridView == dataGridViewEmployees_MVS) return "Сотрудники";
            if (dataGridView == dataGridViewProviders_MVS) return "Поставщики";
            return "Неизвестная таблица";
        }

        
        private void UpdateColumnHeader(DataGridView dataGridView, int columnIndex, bool ascending)
        {
            if (dataGridView == null || columnIndex < 0 || columnIndex >= dataGridView.Columns.Count) return;

            try
            {
                
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    string headerText = column.HeaderText;
                    
                    if (headerText.EndsWith(" ▲") || headerText.EndsWith(" ▼"))
                    {
                        column.HeaderText = headerText.Substring(0, headerText.Length - 2);
                    }
                }

                
                string currentHeader = dataGridView.Columns[columnIndex].HeaderText;
                
                if (currentHeader.EndsWith(" ▲") || currentHeader.EndsWith(" ▼"))
                {
                    currentHeader = currentHeader.Substring(0, currentHeader.Length - 2);
                }

                dataGridView.Columns[columnIndex].HeaderText = $"{currentHeader} {(ascending ? "▲" : "▼")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления заголовка: {ex.Message}");
            }
        }

        private void dataGridViewDepartments_MVS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SortOnColumnClick(dataGridViewDepartments_MVS, e.ColumnIndex);
            }
        }

        private void dataGridViewEmployees_MVS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SortOnColumnClick(dataGridViewEmployees_MVS, e.ColumnIndex);
            }
        }

        private void dataGridViewProviders_MVS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SortOnColumnClick(dataGridViewProviders_MVS, e.ColumnIndex);
            }
        }

        
        private void SortOnColumnClick(DataGridView dataGridView, int columnIndex)
        {
            try
            {
                if (dataGridView == null || dataGridView.Rows.Count <= 1)
                {
                    MessageBox.Show("Нет данных для сортировки", "Внимание",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (columnIndex == 0)
                {
                    MessageBox.Show("Сортировка по номеру недоступна", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string columnName = dataGridView.Columns[columnIndex].HeaderText;
                string tableName = GetTableName(dataGridView);
                string sortKey = $"{tableName}_{columnName}";

                
                bool ascending = true;
                if (lastSortedColumn == sortKey && sortDirections.ContainsKey(sortKey))
                {
                    ascending = !sortDirections[sortKey];
                }

                sortDirections[sortKey] = ascending;
                lastSortedColumn = sortKey;

                
                DataTable dt = new DataTable();

                
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dt.Columns.Add(column.HeaderText, typeof(string));
                }

                
                int rowsToAdd = dataGridView.AllowUserToAddRows ? dataGridView.Rows.Count - 1 : dataGridView.Rows.Count;

                for (int i = 0; i < rowsToAdd; i++)
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        dr[j] = dataGridView.Rows[i].Cells[j].Value ?? "";
                    }
                    dt.Rows.Add(dr);
                }

                // сортировка
                DataView dv = dt.DefaultView;

                
                if (columnName == "Капитал" || columnName == "Стоимость поставки" || columnName == "Год открытия филиала")
                {
                    
                    dt.Columns.Add("TempSort", typeof(int));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string value = dt.Rows[i][columnIndex].ToString();
                        if (int.TryParse(value, out int numValue))
                        {
                            dt.Rows[i]["TempSort"] = numValue;
                        }
                        else
                        {
                            dt.Rows[i]["TempSort"] = 0;
                        }
                    }
                    dv.Sort = $"TempSort {(ascending ? "ASC" : "DESC")}";
                }
                else
                {
                    dv.Sort = $"[{columnName}] {(ascending ? "ASC" : "DESC")}";
                }

                
                dataGridView.Rows.Clear();

                for (int i = 0; i < dv.Count; i++)
                {
                    int rowIndex = dataGridView.Rows.Add();
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        dataGridView.Rows[rowIndex].Cells[j].Value = dv[i][j];
                    }
                }

                
                if (dataGridView.AllowUserToAddRows)
                {
                    dataGridView.Rows.Add();
                }

                
                UpdateColumnHeader(dataGridView, columnIndex, ascending);

                
                if (dataGridView.Rows.Count > 0)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex = 0;
                }

                
                string direction = ascending ? "по возрастанию" : "по убыванию";
                MessageBox.Show($"Таблица '{tableName}' отсортирована по столбцу '{columnName}' {direction}",
                              "Сортировка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // привязка обработчиков
        private void AttachColumnHeaderClickHandlers()
        {
            try
            {
                if (dataGridViewDepartments_MVS != null)
                {
                    dataGridViewDepartments_MVS.ColumnHeaderMouseClick -= dataGridViewDepartments_MVS_ColumnHeaderMouseClick;
                    dataGridViewDepartments_MVS.ColumnHeaderMouseClick += dataGridViewDepartments_MVS_ColumnHeaderMouseClick;
                }

                if (dataGridViewEmployees_MVS != null)
                {
                    dataGridViewEmployees_MVS.ColumnHeaderMouseClick -= dataGridViewEmployees_MVS_ColumnHeaderMouseClick;
                    dataGridViewEmployees_MVS.ColumnHeaderMouseClick += dataGridViewEmployees_MVS_ColumnHeaderMouseClick;
                }

                if (dataGridViewProviders_MVS != null)
                {
                    dataGridViewProviders_MVS.ColumnHeaderMouseClick -= dataGridViewProviders_MVS_ColumnHeaderMouseClick;
                    dataGridViewProviders_MVS.ColumnHeaderMouseClick += dataGridViewProviders_MVS_ColumnHeaderMouseClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка привязки обработчиков сортировки: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanelMainCenter_MVS_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

