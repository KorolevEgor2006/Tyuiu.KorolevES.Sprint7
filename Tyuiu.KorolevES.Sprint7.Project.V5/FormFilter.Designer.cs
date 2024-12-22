namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    partial class FormFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewFilter_KES = new DataGridView();
            Element = new DataGridViewTextBoxColumn();
            CheckElement = new DataGridViewCheckBoxColumn();
            buttonSetAll_KES = new Button();
            buttonNoSetAll_KES = new Button();
            buttonSetFilter_KES = new Button();
            buttonClose_KES = new Button();
            textBoxSearch_KES = new TextBox();
            buttonSearch_KES = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilter_KES).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFilter_KES
            // 
            dataGridViewFilter_KES.AllowUserToAddRows = false;
            dataGridViewFilter_KES.AllowUserToDeleteRows = false;
            dataGridViewFilter_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilter_KES.Columns.AddRange(new DataGridViewColumn[] { Element, CheckElement });
            dataGridViewFilter_KES.Location = new Point(12, 43);
            dataGridViewFilter_KES.Name = "dataGridViewFilter_KES";
            dataGridViewFilter_KES.RowHeadersVisible = false;
            dataGridViewFilter_KES.Size = new Size(203, 352);
            dataGridViewFilter_KES.TabIndex = 0;
            // 
            // Element
            // 
            Element.HeaderText = "Фильтр значений";
            Element.Name = "Element";
            Element.ReadOnly = true;
            // 
            // CheckElement
            // 
            CheckElement.HeaderText = "Установить";
            CheckElement.Name = "CheckElement";
            // 
            // buttonSetAll_KES
            // 
            buttonSetAll_KES.Location = new Point(123, 401);
            buttonSetAll_KES.Name = "buttonSetAll_KES";
            buttonSetAll_KES.Size = new Size(92, 23);
            buttonSetAll_KES.TabIndex = 1;
            buttonSetAll_KES.Text = "Выбрать все";
            buttonSetAll_KES.UseVisualStyleBackColor = true;
            buttonSetAll_KES.Click += buttonSetAll_KES_Click;
            // 
            // buttonNoSetAll_KES
            // 
            buttonNoSetAll_KES.Location = new Point(12, 401);
            buttonNoSetAll_KES.Name = "buttonNoSetAll_KES";
            buttonNoSetAll_KES.Size = new Size(92, 23);
            buttonNoSetAll_KES.TabIndex = 2;
            buttonNoSetAll_KES.Text = "Снять все";
            buttonNoSetAll_KES.UseVisualStyleBackColor = true;
            buttonNoSetAll_KES.Click += buttonNoSetAll_KES_Click;
            // 
            // buttonSetFilter_KES
            // 
            buttonSetFilter_KES.Location = new Point(123, 439);
            buttonSetFilter_KES.Name = "buttonSetFilter_KES";
            buttonSetFilter_KES.Size = new Size(92, 23);
            buttonSetFilter_KES.TabIndex = 3;
            buttonSetFilter_KES.Text = "Установить";
            buttonSetFilter_KES.UseVisualStyleBackColor = true;
            buttonSetFilter_KES.Click += buttonSetFilter_KES_Click;
            // 
            // buttonClose_KES
            // 
            buttonClose_KES.Location = new Point(12, 439);
            buttonClose_KES.Name = "buttonClose_KES";
            buttonClose_KES.Size = new Size(92, 23);
            buttonClose_KES.TabIndex = 4;
            buttonClose_KES.Text = "Отмена";
            buttonClose_KES.UseVisualStyleBackColor = true;
            buttonClose_KES.Click += buttonClose_KES_Click;
            // 
            // textBoxSearch_KES
            // 
            textBoxSearch_KES.Location = new Point(12, 14);
            textBoxSearch_KES.Name = "textBoxSearch_KES";
            textBoxSearch_KES.Size = new Size(135, 23);
            textBoxSearch_KES.TabIndex = 5;
            // 
            // buttonSearch_KES
            // 
            buttonSearch_KES.Location = new Point(153, 14);
            buttonSearch_KES.Name = "buttonSearch_KES";
            buttonSearch_KES.Size = new Size(62, 23);
            buttonSearch_KES.TabIndex = 6;
            buttonSearch_KES.Text = "Поиск";
            buttonSearch_KES.UseVisualStyleBackColor = true;
            buttonSearch_KES.Click += buttonSearch_KES_Click;
            // 
            // FormFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 467);
            Controls.Add(buttonSearch_KES);
            Controls.Add(textBoxSearch_KES);
            Controls.Add(buttonClose_KES);
            Controls.Add(buttonSetFilter_KES);
            Controls.Add(buttonNoSetAll_KES);
            Controls.Add(buttonSetAll_KES);
            Controls.Add(dataGridViewFilter_KES);
            Name = "FormFilter";
            Text = "Настроить фильтр";
            Load += FormFilter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilter_KES).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFilter_KES;
        private DataGridViewTextBoxColumn Element;
        private DataGridViewCheckBoxColumn CheckElement;
        private Button buttonSetAll_KES;
        private Button buttonNoSetAll_KES;
        private Button buttonSetFilter_KES;
        private Button buttonClose_KES;
        private TextBox textBoxSearch_KES;
        private Button buttonSearch_KES;
    }
}