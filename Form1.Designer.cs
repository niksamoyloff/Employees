﻿namespace Employees
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.ButtonShowDateFilter = new System.Windows.Forms.Button();
            this.ButtonResetFilter = new System.Windows.Forms.Button();
            this.ButtonExportToExcel = new System.Windows.Forms.Button();
            this.dateTimePickerFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNameSIZFilter = new System.Windows.Forms.TextBox();
            this.dateTimePickerFilterStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNameWorkerFilter = new System.Windows.Forms.TextBox();
            this.DataGridViewFilter = new System.Windows.Forms.DataGridView();
            this.tabPageAreas = new System.Windows.Forms.TabPage();
            this.DataGridViewArea = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteArea = new System.Windows.Forms.Button();
            this.ButtonChangeArea = new System.Windows.Forms.Button();
            this.ButtonAddArea = new System.Windows.Forms.Button();
            this.textBoxNameArea = new System.Windows.Forms.TextBox();
            this.labelNewArea = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.ButtonDeletePosition = new System.Windows.Forms.Button();
            this.ButtonChangePosition = new System.Windows.Forms.Button();
            this.ButtonAddPosition = new System.Windows.Forms.Button();
            this.comboBoxNameArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamePosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxWorkerArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxWorkerGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteWorker = new System.Windows.Forms.Button();
            this.ButtonChangeWorker = new System.Windows.Forms.Button();
            this.ButtonAddWorker = new System.Windows.Forms.Button();
            this.comboBoxWorkerPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameWorker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxTypeOfSIZ = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxInventNumbSIZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataGridViewSIZ = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteSIZ = new System.Windows.Forms.Button();
            this.ButtonChangeSIZ = new System.Windows.Forms.Button();
            this.ButtonAddSIZ = new System.Windows.Forms.Button();
            this.textBoxNameSIZ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxIssueNameWorker = new System.Windows.Forms.TextBox();
            this.comboBoxInventNumbSIZ = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePickerIssueWorkability = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxIssueSIZ = new System.Windows.Forms.ComboBox();
            this.textBoxNotationOfIssue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerIssueSIZ = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridViewIssue = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteIssue = new System.Windows.Forms.Button();
            this.ButtonChangeIssue = new System.Windows.Forms.Button();
            this.ButtonAddIssue = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.databaseOfEmployeesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOfEmployeesDataSet = new Employees.DatabaseOfEmployeesDataSet();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new Employees.DatabaseOfEmployeesDataSetTableAdapters.AreasTableAdapter();
            this.positionsTableAdapter = new Employees.DatabaseOfEmployeesDataSetTableAdapters.PositionsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFilter)).BeginInit();
            this.tabPageAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPositions)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWorkers)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSIZ)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFilter);
            this.tabControl1.Controls.Add(this.tabPageAreas);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1231, 674);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.Controls.Add(this.ButtonShowDateFilter);
            this.tabPageFilter.Controls.Add(this.ButtonResetFilter);
            this.tabPageFilter.Controls.Add(this.ButtonExportToExcel);
            this.tabPageFilter.Controls.Add(this.dateTimePickerFilterEnd);
            this.tabPageFilter.Controls.Add(this.label17);
            this.tabPageFilter.Controls.Add(this.textBoxNameSIZFilter);
            this.tabPageFilter.Controls.Add(this.dateTimePickerFilterStart);
            this.tabPageFilter.Controls.Add(this.label14);
            this.tabPageFilter.Controls.Add(this.label15);
            this.tabPageFilter.Controls.Add(this.label16);
            this.tabPageFilter.Controls.Add(this.textBoxNameWorkerFilter);
            this.tabPageFilter.Controls.Add(this.DataGridViewFilter);
            this.tabPageFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageFilter.Location = new System.Drawing.Point(4, 25);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilter.Size = new System.Drawing.Size(1223, 645);
            this.tabPageFilter.TabIndex = 0;
            this.tabPageFilter.Text = "Фильтр";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // ButtonShowDateFilter
            // 
            this.ButtonShowDateFilter.Location = new System.Drawing.Point(20, 61);
            this.ButtonShowDateFilter.Name = "ButtonShowDateFilter";
            this.ButtonShowDateFilter.Size = new System.Drawing.Size(82, 35);
            this.ButtonShowDateFilter.TabIndex = 61;
            this.ButtonShowDateFilter.Text = "Показать";
            this.ButtonShowDateFilter.UseVisualStyleBackColor = true;
            this.ButtonShowDateFilter.Click += new System.EventHandler(this.ButtonFilterShowDate_Click);
            // 
            // ButtonResetFilter
            // 
            this.ButtonResetFilter.Location = new System.Drawing.Point(958, 27);
            this.ButtonResetFilter.Name = "ButtonResetFilter";
            this.ButtonResetFilter.Size = new System.Drawing.Size(189, 74);
            this.ButtonResetFilter.TabIndex = 60;
            this.ButtonResetFilter.Text = "Сбросить фильтр";
            this.ButtonResetFilter.UseVisualStyleBackColor = true;
            this.ButtonResetFilter.Click += new System.EventHandler(this.ButtonResetFilter_Click);
            // 
            // ButtonExportToExcel
            // 
            this.ButtonExportToExcel.Location = new System.Drawing.Point(644, 64);
            this.ButtonExportToExcel.Name = "ButtonExportToExcel";
            this.ButtonExportToExcel.Size = new System.Drawing.Size(189, 37);
            this.ButtonExportToExcel.TabIndex = 58;
            this.ButtonExportToExcel.Text = "Экспорт в Excel";
            this.ButtonExportToExcel.UseVisualStyleBackColor = true;
            this.ButtonExportToExcel.Click += new System.EventHandler(this.ButtonExportToExcel_Click);
            // 
            // dateTimePickerFilterEnd
            // 
            this.dateTimePickerFilterEnd.Location = new System.Drawing.Point(384, 72);
            this.dateTimePickerFilterEnd.Name = "dateTimePickerFilterEnd";
            this.dateTimePickerFilterEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFilterEnd.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(345, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 18);
            this.label17.TabIndex = 56;
            this.label17.Text = "по:";
            // 
            // textBoxNameSIZFilter
            // 
            this.textBoxNameSIZFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNameSIZFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNameSIZFilter.Location = new System.Drawing.Point(536, 27);
            this.textBoxNameSIZFilter.Name = "textBoxNameSIZFilter";
            this.textBoxNameSIZFilter.Size = new System.Drawing.Size(375, 22);
            this.textBoxNameSIZFilter.TabIndex = 51;
            this.textBoxNameSIZFilter.TextChanged += new System.EventHandler(this.TextBoxFilterNameSIZ_TextChanged);
            // 
            // dateTimePickerFilterStart
            // 
            this.dateTimePickerFilterStart.Location = new System.Drawing.Point(134, 72);
            this.dateTimePickerFilterStart.Name = "dateTimePickerFilterStart";
            this.dateTimePickerFilterStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFilterStart.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(421, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "СИЗ / Прибор:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(108, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 18);
            this.label15.TabIndex = 48;
            this.label15.Text = "с:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(17, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 47;
            this.label16.Text = "Работник:";
            // 
            // textBoxNameWorkerFilter
            // 
            this.textBoxNameWorkerFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNameWorkerFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNameWorkerFilter.Location = new System.Drawing.Point(102, 27);
            this.textBoxNameWorkerFilter.Name = "textBoxNameWorkerFilter";
            this.textBoxNameWorkerFilter.Size = new System.Drawing.Size(302, 22);
            this.textBoxNameWorkerFilter.TabIndex = 1;
            this.textBoxNameWorkerFilter.TextChanged += new System.EventHandler(this.TextBoxFilterNameWorker_TextChanged);
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.AllowUserToAddRows = false;
            this.DataGridViewFilter.AllowUserToDeleteRows = false;
            this.DataGridViewFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewFilter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFilter.Location = new System.Drawing.Point(3, 113);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFilter.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewFilter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewFilter.RowTemplate.Height = 24;
            this.DataGridViewFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFilter.Size = new System.Drawing.Size(1200, 529);
            this.DataGridViewFilter.TabIndex = 0;
            this.DataGridViewFilter.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewFilter_RowsAdded);
            // 
            // tabPageAreas
            // 
            this.tabPageAreas.Controls.Add(this.DataGridViewArea);
            this.tabPageAreas.Controls.Add(this.ButtonDeleteArea);
            this.tabPageAreas.Controls.Add(this.ButtonChangeArea);
            this.tabPageAreas.Controls.Add(this.ButtonAddArea);
            this.tabPageAreas.Controls.Add(this.textBoxNameArea);
            this.tabPageAreas.Controls.Add(this.labelNewArea);
            this.tabPageAreas.Location = new System.Drawing.Point(4, 25);
            this.tabPageAreas.Name = "tabPageAreas";
            this.tabPageAreas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAreas.Size = new System.Drawing.Size(1223, 645);
            this.tabPageAreas.TabIndex = 1;
            this.tabPageAreas.Text = "Участки";
            this.tabPageAreas.UseVisualStyleBackColor = true;
            // 
            // DataGridViewArea
            // 
            this.DataGridViewArea.AllowUserToAddRows = false;
            this.DataGridViewArea.AllowUserToDeleteRows = false;
            this.DataGridViewArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewArea.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DataGridViewArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewArea.Location = new System.Drawing.Point(329, 43);
            this.DataGridViewArea.Name = "DataGridViewArea";
            this.DataGridViewArea.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewArea.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewArea.RowTemplate.Height = 24;
            this.DataGridViewArea.Size = new System.Drawing.Size(379, 580);
            this.DataGridViewArea.TabIndex = 5;
            this.DataGridViewArea.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewArea_RowHeaderMouseClick);
            this.DataGridViewArea.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewArea_RowsAdded);
            // 
            // ButtonDeleteArea
            // 
            this.ButtonDeleteArea.Location = new System.Drawing.Point(39, 297);
            this.ButtonDeleteArea.Name = "ButtonDeleteArea";
            this.ButtonDeleteArea.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeleteArea.TabIndex = 4;
            this.ButtonDeleteArea.Text = "Удалить";
            this.ButtonDeleteArea.UseVisualStyleBackColor = true;
            this.ButtonDeleteArea.Click += new System.EventHandler(this.ButtonDeleteArea_Click);
            // 
            // ButtonChangeArea
            // 
            this.ButtonChangeArea.Location = new System.Drawing.Point(39, 212);
            this.ButtonChangeArea.Name = "ButtonChangeArea";
            this.ButtonChangeArea.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangeArea.TabIndex = 3;
            this.ButtonChangeArea.Text = "Изменить";
            this.ButtonChangeArea.UseVisualStyleBackColor = true;
            this.ButtonChangeArea.Click += new System.EventHandler(this.ButtonChangeArea_Click);
            // 
            // ButtonAddArea
            // 
            this.ButtonAddArea.Location = new System.Drawing.Point(39, 135);
            this.ButtonAddArea.Name = "ButtonAddArea";
            this.ButtonAddArea.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddArea.TabIndex = 2;
            this.ButtonAddArea.Text = "Добавить";
            this.ButtonAddArea.UseVisualStyleBackColor = true;
            this.ButtonAddArea.Click += new System.EventHandler(this.ButtonAddArea_Click);
            // 
            // textBoxNameArea
            // 
            this.textBoxNameArea.Location = new System.Drawing.Point(39, 82);
            this.textBoxNameArea.Name = "textBoxNameArea";
            this.textBoxNameArea.Size = new System.Drawing.Size(236, 22);
            this.textBoxNameArea.TabIndex = 1;
            // 
            // labelNewArea
            // 
            this.labelNewArea.AutoSize = true;
            this.labelNewArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewArea.Location = new System.Drawing.Point(36, 43);
            this.labelNewArea.Name = "labelNewArea";
            this.labelNewArea.Size = new System.Drawing.Size(137, 18);
            this.labelNewArea.TabIndex = 0;
            this.labelNewArea.Text = "Название участка:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.DataGridViewPositions);
            this.tabPage3.Controls.Add(this.ButtonDeletePosition);
            this.tabPage3.Controls.Add(this.ButtonChangePosition);
            this.tabPage3.Controls.Add(this.ButtonAddPosition);
            this.tabPage3.Controls.Add(this.comboBoxNameArea);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxNamePosition);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1223, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Должности";
            // 
            // DataGridViewPositions
            // 
            this.DataGridViewPositions.AllowUserToAddRows = false;
            this.DataGridViewPositions.AllowUserToDeleteRows = false;
            this.DataGridViewPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPositions.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DataGridViewPositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewPositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPositions.Location = new System.Drawing.Point(362, 43);
            this.DataGridViewPositions.Name = "DataGridViewPositions";
            this.DataGridViewPositions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPositions.RowTemplate.Height = 24;
            this.DataGridViewPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPositions.Size = new System.Drawing.Size(831, 577);
            this.DataGridViewPositions.TabIndex = 9;
            this.DataGridViewPositions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPositions_RowHeaderMouseClick);
            this.DataGridViewPositions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewPositions_RowsAdded);
            // 
            // ButtonDeletePosition
            // 
            this.ButtonDeletePosition.Location = new System.Drawing.Point(30, 324);
            this.ButtonDeletePosition.Name = "ButtonDeletePosition";
            this.ButtonDeletePosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeletePosition.TabIndex = 8;
            this.ButtonDeletePosition.Text = "Удалить";
            this.ButtonDeletePosition.UseVisualStyleBackColor = true;
            this.ButtonDeletePosition.Click += new System.EventHandler(this.ButtonDeletePosition_Click);
            // 
            // ButtonChangePosition
            // 
            this.ButtonChangePosition.Location = new System.Drawing.Point(30, 263);
            this.ButtonChangePosition.Name = "ButtonChangePosition";
            this.ButtonChangePosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangePosition.TabIndex = 7;
            this.ButtonChangePosition.Text = "Изменить";
            this.ButtonChangePosition.UseVisualStyleBackColor = true;
            this.ButtonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // ButtonAddPosition
            // 
            this.ButtonAddPosition.Location = new System.Drawing.Point(30, 205);
            this.ButtonAddPosition.Name = "ButtonAddPosition";
            this.ButtonAddPosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddPosition.TabIndex = 6;
            this.ButtonAddPosition.Text = "Добавить";
            this.ButtonAddPosition.UseVisualStyleBackColor = true;
            this.ButtonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // comboBoxNameArea
            // 
            this.comboBoxNameArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameArea.FormattingEnabled = true;
            this.comboBoxNameArea.Location = new System.Drawing.Point(30, 145);
            this.comboBoxNameArea.Name = "comboBoxNameArea";
            this.comboBoxNameArea.Size = new System.Drawing.Size(102, 24);
            this.comboBoxNameArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Участок:";
            // 
            // textBoxNamePosition
            // 
            this.textBoxNamePosition.Location = new System.Drawing.Point(30, 73);
            this.textBoxNamePosition.Name = "textBoxNamePosition";
            this.textBoxNamePosition.Size = new System.Drawing.Size(302, 22);
            this.textBoxNamePosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название должности:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.comboBoxWorkerArea);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxWorkerGroup);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.DataGridViewWorkers);
            this.tabPage2.Controls.Add(this.ButtonDeleteWorker);
            this.tabPage2.Controls.Add(this.ButtonChangeWorker);
            this.tabPage2.Controls.Add(this.ButtonAddWorker);
            this.tabPage2.Controls.Add(this.comboBoxWorkerPosition);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxNameWorker);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1223, 645);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Работники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkerArea
            // 
            this.comboBoxWorkerArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerArea.FormattingEnabled = true;
            this.comboBoxWorkerArea.Location = new System.Drawing.Point(418, 57);
            this.comboBoxWorkerArea.Name = "comboBoxWorkerArea";
            this.comboBoxWorkerArea.Size = new System.Drawing.Size(213, 24);
            this.comboBoxWorkerArea.TabIndex = 21;
            this.comboBoxWorkerArea.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxWorkerArea_SelectionChangeCommitted);
            this.comboBoxWorkerArea.SelectedValueChanged += new System.EventHandler(this.ComboBoxWorkerArea_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(415, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Участок:";
            // 
            // comboBoxWorkerGroup
            // 
            this.comboBoxWorkerGroup.DisplayMember = "IdGroupOfES";
            this.comboBoxWorkerGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerGroup.FormattingEnabled = true;
            this.comboBoxWorkerGroup.Location = new System.Drawing.Point(953, 57);
            this.comboBoxWorkerGroup.Name = "comboBoxWorkerGroup";
            this.comboBoxWorkerGroup.Size = new System.Drawing.Size(154, 24);
            this.comboBoxWorkerGroup.TabIndex = 19;
            this.comboBoxWorkerGroup.ValueMember = "IdGroupOfES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(950, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Группа ЭБ:";
            // 
            // DataGridViewWorkers
            // 
            this.DataGridViewWorkers.AllowUserToAddRows = false;
            this.DataGridViewWorkers.AllowUserToDeleteRows = false;
            this.DataGridViewWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewWorkers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewWorkers.Location = new System.Drawing.Point(156, 99);
            this.DataGridViewWorkers.Name = "DataGridViewWorkers";
            this.DataGridViewWorkers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewWorkers.RowTemplate.Height = 24;
            this.DataGridViewWorkers.Size = new System.Drawing.Size(1049, 540);
            this.DataGridViewWorkers.TabIndex = 17;
            this.DataGridViewWorkers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewWorkers_RowHeaderMouseClick);
            this.DataGridViewWorkers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewWorkers_RowsAdded);
            // 
            // ButtonDeleteWorker
            // 
            this.ButtonDeleteWorker.Location = new System.Drawing.Point(23, 345);
            this.ButtonDeleteWorker.Name = "ButtonDeleteWorker";
            this.ButtonDeleteWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeleteWorker.TabIndex = 16;
            this.ButtonDeleteWorker.Text = "Удалить";
            this.ButtonDeleteWorker.UseVisualStyleBackColor = true;
            this.ButtonDeleteWorker.Click += new System.EventHandler(this.ButtonDeleteWorker_Click);
            // 
            // ButtonChangeWorker
            // 
            this.ButtonChangeWorker.Location = new System.Drawing.Point(23, 235);
            this.ButtonChangeWorker.Name = "ButtonChangeWorker";
            this.ButtonChangeWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangeWorker.TabIndex = 15;
            this.ButtonChangeWorker.Text = "Изменить";
            this.ButtonChangeWorker.UseVisualStyleBackColor = true;
            this.ButtonChangeWorker.Click += new System.EventHandler(this.ButtonChangeWorker_Click);
            // 
            // ButtonAddWorker
            // 
            this.ButtonAddWorker.Location = new System.Drawing.Point(23, 131);
            this.ButtonAddWorker.Name = "ButtonAddWorker";
            this.ButtonAddWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddWorker.TabIndex = 14;
            this.ButtonAddWorker.Text = "Добавить";
            this.ButtonAddWorker.UseVisualStyleBackColor = true;
            this.ButtonAddWorker.Click += new System.EventHandler(this.ButtonAddWorker_Click);
            // 
            // comboBoxWorkerPosition
            // 
            this.comboBoxWorkerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerPosition.FormattingEnabled = true;
            this.comboBoxWorkerPosition.Location = new System.Drawing.Point(669, 57);
            this.comboBoxWorkerPosition.Name = "comboBoxWorkerPosition";
            this.comboBoxWorkerPosition.Size = new System.Drawing.Size(245, 24);
            this.comboBoxWorkerPosition.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(666, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Должность:";
            // 
            // textBoxNameWorker
            // 
            this.textBoxNameWorker.Location = new System.Drawing.Point(23, 59);
            this.textBoxNameWorker.Name = "textBoxNameWorker";
            this.textBoxNameWorker.Size = new System.Drawing.Size(354, 22);
            this.textBoxNameWorker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ФИО работника:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxTypeOfSIZ);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.textBoxInventNumbSIZ);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.DataGridViewSIZ);
            this.tabPage4.Controls.Add(this.ButtonDeleteSIZ);
            this.tabPage4.Controls.Add(this.ButtonChangeSIZ);
            this.tabPage4.Controls.Add(this.ButtonAddSIZ);
            this.tabPage4.Controls.Add(this.textBoxNameSIZ);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1223, 645);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "СИЗ / Приборы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeOfSIZ
            // 
            this.textBoxTypeOfSIZ.Location = new System.Drawing.Point(771, 54);
            this.textBoxTypeOfSIZ.Name = "textBoxTypeOfSIZ";
            this.textBoxTypeOfSIZ.Size = new System.Drawing.Size(199, 22);
            this.textBoxTypeOfSIZ.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(768, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 18);
            this.label20.TabIndex = 33;
            this.label20.Text = "Тип:";
            // 
            // textBoxInventNumbSIZ
            // 
            this.textBoxInventNumbSIZ.Location = new System.Drawing.Point(542, 54);
            this.textBoxInventNumbSIZ.Name = "textBoxInventNumbSIZ";
            this.textBoxInventNumbSIZ.Size = new System.Drawing.Size(199, 22);
            this.textBoxInventNumbSIZ.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(542, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Инвентарный №:";
            // 
            // DataGridViewSIZ
            // 
            this.DataGridViewSIZ.AllowUserToAddRows = false;
            this.DataGridViewSIZ.AllowUserToDeleteRows = false;
            this.DataGridViewSIZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewSIZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewSIZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSIZ.Location = new System.Drawing.Point(159, 94);
            this.DataGridViewSIZ.Name = "DataGridViewSIZ";
            this.DataGridViewSIZ.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSIZ.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewSIZ.RowTemplate.Height = 24;
            this.DataGridViewSIZ.Size = new System.Drawing.Size(1043, 532);
            this.DataGridViewSIZ.TabIndex = 29;
            this.DataGridViewSIZ.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSIZ_RowHeaderMouseClick);
            this.DataGridViewSIZ.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewSIZ_RowsAdded);
            // 
            // ButtonDeleteSIZ
            // 
            this.ButtonDeleteSIZ.Location = new System.Drawing.Point(26, 338);
            this.ButtonDeleteSIZ.Name = "ButtonDeleteSIZ";
            this.ButtonDeleteSIZ.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeleteSIZ.TabIndex = 28;
            this.ButtonDeleteSIZ.Text = "Удалить";
            this.ButtonDeleteSIZ.UseVisualStyleBackColor = true;
            this.ButtonDeleteSIZ.Click += new System.EventHandler(this.ButtonDeleteSIZ_Click);
            // 
            // ButtonChangeSIZ
            // 
            this.ButtonChangeSIZ.Location = new System.Drawing.Point(26, 228);
            this.ButtonChangeSIZ.Name = "ButtonChangeSIZ";
            this.ButtonChangeSIZ.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangeSIZ.TabIndex = 27;
            this.ButtonChangeSIZ.Text = "Изменить";
            this.ButtonChangeSIZ.UseVisualStyleBackColor = true;
            this.ButtonChangeSIZ.Click += new System.EventHandler(this.ButtonChangeSIZ_Click);
            // 
            // ButtonAddSIZ
            // 
            this.ButtonAddSIZ.Location = new System.Drawing.Point(26, 124);
            this.ButtonAddSIZ.Name = "ButtonAddSIZ";
            this.ButtonAddSIZ.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddSIZ.TabIndex = 26;
            this.ButtonAddSIZ.Text = "Добавить";
            this.ButtonAddSIZ.UseVisualStyleBackColor = true;
            this.ButtonAddSIZ.Click += new System.EventHandler(this.ButtonAddSIZ_Click);
            // 
            // textBoxNameSIZ
            // 
            this.textBoxNameSIZ.Location = new System.Drawing.Point(26, 54);
            this.textBoxNameSIZ.Multiline = true;
            this.textBoxNameSIZ.Name = "textBoxNameSIZ";
            this.textBoxNameSIZ.Size = new System.Drawing.Size(492, 22);
            this.textBoxNameSIZ.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(23, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Наименование СИЗ / прибора:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxIssueNameWorker);
            this.tabPage5.Controls.Add(this.comboBoxInventNumbSIZ);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.dateTimePickerIssueWorkability);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.comboBoxIssueSIZ);
            this.tabPage5.Controls.Add(this.textBoxNotationOfIssue);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.dateTimePickerIssueSIZ);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.DataGridViewIssue);
            this.tabPage5.Controls.Add(this.ButtonDeleteIssue);
            this.tabPage5.Controls.Add(this.ButtonChangeIssue);
            this.tabPage5.Controls.Add(this.ButtonAddIssue);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1223, 645);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Выдача СИЗ/приборов";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxIssueNameWorker
            // 
            this.textBoxIssueNameWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxIssueNameWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxIssueNameWorker.Location = new System.Drawing.Point(33, 48);
            this.textBoxIssueNameWorker.Name = "textBoxIssueNameWorker";
            this.textBoxIssueNameWorker.Size = new System.Drawing.Size(377, 22);
            this.textBoxIssueNameWorker.TabIndex = 51;
            // 
            // comboBoxInventNumbSIZ
            // 
            this.comboBoxInventNumbSIZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventNumbSIZ.FormattingEnabled = true;
            this.comboBoxInventNumbSIZ.Location = new System.Drawing.Point(881, 48);
            this.comboBoxInventNumbSIZ.Name = "comboBoxInventNumbSIZ";
            this.comboBoxInventNumbSIZ.Size = new System.Drawing.Size(327, 24);
            this.comboBoxInventNumbSIZ.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(878, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 18);
            this.label21.TabIndex = 49;
            this.label21.Text = "Инвентарный №:";
            // 
            // dateTimePickerIssueWorkability
            // 
            this.dateTimePickerIssueWorkability.Location = new System.Drawing.Point(1008, 115);
            this.dateTimePickerIssueWorkability.Name = "dateTimePickerIssueWorkability";
            this.dateTimePickerIssueWorkability.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerIssueWorkability.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(1005, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 18);
            this.label19.TabIndex = 47;
            this.label19.Text = "Годность:";
            // 
            // comboBoxIssueSIZ
            // 
            this.comboBoxIssueSIZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIssueSIZ.FormattingEnabled = true;
            this.comboBoxIssueSIZ.Location = new System.Drawing.Point(437, 48);
            this.comboBoxIssueSIZ.Name = "comboBoxIssueSIZ";
            this.comboBoxIssueSIZ.Size = new System.Drawing.Size(427, 24);
            this.comboBoxIssueSIZ.TabIndex = 46;
            this.comboBoxIssueSIZ.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxIssueSIZ_SelectionChangeCommitted);
            this.comboBoxIssueSIZ.SelectedValueChanged += new System.EventHandler(this.ComboBoxIssueSIZ_SelectedValueChanged);
            // 
            // textBoxNotationOfIssue
            // 
            this.textBoxNotationOfIssue.Location = new System.Drawing.Point(146, 87);
            this.textBoxNotationOfIssue.Multiline = true;
            this.textBoxNotationOfIssue.Name = "textBoxNotationOfIssue";
            this.textBoxNotationOfIssue.Size = new System.Drawing.Size(613, 50);
            this.textBoxNotationOfIssue.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(30, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "Примечание:";
            // 
            // dateTimePickerIssueSIZ
            // 
            this.dateTimePickerIssueSIZ.Location = new System.Drawing.Point(783, 115);
            this.dateTimePickerIssueSIZ.Name = "dateTimePickerIssueSIZ";
            this.dateTimePickerIssueSIZ.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerIssueSIZ.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(434, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "СИЗ / Прибор:";
            // 
            // DataGridViewIssue
            // 
            this.DataGridViewIssue.AllowUserToAddRows = false;
            this.DataGridViewIssue.AllowUserToDeleteRows = false;
            this.DataGridViewIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewIssue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIssue.Location = new System.Drawing.Point(146, 151);
            this.DataGridViewIssue.Name = "DataGridViewIssue";
            this.DataGridViewIssue.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIssue.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewIssue.RowTemplate.Height = 24;
            this.DataGridViewIssue.Size = new System.Drawing.Size(1062, 488);
            this.DataGridViewIssue.TabIndex = 39;
            this.DataGridViewIssue.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewIssue_RowHeaderMouseClick);
            this.DataGridViewIssue.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewIssue_RowsAdded);
            // 
            // ButtonDeleteIssue
            // 
            this.ButtonDeleteIssue.Location = new System.Drawing.Point(33, 410);
            this.ButtonDeleteIssue.Name = "ButtonDeleteIssue";
            this.ButtonDeleteIssue.Size = new System.Drawing.Size(95, 37);
            this.ButtonDeleteIssue.TabIndex = 38;
            this.ButtonDeleteIssue.Text = "Удалить";
            this.ButtonDeleteIssue.UseVisualStyleBackColor = true;
            this.ButtonDeleteIssue.Click += new System.EventHandler(this.ButtonDeleteIssue_Click);
            // 
            // ButtonChangeIssue
            // 
            this.ButtonChangeIssue.Location = new System.Drawing.Point(33, 302);
            this.ButtonChangeIssue.Name = "ButtonChangeIssue";
            this.ButtonChangeIssue.Size = new System.Drawing.Size(95, 37);
            this.ButtonChangeIssue.TabIndex = 37;
            this.ButtonChangeIssue.Text = "Изменить";
            this.ButtonChangeIssue.UseVisualStyleBackColor = true;
            this.ButtonChangeIssue.Click += new System.EventHandler(this.ButtonChangeIssue_Click);
            // 
            // ButtonAddIssue
            // 
            this.ButtonAddIssue.Location = new System.Drawing.Point(33, 198);
            this.ButtonAddIssue.Name = "ButtonAddIssue";
            this.ButtonAddIssue.Size = new System.Drawing.Size(95, 37);
            this.ButtonAddIssue.TabIndex = 36;
            this.ButtonAddIssue.Text = "Добавить";
            this.ButtonAddIssue.UseVisualStyleBackColor = true;
            this.ButtonAddIssue.Click += new System.EventHandler(this.ButtonAddIssue_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(780, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Дата выдачи:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(30, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Работник:";
            // 
            // databaseOfEmployeesDataSetBindingSource
            // 
            this.databaseOfEmployeesDataSetBindingSource.DataSource = this.databaseOfEmployeesDataSet;
            this.databaseOfEmployeesDataSetBindingSource.Position = 0;
            // 
            // databaseOfEmployeesDataSet
            // 
            this.databaseOfEmployeesDataSet.DataSetName = "DatabaseOfEmployeesDataSet";
            this.databaseOfEmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.databaseOfEmployeesDataSetBindingSource;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.databaseOfEmployeesDataSetBindingSource;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 699);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "База выдачи СИЗ/Приборов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFilter.ResumeLayout(false);
            this.tabPageFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFilter)).EndInit();
            this.tabPageAreas.ResumeLayout(false);
            this.tabPageAreas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPositions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWorkers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSIZ)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFilter;
        private System.Windows.Forms.TabPage tabPageAreas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxNameArea;
        private System.Windows.Forms.Label labelNewArea;
        private System.Windows.Forms.DataGridView DataGridViewArea;
        private System.Windows.Forms.Button ButtonDeleteArea;
        private System.Windows.Forms.Button ButtonChangeArea;
        private System.Windows.Forms.Button ButtonAddArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamePosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewPositions;
        private System.Windows.Forms.Button ButtonDeletePosition;
        private System.Windows.Forms.Button ButtonChangePosition;
        private System.Windows.Forms.Button ButtonAddPosition;
        private System.Windows.Forms.ComboBox comboBoxNameArea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxWorkerGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridViewWorkers;
        private System.Windows.Forms.Button ButtonDeleteWorker;
        private System.Windows.Forms.Button ButtonChangeWorker;
        private System.Windows.Forms.Button ButtonAddWorker;
        private System.Windows.Forms.ComboBox comboBoxWorkerPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWorkerArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxInventNumbSIZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DataGridViewSIZ;
        private System.Windows.Forms.Button ButtonDeleteSIZ;
        private System.Windows.Forms.Button ButtonChangeSIZ;
        private System.Windows.Forms.Button ButtonAddSIZ;
        private System.Windows.Forms.TextBox textBoxNameSIZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxNotationOfIssue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueSIZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridViewIssue;
        private System.Windows.Forms.Button ButtonDeleteIssue;
        private System.Windows.Forms.Button ButtonChangeIssue;
        private System.Windows.Forms.Button ButtonAddIssue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxIssueSIZ;
        private System.Windows.Forms.TextBox textBoxNameWorkerFilter;
        private System.Windows.Forms.DataGridView DataGridViewFilter;
        private System.Windows.Forms.TextBox textBoxNameSIZFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ButtonExportToExcel;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueWorkability;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTypeOfSIZ;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxInventNumbSIZ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ButtonResetFilter;
        private System.Windows.Forms.Button ButtonShowDateFilter;
        private System.Windows.Forms.BindingSource databaseOfEmployeesDataSetBindingSource;
        private DatabaseOfEmployeesDataSet databaseOfEmployeesDataSet;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DatabaseOfEmployeesDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private DatabaseOfEmployeesDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.TextBox textBoxIssueNameWorker;
    }
}

