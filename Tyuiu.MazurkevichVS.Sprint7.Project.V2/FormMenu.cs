
namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void buttonInfo_MVS_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
        private void buttonOpen_MVS_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.ShowDialog();
        }
    }
}
