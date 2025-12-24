using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.MazurkevichVS.Sprint7.Project.V2.Lib;

namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();



        private void buttonBuildChart_MVS_Click(object sender, EventArgs e)
        {
            this.chart_MVS.ChartAreas[0].AxisY.Title = "Количество новых филиалов";
            this.chart_MVS.ChartAreas[0].AxisX.Title = "Год";

            chart_MVS.Series[0].Points.Clear();
            DataService ds = new DataService();

            Dictionary<string, int> arrays = ds.GetNumberOfDepartments(@"C:\DataSprint7\Departments.csv");

            foreach (KeyValuePair<string, int> kvp in arrays)
            {
                string xValue = kvp.Key;
                double yValue = kvp.Value;
                chart_MVS.Series[0].Points.AddXY(xValue, yValue);
            }
        }
    }
}
