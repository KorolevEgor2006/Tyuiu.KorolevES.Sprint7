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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp_KES = new Panel();
            buttonManual_KES = new Button();
            buttonInfo_KES = new Button();
            buttonRefreshFilter_KES = new Button();
            buttonFilter_KES = new Button();
            buttonSaveFile_KES = new Button();
            buttonDelete_KES = new Button();
            textBoxSearch_KES = new TextBox();
            buttonSearch_KES = new Button();
            buttonEdit_KES = new Button();
            buttonAdd_KES = new Button();
            buttonOpenFile_KES = new Button();
            panelBottom_KES = new Panel();
            groupBoxChartSetColumn_KES = new GroupBox();
            chartColumnSet_KES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxStatic_KES = new GroupBox();
            textBoxMeanValue_KES = new TextBox();
            labelMeanValue_KES = new Label();
            textBoxMinValue_KES = new TextBox();
            labelMinValue_KES = new Label();
            textBoxMaxValue_KES = new TextBox();
            labelMaxValue_KES = new Label();
            textBoxSum_KES = new TextBox();
            labelSum_KES = new Label();
            textBoxCountElements_KES = new TextBox();
            labelCountElements_KES = new Label();
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
            panelCenter_KES = new Panel();
            openFileDialogData_KES = new OpenFileDialog();
            saveFileDialogData_KES = new SaveFileDialog();
            toolTipButton_KES = new ToolTip(components);
            splitterCenterAndBottom_KES = new Splitter();
            groupBoxFilterAndSearch_KES = new GroupBox();
            groupBoxInfoProgram_KES = new GroupBox();
            groupBoxFile_KES = new GroupBox();
            groupBoxTable_KES = new GroupBox();
            panelUp_KES.SuspendLayout();
            panelBottom_KES.SuspendLayout();
            groupBoxChartSetColumn_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartColumnSet_KES).BeginInit();
            groupBoxStatic_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_KES).BeginInit();
            panelCenter_KES.SuspendLayout();
            groupBoxFilterAndSearch_KES.SuspendLayout();
            groupBoxInfoProgram_KES.SuspendLayout();
            groupBoxFile_KES.SuspendLayout();
            groupBoxTable_KES.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(groupBoxTable_KES);
            panelUp_KES.Controls.Add(groupBoxFile_KES);
            panelUp_KES.Controls.Add(groupBoxInfoProgram_KES);
            panelUp_KES.Controls.Add(groupBoxFilterAndSearch_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Padding = new Padding(10);
            panelUp_KES.Size = new Size(1244, 122);
            panelUp_KES.TabIndex = 0;
            // 
            // buttonManual_KES
            // 
            buttonManual_KES.BackgroundImage = (Image)resources.GetObject("buttonManual_KES.BackgroundImage");
            buttonManual_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonManual_KES.Location = new Point(31, 22);
            buttonManual_KES.Name = "buttonManual_KES";
            buttonManual_KES.Size = new Size(62, 61);
            buttonManual_KES.TabIndex = 10;
            toolTipButton_KES.SetToolTip(buttonManual_KES, "Руководство по использованию программы");
            buttonManual_KES.UseVisualStyleBackColor = true;
            buttonManual_KES.Click += buttonManual_KES_Click;
            buttonManual_KES.MouseEnter += buttonManual_KES_MouseEnter;
            // 
            // buttonInfo_KES
            // 
            buttonInfo_KES.BackgroundImage = (Image)resources.GetObject("buttonInfo_KES.BackgroundImage");
            buttonInfo_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo_KES.Location = new Point(118, 22);
            buttonInfo_KES.Name = "buttonInfo_KES";
            buttonInfo_KES.Size = new Size(62, 61);
            buttonInfo_KES.TabIndex = 9;
            toolTipButton_KES.SetToolTip(buttonInfo_KES, "Информация о программе.");
            buttonInfo_KES.UseVisualStyleBackColor = true;
            buttonInfo_KES.Click += buttonInfo_KES_Click;
            buttonInfo_KES.MouseEnter += buttonInfo_KES_MouseEnter;
            // 
            // buttonRefreshFilter_KES
            // 
            buttonRefreshFilter_KES.Location = new Point(6, 17);
            buttonRefreshFilter_KES.Name = "buttonRefreshFilter_KES";
            buttonRefreshFilter_KES.Size = new Size(189, 29);
            buttonRefreshFilter_KES.TabIndex = 8;
            buttonRefreshFilter_KES.Text = "Сбросить все фильтры";
            buttonRefreshFilter_KES.UseVisualStyleBackColor = true;
            buttonRefreshFilter_KES.Click += buttonRefreshFilter_KES_Click;
            // 
            // buttonFilter_KES
            // 
            buttonFilter_KES.BackgroundImage = Properties.Resources.table_sort;
            buttonFilter_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFilter_KES.Location = new Point(201, 17);
            buttonFilter_KES.Name = "buttonFilter_KES";
            buttonFilter_KES.Size = new Size(36, 29);
            buttonFilter_KES.TabIndex = 7;
            toolTipButton_KES.SetToolTip(buttonFilter_KES, "Применяет фильтрацию по столбцу с активной ячейкой");
            buttonFilter_KES.UseVisualStyleBackColor = true;
            buttonFilter_KES.Click += buttonFilter_KES_Click;
            buttonFilter_KES.MouseEnter += buttonFilter_KES_MouseEnter;
            // 
            // buttonSaveFile_KES
            // 
            buttonSaveFile_KES.BackgroundImage = Properties.Resources.disk;
            buttonSaveFile_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveFile_KES.Location = new Point(92, 28);
            buttonSaveFile_KES.Name = "buttonSaveFile_KES";
            buttonSaveFile_KES.Size = new Size(54, 51);
            buttonSaveFile_KES.TabIndex = 6;
            toolTipButton_KES.SetToolTip(buttonSaveFile_KES, "Сохранить таблицу в файле CSV.");
            buttonSaveFile_KES.UseVisualStyleBackColor = true;
            buttonSaveFile_KES.Click += buttonSaveFile_KES_Click;
            buttonSaveFile_KES.MouseEnter += buttonSaveFile_KES_MouseEnter;
            // 
            // buttonDelete_KES
            // 
            buttonDelete_KES.BackgroundImage = Properties.Resources.table_delete;
            buttonDelete_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete_KES.Location = new Point(129, 27);
            buttonDelete_KES.Name = "buttonDelete_KES";
            buttonDelete_KES.Size = new Size(58, 51);
            buttonDelete_KES.TabIndex = 5;
            toolTipButton_KES.SetToolTip(buttonDelete_KES, "Удалить строку с активной ячейкой");
            buttonDelete_KES.UseVisualStyleBackColor = true;
            buttonDelete_KES.Click += buttonDelete_KES_Click;
            buttonDelete_KES.MouseEnter += buttonDelete_KES_MouseEnter;
            // 
            // textBoxSearch_KES
            // 
            textBoxSearch_KES.Location = new Point(6, 57);
            textBoxSearch_KES.Name = "textBoxSearch_KES";
            textBoxSearch_KES.Size = new Size(189, 23);
            textBoxSearch_KES.TabIndex = 4;
            // 
            // buttonSearch_KES
            // 
            buttonSearch_KES.BackgroundImage = Properties.Resources.find;
            buttonSearch_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch_KES.Location = new Point(201, 57);
            buttonSearch_KES.Name = "buttonSearch_KES";
            buttonSearch_KES.Size = new Size(36, 29);
            buttonSearch_KES.TabIndex = 3;
            toolTipButton_KES.SetToolTip(buttonSearch_KES, "Выполняет поиск значения в таблице.");
            buttonSearch_KES.UseVisualStyleBackColor = true;
            buttonSearch_KES.Click += buttonSearch_KES_Click;
            buttonSearch_KES.MouseEnter += buttonSearch_KES_MouseEnter;
            // 
            // buttonEdit_KES
            // 
            buttonEdit_KES.BackgroundImage = Properties.Resources.table_edit;
            buttonEdit_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit_KES.Location = new Point(67, 27);
            buttonEdit_KES.Name = "buttonEdit_KES";
            buttonEdit_KES.Size = new Size(56, 51);
            buttonEdit_KES.TabIndex = 2;
            toolTipButton_KES.SetToolTip(buttonEdit_KES, "Изменить строку с активной ячейкой.");
            buttonEdit_KES.UseVisualStyleBackColor = true;
            buttonEdit_KES.Click += buttonEdit_KES_Click;
            buttonEdit_KES.MouseEnter += buttonEdit_KES_MouseEnter;
            // 
            // buttonAdd_KES
            // 
            buttonAdd_KES.BackgroundImage = Properties.Resources.table_add;
            buttonAdd_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd_KES.Location = new Point(6, 27);
            buttonAdd_KES.Name = "buttonAdd_KES";
            buttonAdd_KES.Size = new Size(55, 51);
            buttonAdd_KES.TabIndex = 1;
            toolTipButton_KES.SetToolTip(buttonAdd_KES, "Добавить новый элемент в таблицу.");
            buttonAdd_KES.UseVisualStyleBackColor = true;
            buttonAdd_KES.Click += buttonAdd_KES_Click;
            buttonAdd_KES.MouseEnter += buttonAdd_KES_MouseEnter;
            // 
            // buttonOpenFile_KES
            // 
            buttonOpenFile_KES.BackgroundImage = Properties.Resources.folder;
            buttonOpenFile_KES.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_KES.Location = new Point(17, 27);
            buttonOpenFile_KES.Name = "buttonOpenFile_KES";
            buttonOpenFile_KES.Size = new Size(54, 52);
            buttonOpenFile_KES.TabIndex = 0;
            toolTipButton_KES.SetToolTip(buttonOpenFile_KES, "Открыть таблицу из файла CSV.");
            buttonOpenFile_KES.UseVisualStyleBackColor = true;
            buttonOpenFile_KES.Click += buttonOpenFile_KES_Click;
            buttonOpenFile_KES.MouseEnter += buttonOpenFile_KES_MouseEnter;
            // 
            // panelBottom_KES
            // 
            panelBottom_KES.Controls.Add(groupBoxChartSetColumn_KES);
            panelBottom_KES.Controls.Add(groupBoxStatic_KES);
            panelBottom_KES.Dock = DockStyle.Bottom;
            panelBottom_KES.Location = new Point(0, 365);
            panelBottom_KES.Name = "panelBottom_KES";
            panelBottom_KES.Padding = new Padding(10);
            panelBottom_KES.Size = new Size(1244, 286);
            panelBottom_KES.TabIndex = 1;
            // 
            // groupBoxChartSetColumn_KES
            // 
            groupBoxChartSetColumn_KES.Controls.Add(chartColumnSet_KES);
            groupBoxChartSetColumn_KES.Dock = DockStyle.Fill;
            groupBoxChartSetColumn_KES.Location = new Point(408, 10);
            groupBoxChartSetColumn_KES.Name = "groupBoxChartSetColumn_KES";
            groupBoxChartSetColumn_KES.Padding = new Padding(8);
            groupBoxChartSetColumn_KES.Size = new Size(826, 266);
            groupBoxChartSetColumn_KES.TabIndex = 11;
            groupBoxChartSetColumn_KES.TabStop = false;
            groupBoxChartSetColumn_KES.Text = "График выбранного столбца";
            // 
            // chartColumnSet_KES
            // 
            chartArea2.Name = "ChartArea1";
            chartColumnSet_KES.ChartAreas.Add(chartArea2);
            chartColumnSet_KES.Dock = DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartColumnSet_KES.Legends.Add(legend2);
            chartColumnSet_KES.Location = new Point(8, 24);
            chartColumnSet_KES.Name = "chartColumnSet_KES";
            chartColumnSet_KES.Padding = new Padding(5);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartColumnSet_KES.Series.Add(series2);
            chartColumnSet_KES.Size = new Size(810, 234);
            chartColumnSet_KES.TabIndex = 10;
            // 
            // groupBoxStatic_KES
            // 
            groupBoxStatic_KES.Controls.Add(textBoxMeanValue_KES);
            groupBoxStatic_KES.Controls.Add(labelMeanValue_KES);
            groupBoxStatic_KES.Controls.Add(textBoxMinValue_KES);
            groupBoxStatic_KES.Controls.Add(labelMinValue_KES);
            groupBoxStatic_KES.Controls.Add(textBoxMaxValue_KES);
            groupBoxStatic_KES.Controls.Add(labelMaxValue_KES);
            groupBoxStatic_KES.Controls.Add(textBoxSum_KES);
            groupBoxStatic_KES.Controls.Add(labelSum_KES);
            groupBoxStatic_KES.Controls.Add(textBoxCountElements_KES);
            groupBoxStatic_KES.Controls.Add(labelCountElements_KES);
            groupBoxStatic_KES.Dock = DockStyle.Left;
            groupBoxStatic_KES.Location = new Point(10, 10);
            groupBoxStatic_KES.Name = "groupBoxStatic_KES";
            groupBoxStatic_KES.Size = new Size(398, 266);
            groupBoxStatic_KES.TabIndex = 1;
            groupBoxStatic_KES.TabStop = false;
            groupBoxStatic_KES.Text = "Статистика";
            // 
            // textBoxMeanValue_KES
            // 
            textBoxMeanValue_KES.Location = new Point(160, 114);
            textBoxMeanValue_KES.Name = "textBoxMeanValue_KES";
            textBoxMeanValue_KES.ReadOnly = true;
            textBoxMeanValue_KES.Size = new Size(100, 23);
            textBoxMeanValue_KES.TabIndex = 11;
            textBoxMeanValue_KES.TabStop = false;
            // 
            // labelMeanValue_KES
            // 
            labelMeanValue_KES.AutoSize = true;
            labelMeanValue_KES.Location = new Point(6, 114);
            labelMeanValue_KES.Name = "labelMeanValue_KES";
            labelMeanValue_KES.Size = new Size(110, 15);
            labelMeanValue_KES.TabIndex = 10;
            labelMeanValue_KES.Text = "Среднее значение:";
            // 
            // textBoxMinValue_KES
            // 
            textBoxMinValue_KES.Location = new Point(160, 177);
            textBoxMinValue_KES.Name = "textBoxMinValue_KES";
            textBoxMinValue_KES.ReadOnly = true;
            textBoxMinValue_KES.Size = new Size(100, 23);
            textBoxMinValue_KES.TabIndex = 9;
            textBoxMinValue_KES.TabStop = false;
            // 
            // labelMinValue_KES
            // 
            labelMinValue_KES.AutoSize = true;
            labelMinValue_KES.Location = new Point(6, 185);
            labelMinValue_KES.Name = "labelMinValue_KES";
            labelMinValue_KES.Size = new Size(144, 15);
            labelMinValue_KES.TabIndex = 8;
            labelMinValue_KES.Text = "Минимальное значение:";
            // 
            // textBoxMaxValue_KES
            // 
            textBoxMaxValue_KES.Location = new Point(160, 148);
            textBoxMaxValue_KES.Name = "textBoxMaxValue_KES";
            textBoxMaxValue_KES.ReadOnly = true;
            textBoxMaxValue_KES.Size = new Size(100, 23);
            textBoxMaxValue_KES.TabIndex = 7;
            textBoxMaxValue_KES.TabStop = false;
            // 
            // labelMaxValue_KES
            // 
            labelMaxValue_KES.AutoSize = true;
            labelMaxValue_KES.Location = new Point(4, 151);
            labelMaxValue_KES.Name = "labelMaxValue_KES";
            labelMaxValue_KES.Size = new Size(148, 15);
            labelMaxValue_KES.TabIndex = 6;
            labelMaxValue_KES.Text = "Максимальное значение:";
            // 
            // textBoxSum_KES
            // 
            textBoxSum_KES.Location = new Point(160, 80);
            textBoxSum_KES.Name = "textBoxSum_KES";
            textBoxSum_KES.ReadOnly = true;
            textBoxSum_KES.Size = new Size(100, 23);
            textBoxSum_KES.TabIndex = 3;
            textBoxSum_KES.TabStop = false;
            // 
            // labelSum_KES
            // 
            labelSum_KES.AutoSize = true;
            labelSum_KES.Location = new Point(6, 70);
            labelSum_KES.Name = "labelSum_KES";
            labelSum_KES.Size = new Size(107, 30);
            labelSum_KES.TabIndex = 2;
            labelSum_KES.Text = "Сумма элементов\r\nв столбце:";
            // 
            // textBoxCountElements_KES
            // 
            textBoxCountElements_KES.Location = new Point(160, 48);
            textBoxCountElements_KES.Name = "textBoxCountElements_KES";
            textBoxCountElements_KES.ReadOnly = true;
            textBoxCountElements_KES.Size = new Size(100, 23);
            textBoxCountElements_KES.TabIndex = 1;
            textBoxCountElements_KES.TabStop = false;
            // 
            // labelCountElements_KES
            // 
            labelCountElements_KES.AutoSize = true;
            labelCountElements_KES.Location = new Point(6, 48);
            labelCountElements_KES.Name = "labelCountElements_KES";
            labelCountElements_KES.Size = new Size(137, 15);
            labelCountElements_KES.TabIndex = 0;
            labelCountElements_KES.Text = "Количество элементов:";
            // 
            // dataGridViewData_KES
            // 
            dataGridViewData_KES.AllowUserToAddRows = false;
            dataGridViewData_KES.AllowUserToDeleteRows = false;
            dataGridViewData_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_KES.Columns.AddRange(new DataGridViewColumn[] { codeProduct, nameProduct, countProduct, costProduct, discriptionsProduct, numberProvider, fullnameProvider, dateSupply, countSupply, ColumnId });
            dataGridViewData_KES.Dock = DockStyle.Fill;
            dataGridViewData_KES.Location = new Point(10, 10);
            dataGridViewData_KES.Name = "dataGridViewData_KES";
            dataGridViewData_KES.ReadOnly = true;
            dataGridViewData_KES.RowHeadersVisible = false;
            dataGridViewData_KES.Size = new Size(1224, 223);
            dataGridViewData_KES.TabIndex = 0;
            dataGridViewData_KES.CellClick += dataGridViewData_KES_CellClick;
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
            // panelCenter_KES
            // 
            panelCenter_KES.Controls.Add(dataGridViewData_KES);
            panelCenter_KES.Dock = DockStyle.Fill;
            panelCenter_KES.Location = new Point(0, 122);
            panelCenter_KES.Name = "panelCenter_KES";
            panelCenter_KES.Padding = new Padding(10);
            panelCenter_KES.Size = new Size(1244, 243);
            panelCenter_KES.TabIndex = 2;
            // 
            // toolTipButton_KES
            // 
            toolTipButton_KES.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_KES.ToolTipTitle = "Подсказка";
            // 
            // splitterCenterAndBottom_KES
            // 
            splitterCenterAndBottom_KES.Dock = DockStyle.Bottom;
            splitterCenterAndBottom_KES.Location = new Point(0, 362);
            splitterCenterAndBottom_KES.Name = "splitterCenterAndBottom_KES";
            splitterCenterAndBottom_KES.Size = new Size(1244, 3);
            splitterCenterAndBottom_KES.TabIndex = 3;
            splitterCenterAndBottom_KES.TabStop = false;
            // 
            // groupBoxFilterAndSearch_KES
            // 
            groupBoxFilterAndSearch_KES.Controls.Add(buttonRefreshFilter_KES);
            groupBoxFilterAndSearch_KES.Controls.Add(buttonFilter_KES);
            groupBoxFilterAndSearch_KES.Controls.Add(buttonSearch_KES);
            groupBoxFilterAndSearch_KES.Controls.Add(textBoxSearch_KES);
            groupBoxFilterAndSearch_KES.Dock = DockStyle.Right;
            groupBoxFilterAndSearch_KES.Location = new Point(988, 10);
            groupBoxFilterAndSearch_KES.Name = "groupBoxFilterAndSearch_KES";
            groupBoxFilterAndSearch_KES.Size = new Size(246, 102);
            groupBoxFilterAndSearch_KES.TabIndex = 11;
            groupBoxFilterAndSearch_KES.TabStop = false;
            groupBoxFilterAndSearch_KES.Text = "Поиск и фильтрация.";
            // 
            // groupBoxInfoProgram_KES
            // 
            groupBoxInfoProgram_KES.Controls.Add(buttonManual_KES);
            groupBoxInfoProgram_KES.Controls.Add(buttonInfo_KES);
            groupBoxInfoProgram_KES.Dock = DockStyle.Right;
            groupBoxInfoProgram_KES.Location = new Point(791, 10);
            groupBoxInfoProgram_KES.Name = "groupBoxInfoProgram_KES";
            groupBoxInfoProgram_KES.Size = new Size(197, 102);
            groupBoxInfoProgram_KES.TabIndex = 12;
            groupBoxInfoProgram_KES.TabStop = false;
            groupBoxInfoProgram_KES.Text = "Информация о программе";
            // 
            // groupBoxFile_KES
            // 
            groupBoxFile_KES.Controls.Add(buttonOpenFile_KES);
            groupBoxFile_KES.Controls.Add(buttonSaveFile_KES);
            groupBoxFile_KES.Dock = DockStyle.Left;
            groupBoxFile_KES.Location = new Point(10, 10);
            groupBoxFile_KES.Name = "groupBoxFile_KES";
            groupBoxFile_KES.Size = new Size(160, 102);
            groupBoxFile_KES.TabIndex = 13;
            groupBoxFile_KES.TabStop = false;
            groupBoxFile_KES.Text = "Файл";
            // 
            // groupBoxTable_KES
            // 
            groupBoxTable_KES.Controls.Add(buttonAdd_KES);
            groupBoxTable_KES.Controls.Add(buttonEdit_KES);
            groupBoxTable_KES.Controls.Add(buttonDelete_KES);
            groupBoxTable_KES.Dock = DockStyle.Left;
            groupBoxTable_KES.Location = new Point(170, 10);
            groupBoxTable_KES.Name = "groupBoxTable_KES";
            groupBoxTable_KES.Size = new Size(200, 102);
            groupBoxTable_KES.TabIndex = 14;
            groupBoxTable_KES.TabStop = false;
            groupBoxTable_KES.Text = "Таблица";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 651);
            Controls.Add(splitterCenterAndBottom_KES);
            Controls.Add(panelCenter_KES);
            Controls.Add(panelBottom_KES);
            Controls.Add(panelUp_KES);
            MinimumSize = new Size(1260, 490);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база";
            Load += FormMain_Load;
            panelUp_KES.ResumeLayout(false);
            panelBottom_KES.ResumeLayout(false);
            groupBoxChartSetColumn_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartColumnSet_KES).EndInit();
            groupBoxStatic_KES.ResumeLayout(false);
            groupBoxStatic_KES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_KES).EndInit();
            panelCenter_KES.ResumeLayout(false);
            groupBoxFilterAndSearch_KES.ResumeLayout(false);
            groupBoxFilterAndSearch_KES.PerformLayout();
            groupBoxInfoProgram_KES.ResumeLayout(false);
            groupBoxFile_KES.ResumeLayout(false);
            groupBoxTable_KES.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KES;
        private Button buttonOpenFile_KES;
        private Panel panelBottom_KES;
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
        private Button buttonRefreshFilter_KES;
        private TextBox textBoxCountElements_KES;
        private Label labelCountElements_KES;
        private TextBox textBoxSum_KES;
        private Label labelSum_KES;
        private TextBox textBoxMinValue_KES;
        private Label labelMinValue_KES;
        private TextBox textBoxMaxValue_KES;
        private Label labelMaxValue_KES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumnSet_KES;
        private Panel panelCenter_KES;
        private GroupBox groupBoxChartSetColumn_KES;
        private TextBox textBoxMeanValue_KES;
        private Label labelMeanValue_KES;
        private ToolTip toolTipButton_KES;
        private Splitter splitterCenterAndBottom_KES;
        private Button buttonInfo_KES;
        private Button buttonManual_KES;
        private GroupBox groupBoxFilterAndSearch_KES;
        private GroupBox groupBoxTable_KES;
        private GroupBox groupBoxFile_KES;
        private GroupBox groupBoxInfoProgram_KES;
    }
}
