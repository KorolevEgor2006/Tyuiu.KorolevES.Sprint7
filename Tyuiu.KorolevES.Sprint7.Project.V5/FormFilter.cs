using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorolevES.Sprint7.Project.V5.Lib;

namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string[] column;
        string[] filter;
        string[] columnset;
        public string[] result;
        string search="";
        private void FormFilter_Load(object sender, EventArgs e)
        {
            if (FormMain.idrow == 0)
            {
                column = new string[FormMain.column0.Length];
                column = FormMain.column0;
            }
            if (FormMain.idrow == 1)
            {
                column = new string[FormMain.column1.Length];
                column = FormMain.column1;
            }
            if (FormMain.idrow == 2)
            {
                column = new string[FormMain.column2.Length];
                column = FormMain.column2;
            }
            if (FormMain.idrow == 3)
            {
                column = new string[FormMain.column3.Length];
                column = FormMain.column3;
            }
            if (FormMain.idrow == 4)
            {
                column = new string[FormMain.column4.Length];
                column = FormMain.column4;
            }
            if (FormMain.idrow == 5)
            {
                column = new string[FormMain.column5.Length];
                column = FormMain.column5;
            }
            if (FormMain.idrow == 6)
            {
                column = new string[FormMain.column6.Length];
                column = FormMain.column6;
            }
            if (FormMain.idrow == 7)
            {
                column = new string[FormMain.column7.Length];
                column = FormMain.column7;
            }
            if (FormMain.idrow == 8)
            {
                column = new string[FormMain.column8.Length];
                column = FormMain.column8;
            }
            if (column == null)
            {
                column = new string[1] { "1" };
            }
            filter = new string[ds.MassFilterGive(FormMain.matrix, FormMain.idrow).Length];
            filter = ds.MassFilterGive(FormMain.matrix, FormMain.idrow);
            for (int i = 0; i < filter.Length; i++)
            {
                dataGridViewFilter_KES.Rows.Add(filter[i]);
                dataGridViewFilter_KES.Rows[i].Cells[0].Value = filter[i];
                if (column.Contains(filter[i])) dataGridViewFilter_KES.Rows[i].Cells[1].Value = false;
                else dataGridViewFilter_KES.Rows[i].Cells[1].Value = true;
            }
            
        }

        private void buttonSetAll_KES_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filter.Length; i++)
            {
                dataGridViewFilter_KES.Rows[i].Cells[1].Value = true;
            }
        }

        private void buttonNoSetAll_KES_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filter.Length; i++)
            {
                dataGridViewFilter_KES.Rows[i].Cells[1].Value = false;
            }
        }

        private void buttonClose_KES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSetFilter_KES_Click(object sender, EventArgs e)
        {
            try
            {
                int ii = 0;
                columnset = new string[filter.Length];
                for (int i = 0; i < filter.Length; i++)
                {
                    string booledValueFilter = dataGridViewFilter_KES.Rows[i].Cells[1].Value.ToString();
                    if (booledValueFilter != "True")
                    {
                        columnset[ii] = Convert.ToString(dataGridViewFilter_KES.Rows[i].Cells[0].Value);
                        ii++;
                    }
                }
                result = new string[ii];
                for (int i = 0; i < ii; i++)
                {
                    result[i] = columnset[i];
                }
            }
            catch { }
            this.Close();
        }

        private void buttonSearch_KES_Click(object sender, EventArgs e)
        {
            search = textBoxSearch_KES.Text;
            
            
            for (int i = 0; i < filter.Length; i++)
            {
                string[] values = search.Split(" ");
                foreach (string value in values)
                {
                    if (((dataGridViewFilter_KES.Rows[i].Cells[0].Value.ToString()).Contains(value))) dataGridViewFilter_KES.Rows[i].Visible = true;
                    else dataGridViewFilter_KES.Rows[i].Visible = false;
                }
            }
            
        }
    }
}
