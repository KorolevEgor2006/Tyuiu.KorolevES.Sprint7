using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;

namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        private void buttonCloseEdit_KES_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string[,] matrixedit;
        private void buttonEditProduct_KES_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string[] datas = new string[9];
            datas[0] = textBoxVarCodeProduct_KES.Text;
            datas[1] = textBoxVarNameProduct_KES.Text;
            try
            {
                datas[2] = decimal.Parse(textBoxVarCountProduct_KES.Text).ToString();
            }
            catch { datas[2] = "0"; }
            try
            {
                datas[3] = decimal.Parse(textBoxVarCostProduct_KES.Text).ToString();
            }
            catch { datas[3] = "0"; }
            datas[4] = textBoxDiscriptionProduct_KES.Text;
            datas[5] = textBoxVarNumProvider_KES.Text;
            datas[6] = textBoxVarFullNameProvider_KES.Text;
            try
            {
                datas[7] = (DateTime.Parse(textBoxVarDateSully_KES.Text)).ToString("yyyy-MM-dd");
            }
            catch { datas[7] = "-"; }
            try
            {
                datas[8] = decimal.Parse(textBoxVarCountSally_KES.Text).ToString();
            }
            catch { datas[8] = "0"; }
            matrixedit = new string[(FormMain.matrix).GetLength(0), 9];
            matrixedit = ds.EditProduct(FormMain.matrix, datas,FormMain.idrow);

            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBoxVarCodeProduct_KES.Text = FormMain.matrix[FormMain.idrow,0];
            textBoxVarNameProduct_KES.Text = FormMain.matrix[FormMain.idrow, 1];
            textBoxVarCountProduct_KES.Text = FormMain.matrix[FormMain.idrow, 2];
            textBoxVarCostProduct_KES.Text = FormMain.matrix[FormMain.idrow, 3];
            textBoxDiscriptionProduct_KES.Text = FormMain.matrix[FormMain.idrow, 4];
            textBoxVarNumProvider_KES.Text = FormMain.matrix[FormMain.idrow, 5];
            textBoxVarFullNameProvider_KES.Text = FormMain.matrix[FormMain.idrow, 6];
            textBoxVarDateSully_KES.Text = FormMain.matrix[FormMain.idrow, 7];
            textBoxVarCountSally_KES.Text = FormMain.matrix[FormMain.idrow, 8];
        }
    }
}
