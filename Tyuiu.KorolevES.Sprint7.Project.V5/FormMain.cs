using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;
namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogData_KES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        string pathfileopen;
        DataService ds = new DataService();
        public static string[,] matrix =new string[0,9];
        private void buttonOpenFile_KES_Click(object sender, EventArgs e)
        {
            openFileDialogData_KES.ShowDialog();
            pathfileopen = openFileDialogData_KES.FileName;
            matrix = new string[ds.LoadFromFile(pathfileopen).GetLength(0), ds.LoadFromFile(pathfileopen).GetLength(1)];
            matrix = ds.LoadFromFile(pathfileopen);
            dataGridViewData_KES.Rows.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridViewData_KES.Rows.Add();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewData_KES.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }


        private void buttonAdd_KES_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            matrix = new string[formAdd.matrixedit.GetLength(0), 9];
            matrix=formAdd.matrixedit;
            dataGridViewData_KES.Rows.Clear();
            for (int i = 0; i < formAdd.matrixedit.GetLength(0); i++)
            {
                dataGridViewData_KES.Rows.Add();
                for (int j = 0; j < formAdd.matrixedit.GetLength(1); j++)
                {
                    dataGridViewData_KES.Rows[i].Cells[j].Value = formAdd.matrixedit[i, j];
                }
            }
        }
    
    }
}
