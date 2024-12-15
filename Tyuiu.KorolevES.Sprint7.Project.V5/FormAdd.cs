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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        private void buttonCloseAdd_KES_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string[,] matrixedit;
        private void buttonAddProduct_KES_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string[] datas = new string[9];
            datas[0] = textBoxVarCodeProduct_KES.Text;
            datas[1] = textBoxVarNameProduct_KES.Text;
            datas[2] = textBoxVarCountProduct_KES.Text;
            datas[3] = textBoxVarCostProduct_KES.Text;
            datas[4] = textBoxDiscriptionProduct_KES.Text;
            datas[5] = textBoxVarNumProvider_KES.Text;
            datas[6] = textBoxVarFullNameProvider_KES.Text;
            datas[7] = textBoxVarDateSully_KES.Text;
            datas[8] = textBoxVarCountSally_KES.Text;
            matrixedit = new string[(ds.AddProduct(FormMain.matrix, datas)).GetLength(0),9];
            matrixedit = ds.AddProduct(FormMain.matrix, datas);
            
            this.Close();
        }
    }
}
