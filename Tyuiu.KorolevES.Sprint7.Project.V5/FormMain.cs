using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;
using static System.Windows.Forms.DataFormats;
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
        public static string[,] matrix = new string[0, 9];
        public static int idrow;
        private void buttonOpenFile_KES_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_KES.ShowDialog();
                pathfileopen = openFileDialogData_KES.FileName;
                matrix = new string[ds.LoadFromFile(pathfileopen).GetLength(0), ds.LoadFromFile(pathfileopen).GetLength(1)];
                matrix = ds.LoadFromFile(pathfileopen);
                updateDataGrid(matrix);
            }
            catch
            {
                MessageBox.Show("Неудалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateDataGrid(string[,] data)
        {
            matrix = new string[data.GetLength(0), 9];
            matrix = data;
            dataGridViewData_KES.Rows.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridViewData_KES.Rows.Add();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "") matrix[i, j] = "-";
                    dataGridViewData_KES.Rows[i].Cells[j].Value = matrix[i, j];
                }
                dataGridViewData_KES.Rows[i].Cells[9].Value = Convert.ToString(i);
            }
            if (textBoxSearch_KES.Text != "")
            {
                string[] values = textBoxSearch_KES.Text.Split(' ');
                for (int i = 0; i < dataGridViewData_KES.RowCount; i++)
                {
                    int k = 0;
                    for (int j = 0; j < 9; j++)
                    {
                        foreach (string value in values)
                        {
                            if (dataGridViewData_KES.Rows[i].Cells[j].Value.ToString().Contains(value))
                            {
                                k = 1;
                                dataGridViewData_KES.Rows[i].Cells[j].Style.BackColor = Color.BlueViolet;
                                dataGridViewData_KES.Rows[i].Cells[j].Style.ForeColor = Color.White;
                            }
                        }
                    }
                    if (k == 0) dataGridViewData_KES.Rows[i].Visible = false;
                }
            }
        }


        private void buttonAdd_KES_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdd formAdd = new FormAdd();
                formAdd.ShowDialog();
                updateDataGrid(formAdd.matrixedit);
            }
            catch { }
        }

        private void buttonEdit_KES_Click(object sender, EventArgs e)
        {
            try
            {
                FormEdit formEdit = new FormEdit();
                idrow = Convert.ToInt32(dataGridViewData_KES.CurrentRow.Cells[9].Value);
                formEdit.ShowDialog();
                updateDataGrid(formEdit.matrixedit);
            }
            catch
            {

            }
        }

        private void buttonSearch_KES_Click(object sender, EventArgs e)
        {
            updateDataGrid(matrix);

        }

        private void buttonDelete_KES_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить элемент без возможности востановить?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    idrow = Convert.ToInt32(dataGridViewData_KES.CurrentRow.Cells[9].Value);
                    string[,] matrixedit = new string[matrix.GetLength(0) - 1, 9];
                    matrixedit = ds.DeleteProduct(matrix, idrow);
                    updateDataGrid(matrixedit);
                }
                catch { }
            }
        }

    }
}
