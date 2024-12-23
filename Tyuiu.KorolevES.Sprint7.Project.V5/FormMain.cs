using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;
using System.IO;
using static System.Windows.Forms.DataFormats;
namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogData_KES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogData_KES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        string pathfileopen;
        string search = "";
        DataService ds = new DataService();
        public static string[,] matrix = new string[0, 9];
        public static int idrow;
        public static string[] column0 = new string[] { };
        public static string[] column1 = new string[] { };
        public static string[] column2 = new string[] { };
        public static string[] column3 = new string[] { };
        public static string[] column4 = new string[] { };
        public static string[] column5 = new string[] { };
        public static string[] column6 = new string[] { };
        public static string[] column7 = new string[] { };
        public static string[] column8 = new string[] { };
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
            dataGridViewData_KES.EnableHeadersVisualStyles = false;
            dataGridViewData_KES.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[5].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[6].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[7].HeaderCell.Style.BackColor = Color.White;
            dataGridViewData_KES.Columns[8].HeaderCell.Style.BackColor = Color.White;
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

            string[] values = search.Split(' ');
            for (int i = 0; i < dataGridViewData_KES.RowCount; i++)
            {
                int k = 1;
                if (search != "")
                {
                    k = 0;
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
                }
                int kk = FilterUse(i, k);
                if (kk == 0) dataGridViewData_KES.Rows[i].Visible = false;

            }
        }
        public int FilterUse(int i, int k)
        {
            foreach (string value in column0)
            {
                if (dataGridViewData_KES.Rows[i].Cells[0].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[0].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column1)
            {
                if (dataGridViewData_KES.Rows[i].Cells[1].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[1].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column2)
            {
                if (dataGridViewData_KES.Rows[i].Cells[2].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[2].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column3)
            {
                if (dataGridViewData_KES.Rows[i].Cells[3].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[3].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column4)
            {
                if (dataGridViewData_KES.Rows[i].Cells[4].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[4].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column5)
            {
                if (dataGridViewData_KES.Rows[i].Cells[5].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[5].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column6)
            {
                if (dataGridViewData_KES.Rows[i].Cells[6].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[6].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column7)
            {
                if (dataGridViewData_KES.Rows[i].Cells[7].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[7].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            foreach (string value in column8)
            {
                if (dataGridViewData_KES.Rows[i].Cells[8].Value.ToString() == value)
                {
                    dataGridViewData_KES.Columns[8].HeaderCell.Style.BackColor = Color.LightYellow;

                    k = 0;
                }
            }
            return k;
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
            search = textBoxSearch_KES.Text;
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

        private void buttonSaveFile_KES_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogData_KES.FileName = "Оптовая_база.csv";
                saveFileDialogData_KES.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogData_KES.ShowDialog();
                string path = ds.SaveFromFile(matrix, saveFileDialogData_KES.FileName);
                if (MessageBox.Show("Открыть сохраненный файл:" + path, "Открыть файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process csv = new System.Diagnostics.Process();
                    csv.StartInfo.FileName = "explorer.exe";
                    csv.StartInfo.Arguments = path;
                    csv.Start();
                }
            }
            catch
            {
                MessageBox.Show("Неудалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void columnSet(string[] mass)
        {
            if (idrow == 0)
            {
                column0 = new string[mass.Length];
                column0 = mass;
            }
            if (idrow == 1)
            {
                column1 = new string[mass.Length];
                column1 = mass;
            }
            if (idrow == 2)
            {
                column2 = new string[mass.Length];
                column2 = mass;
            }
            if (idrow == 3)
            {
                column3 = new string[mass.Length];
                column3 = mass;
            }
            if (idrow == 4)
            {
                column4 = new string[mass.Length];
                column4 = mass;
            }
            if (idrow == 5)
            {
                column5 = new string[mass.Length];
                column5 = mass;
            }
            if (idrow == 6)
            {
                column6 = new string[mass.Length];
                column6 = mass;
            }
            if (idrow == 7)
            {
                column7 = new string[mass.Length];
                column7 = mass;
            }
            if (idrow == 8)
            {
                column8 = new string[mass.Length];
                column8 = mass;
            }
            updateDataGrid(matrix);
        }
        private void buttonFilter_KES_Click(object sender, EventArgs e)
        {

            try
            {
                FormFilter formFilter = new FormFilter();
                idrow = Convert.ToInt32(dataGridViewData_KES.CurrentCellAddress.X);
                if (!((idrow >= 0) && (idrow <= 8))) idrow = 0;
                formFilter.ShowDialog();
                columnSet(formFilter.result);
            }
            catch
            {

            }
        }

        private void buttonRefreshFilter_KES_Click(object sender, EventArgs e)
        {
            search = "";
            column0 = new string[] { };
            column1 = new string[] { };
            column2 = new string[] { }; 
            column3 = new string[] { };
            column4 = new string[] { };
            column5 = new string[] { };
            column6 = new string[] { };
            column7 = new string[] { };
            column8 = new string[] { };
            updateDataGrid(matrix);
        }
    }
}
