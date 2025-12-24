using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        DataService ds = new DataService();
        static string openFilePath;
        static int rowsDepartmens = 0;
        static int columnsDepartmens = 0;
        static int columnsSearchDepartments = 0;

        static int rowsEmployees = 0;
        static int columnsEmployees = 0;
        static int rowsProviders = 0;
        static int columnsProviders = 0;

        private string currentSearchTable = "";
        private string currentSearchColumn = "";
        private string currentSearchQuery = "";
        private List<DataGridViewRow> originalRowsDepartments = new List<DataGridViewRow>();
        private List<DataGridViewRow> originalRowsEmployees = new List<DataGridViewRow>();
        private List<DataGridViewRow> originalRowsProviders = new List<DataGridViewRow>();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttontoChart_MVS_Click(object sender, EventArgs e)
        {
            FormChart form = new FormChart();
            form.ShowDialog();
        }

        private void buttonHelp_MVS_Click(Object sender, EventArgs e)
        {
            FormHelpUser form = new FormHelpUser();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeSearchSimple()
        {
            try
            {
                // Настройка ComboBox для выбора таблицы
                if (comboBoxSearchTable_MVS != null)
                {
                    comboBoxSearchTable_MVS.Items.Clear();
                    comboBoxSearchTable_MVS.Items.Add("Филиалы");
                    comboBoxSearchTable_MVS.Items.Add("Сотрудники");
                    comboBoxSearchTable_MVS.Items.Add("Поставщики");
                    comboBoxSearchTable_MVS.SelectedIndex = 0;

                    // Добавляем обработчик изменения
                    comboBoxSearchTable_MVS.SelectedIndexChanged += (s, e) => UpdateSearchColumnsSimple();
                }

                // Настройка кнопки поиска
                if (buttonSearch_MVS != null)
                {
                    buttonSearch_MVS.Click += (s, e) => SearchSimple();
                }

                // Настройка TextBox для поиска по Enter
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

                // Инициализация ComboBox для столбцов
                UpdateSearchColumnsSimple();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка инициализации поиска: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ОБНОВЛЕНИЕ СТОЛБЦОВ ДЛЯ ПОИСКА (ПРОСТОЙ ВАРИАНТ)
        private void UpdateSearchColumnsSimple()
        {
            if (comboBoxSearchColumn_MVS == null || comboBoxSearchTable_MVS == null) return;

            comboBoxSearchColumn_MVS.Items.Clear();

            int tableIndex = comboBoxSearchTable_MVS.SelectedIndex;

            switch (tableIndex)
            {
                case 0: // Филиалы
                    comboBoxSearchColumn_MVS.Items.Add("Все столбцы");
                    comboBoxSearchColumn_MVS.Items.Add("Город");
                    comboBoxSearchColumn_MVS.Items.Add("Адрес");
                    comboBoxSearchColumn_MVS.Items.Add("Телефон");
                    comboBoxSearchColumn_MVS.Items.Add("Год открытия филиала");
                    break;

                case 1: // Сотрудники
                    comboBoxSearchColumn_MVS.Items.Add("Все столбцы");
                    comboBoxSearchColumn_MVS.Items.Add("Фамилия");
                    comboBoxSearchColumn_MVS.Items.Add("И.О.");
                    comboBoxSearchColumn_MVS.Items.Add("Адрес");
                    comboBoxSearchColumn_MVS.Items.Add("Телефон");
                    comboBoxSearchColumn_MVS.Items.Add("Капитал");
                    break;

                case 2: // Поставщики
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

        // ПРОСТОЙ МЕТОД ПОИСКА
        private void SearchSimple()
        {
            try
            {
                // Проверяем, что все элементы есть
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

                // Определяем, в какой таблице искать
                int tableIndex = comboBoxSearchTable_MVS.SelectedIndex;
                int columnIndex = comboBoxSearchColumn_MVS.SelectedIndex;
                string columnName = comboBoxSearchColumn_MVS.SelectedItem?.ToString() ?? "";

                

                // Выполняем поиск
                int foundCount = 0;

                switch (tableIndex)
                {
                    case 0: // Филиалы
                        foundCount = SearchInDataGridView(dataGridViewDepartments_MVS, searchText, columnName);
                        break;

                    case 1: // Сотрудники
                        foundCount = SearchInDataGridView(dataGridViewEmployees_MVS, searchText, columnName);
                        break;

                    case 2: // Поставщики
                        foundCount = SearchInDataGridView(dataGridViewProviders_MVS, searchText, columnName);
                        break;
                }

                // Показываем результат
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

        // ИСПРАВЛЕННЫЙ МЕТОД ПОИСКА В DATAGRIDVIEW
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

            // Сначала сбрасываем все подсветки в этой таблице
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Проверяем, что строка не null
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

            // Выполняем поиск и подсветку
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Пропускаем пустые строки и строки null
                if (row == null || row.IsNewRow) continue;

                if (columnName == "Все столбцы")
                {
                    // Поиск по всем столбцам
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
                    // Поиск по конкретному столбцу
                    // Преобразуем имя столбца в индекс
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

        // НОВЫЙ МЕТОД ДЛЯ ПОЛУЧЕНИЯ ПРАВИЛЬНОГО ИНДЕКСА СТОЛБЦА
        private int GetActualColumnIndex(DataGridView dataGridView, string columnDisplayName)
        {
            if (dataGridView == null) return -1;

            // Преобразуем отображаемое имя в индекс столбца
            Dictionary<string, int> columnMapping = new Dictionary<string, int>();

            // Сопоставляем отображаемые имена с индексами
            switch (columnDisplayName)
            {
                case "Город":
                    return 1; // Второй столбец (индекс 1)

                case "Адрес":
                    return 2; // Третий столбец (индекс 2)

                case "Телефон":
                    return 3; // Четвертый столбец (индекс 3)

                case "Год открытия":
                    return 4; // Пятый столбец (индекс 4)

                case "Фамилия":
                    return 1; // Для сотрудников и поставщиков

                case "И.О.":
                    return 2;

                case "Капитал":
                    return 5; // Для сотрудников

                case "Стоимость поставки":
                    return 5; // Для поставщиков

                default:
                    // Пытаемся найти по заголовку столбца
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        if (dataGridView.Columns[i].HeaderText == columnDisplayName)
                            return i;
                    }
                    return -1;
            }
        }




    }

}

