namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelUp_KES = new Panel();
            buttonSaveFile_KES = new Button();
            buttonDelete_KES = new Button();
            textBoxSearch_KES = new TextBox();
            buttonSearch_KES = new Button();
            buttonEdit_KES = new Button();
            buttonAdd_KES = new Button();
            buttonOpenFile_KES = new Button();
            panelLeft_KES = new Panel();
            splitterUpAndDownDataPanel_KES = new Splitter();
            dataGridViewData_KES = new DataGridView();
            codeProduct = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            countProduct = new DataGridViewTextBoxColumn();
            costProduct = new DataGridViewTextBoxColumn();
            discriptionsProduct = new DataGridViewTextBoxColumn();
            numberProvider = new DataGridViewTextBoxColumn();
            fullnameProvider = new DataGridViewTextBoxColumn();
            dateSupply = new DataGridViewTextBoxColumn();
            countSupply = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            groupBoxStatic_KES = new GroupBox();
            openFileDialogData_KES = new OpenFileDialog();
            saveFileDialogData_KES = new SaveFileDialog();
            buttonFilter_KES = new Button();
            panelUp_KES.SuspendLayout();
            panelLeft_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_KES).BeginInit();
            SuspendLayout();
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(buttonFilter_KES);
            panelUp_KES.Controls.Add(buttonSaveFile_KES);
            panelUp_KES.Controls.Add(buttonDelete_KES);
            panelUp_KES.Controls.Add(textBoxSearch_KES);
            panelUp_KES.Controls.Add(buttonSearch_KES);
            panelUp_KES.Controls.Add(buttonEdit_KES);
            panelUp_KES.Controls.Add(buttonAdd_KES);
            panelUp_KES.Controls.Add(buttonOpenFile_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Size = new Size(1217, 109);
            panelUp_KES.TabIndex = 0;
            // 
            // buttonSaveFile_KES
            // 
            buttonSaveFile_KES.Location = new Point(109, 3);
            buttonSaveFile_KES.Name = "buttonSaveFile_KES";
            buttonSaveFile_KES.Size = new Size(100, 29);
            buttonSaveFile_KES.TabIndex = 6;
            buttonSaveFile_KES.Text = "Сохранить";
            buttonSaveFile_KES.UseVisualStyleBackColor = true;
            buttonSaveFile_KES.Click += buttonSaveFile_KES_Click;
            // 
            // buttonDelete_KES
            // 
            buttonDelete_KES.Location = new Point(219, 56);
            buttonDelete_KES.Name = "buttonDelete_KES";
            buttonDelete_KES.Size = new Size(104, 29);
            buttonDelete_KES.TabIndex = 5;
            buttonDelete_KES.Text = "Удалить";
            buttonDelete_KES.UseVisualStyleBackColor = true;
            buttonDelete_KES.Click += buttonDelete_KES_Click;
            // 
            // textBoxSearch_KES
            // 
            textBoxSearch_KES.Location = new Point(906, 81);
            textBoxSearch_KES.Name = "textBoxSearch_KES";
            textBoxSearch_KES.Size = new Size(189, 23);
            textBoxSearch_KES.TabIndex = 4;
            // 
            // buttonSearch_KES
            // 
            buttonSearch_KES.Location = new Point(1101, 77);
            buttonSearch_KES.Name = "buttonSearch_KES";
            buttonSearch_KES.Size = new Size(104, 29);
            buttonSearch_KES.TabIndex = 3;
            buttonSearch_KES.Text = "Поиск";
            buttonSearch_KES.UseVisualStyleBackColor = true;
            buttonSearch_KES.Click += buttonSearch_KES_Click;
            // 
            // buttonEdit_KES
            // 
            buttonEdit_KES.Location = new Point(109, 56);
            buttonEdit_KES.Name = "buttonEdit_KES";
            buttonEdit_KES.Size = new Size(104, 29);
            buttonEdit_KES.TabIndex = 2;
            buttonEdit_KES.Text = "Редактировать";
            buttonEdit_KES.UseVisualStyleBackColor = true;
            buttonEdit_KES.Click += buttonEdit_KES_Click;
            // 
            // buttonAdd_KES
            // 
            buttonAdd_KES.Location = new Point(3, 56);
            buttonAdd_KES.Name = "buttonAdd_KES";
            buttonAdd_KES.Size = new Size(100, 29);
            buttonAdd_KES.TabIndex = 1;
            buttonAdd_KES.Text = "Добавить";
            buttonAdd_KES.UseVisualStyleBackColor = true;
            buttonAdd_KES.Click += buttonAdd_KES_Click;
            // 
            // buttonOpenFile_KES
            // 
            buttonOpenFile_KES.Location = new Point(3, 3);
            buttonOpenFile_KES.Name = "buttonOpenFile_KES";
            buttonOpenFile_KES.Size = new Size(100, 29);
            buttonOpenFile_KES.TabIndex = 0;
            buttonOpenFile_KES.Text = "Открыть";
            buttonOpenFile_KES.UseVisualStyleBackColor = true;
            buttonOpenFile_KES.Click += buttonOpenFile_KES_Click;
            // 
            // panelLeft_KES
            // 
            panelLeft_KES.Controls.Add(splitterUpAndDownDataPanel_KES);
            panelLeft_KES.Controls.Add(dataGridViewData_KES);
            panelLeft_KES.Dock = DockStyle.Left;
            panelLeft_KES.Location = new Point(0, 109);
            panelLeft_KES.Name = "panelLeft_KES";
            panelLeft_KES.Size = new Size(903, 228);
            panelLeft_KES.TabIndex = 1;
            // 
            // splitterUpAndDownDataPanel_KES
            // 
            splitterUpAndDownDataPanel_KES.Dock = DockStyle.Bottom;
            splitterUpAndDownDataPanel_KES.Location = new Point(0, 225);
            splitterUpAndDownDataPanel_KES.Name = "splitterUpAndDownDataPanel_KES";
            splitterUpAndDownDataPanel_KES.Size = new Size(903, 3);
            splitterUpAndDownDataPanel_KES.TabIndex = 2;
            splitterUpAndDownDataPanel_KES.TabStop = false;
            // 
            // dataGridViewData_KES
            // 
            dataGridViewData_KES.AllowUserToAddRows = false;
            dataGridViewData_KES.AllowUserToDeleteRows = false;
            dataGridViewData_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_KES.Columns.AddRange(new DataGridViewColumn[] { codeProduct, nameProduct, countProduct, costProduct, discriptionsProduct, numberProvider, fullnameProvider, dateSupply, countSupply, ColumnId });
            dataGridViewData_KES.Dock = DockStyle.Fill;
            dataGridViewData_KES.Location = new Point(0, 0);
            dataGridViewData_KES.Name = "dataGridViewData_KES";
            dataGridViewData_KES.ReadOnly = true;
            dataGridViewData_KES.RowHeadersVisible = false;
            dataGridViewData_KES.ScrollBars = ScrollBars.Vertical;
            dataGridViewData_KES.Size = new Size(903, 228);
            dataGridViewData_KES.TabIndex = 0;
            // 
            // codeProduct
            // 
            codeProduct.HeaderText = "Код товара";
            codeProduct.Name = "codeProduct";
            codeProduct.ReadOnly = true;
            // 
            // nameProduct
            // 
            nameProduct.HeaderText = "Название товара";
            nameProduct.Name = "nameProduct";
            nameProduct.ReadOnly = true;
            // 
            // countProduct
            // 
            countProduct.HeaderText = "Количество на складе";
            countProduct.Name = "countProduct";
            countProduct.ReadOnly = true;
            // 
            // costProduct
            // 
            costProduct.HeaderText = "Стоимость";
            costProduct.Name = "costProduct";
            costProduct.ReadOnly = true;
            // 
            // discriptionsProduct
            // 
            discriptionsProduct.HeaderText = "Примечания (описание)";
            discriptionsProduct.Name = "discriptionsProduct";
            discriptionsProduct.ReadOnly = true;
            // 
            // numberProvider
            // 
            numberProvider.HeaderText = "Номер поставщика";
            numberProvider.Name = "numberProvider";
            numberProvider.ReadOnly = true;
            // 
            // fullnameProvider
            // 
            fullnameProvider.HeaderText = "ФИО поставщика";
            fullnameProvider.Name = "fullnameProvider";
            fullnameProvider.ReadOnly = true;
            // 
            // dateSupply
            // 
            dateSupply.HeaderText = "Срок поставки";
            dateSupply.Name = "dateSupply";
            dateSupply.ReadOnly = true;
            // 
            // countSupply
            // 
            countSupply.HeaderText = "Количество товаров в поставке";
            countSupply.Name = "countSupply";
            countSupply.ReadOnly = true;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "IdColumn";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // groupBoxStatic_KES
            // 
            groupBoxStatic_KES.Dock = DockStyle.Bottom;
            groupBoxStatic_KES.Location = new Point(0, 337);
            groupBoxStatic_KES.Name = "groupBoxStatic_KES";
            groupBoxStatic_KES.Size = new Size(1217, 113);
            groupBoxStatic_KES.TabIndex = 1;
            groupBoxStatic_KES.TabStop = false;
            groupBoxStatic_KES.Text = "Статистика";
            // 
            // buttonFilter_KES
            // 
            buttonFilter_KES.Location = new Point(796, 77);
            buttonFilter_KES.Name = "buttonFilter_KES";
            buttonFilter_KES.Size = new Size(104, 29);
            buttonFilter_KES.TabIndex = 7;
            buttonFilter_KES.Text = "Фильтр";
            buttonFilter_KES.UseVisualStyleBackColor = true;
            buttonFilter_KES.Click += buttonFilter_KES_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 450);
            Controls.Add(panelLeft_KES);
            Controls.Add(groupBoxStatic_KES);
            Controls.Add(panelUp_KES);
            Name = "FormMain";
            Text = "Оптовая база";
            panelUp_KES.ResumeLayout(false);
            panelUp_KES.PerformLayout();
            panelLeft_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_KES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KES;
        private Button buttonOpenFile_KES;
        private Panel panelLeft_KES;
        private DataGridView dataGridViewData_KES;
        private DataGridViewTextBoxColumn codeProduct;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn countProduct;
        private DataGridViewTextBoxColumn costProduct;
        private DataGridViewTextBoxColumn discriptionsProduct;
        private DataGridViewTextBoxColumn numberProvider;
        private DataGridViewTextBoxColumn fullnameProvider;
        private DataGridViewTextBoxColumn dateSupply;
        private DataGridViewTextBoxColumn countSupply;
        private GroupBox groupBoxStatic_KES;
        private Splitter splitterUpAndDownDataPanel_KES;
        private OpenFileDialog openFileDialogData_KES;
        private Button buttonAdd_KES;
        private DataGridViewTextBoxColumn ColumnId;
        private Button buttonEdit_KES;
        private TextBox textBoxSearch_KES;
        private Button buttonSearch_KES;
        private Button buttonDelete_KES;
        private Button buttonSaveFile_KES;
        private SaveFileDialog saveFileDialogData_KES;
        private Button buttonFilter_KES;
    }
}
