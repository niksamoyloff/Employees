namespace Employees
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.databaseOfEmployeesDataSet = new Employees.DatabaseOfEmployeesDataSet();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamePosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxWorkerArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxWorkerGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteWorker = new System.Windows.Forms.Button();
            this.ButtonChangeWorker = new System.Windows.Forms.Button();
            this.ButtonAddWorker = new System.Windows.Forms.Button();
            this.comboBoxWorkerPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameWorker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areasTableAdapter = new Employees.DatabaseOfEmployeesDataSetTableAdapters.AreasTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageAreas);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPageAreas.Size = new System.Drawing.Size(926, 449);
            this.tabPageAreas.TabIndex = 1;
            this.tabPageAreas.Text = "Участки";
            this.tabPageAreas.UseVisualStyleBackColor = true;
            // 
            // DataGridViewArea
            // 
            this.DataGridViewArea.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DataGridViewArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewArea.Location = new System.Drawing.Point(39, 160);
            this.DataGridViewArea.Name = "DataGridViewArea";
            this.DataGridViewArea.RowTemplate.Height = 24;
            this.DataGridViewArea.Size = new System.Drawing.Size(379, 270);
            this.DataGridViewArea.TabIndex = 5;
            this.DataGridViewArea.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewArea_RowHeaderMouseClick);
            // 
            // ButtonDeleteArea
            // 
            this.ButtonDeleteArea.Location = new System.Drawing.Point(326, 91);
            this.ButtonDeleteArea.Name = "ButtonDeleteArea";
            this.ButtonDeleteArea.Size = new System.Drawing.Size(92, 37);
            this.ButtonDeleteArea.TabIndex = 4;
            this.ButtonDeleteArea.Text = "Удалить";
            this.ButtonDeleteArea.UseVisualStyleBackColor = true;
            this.ButtonDeleteArea.Click += new System.EventHandler(this.ButtonDeleteArea_Click);
            // 
            // ButtonChangeArea
            // 
            this.ButtonChangeArea.Location = new System.Drawing.Point(182, 91);
            this.ButtonChangeArea.Name = "ButtonChangeArea";
            this.ButtonChangeArea.Size = new System.Drawing.Size(99, 37);
            this.ButtonChangeArea.TabIndex = 3;
            this.ButtonChangeArea.Text = "Изменить";
            this.ButtonChangeArea.UseVisualStyleBackColor = true;
            this.ButtonChangeArea.Click += new System.EventHandler(this.ButtonChangeArea_Click);
            // 
            // ButtonAddArea
            // 
            this.ButtonAddArea.Location = new System.Drawing.Point(39, 91);
            this.ButtonAddArea.Name = "ButtonAddArea";
            this.ButtonAddArea.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddArea.TabIndex = 2;
            this.ButtonAddArea.Text = "Добавить";
            this.ButtonAddArea.UseVisualStyleBackColor = true;
            this.ButtonAddArea.Click += new System.EventHandler(this.ButtonAddArea_Click);
            // 
            // textBoxNameArea
            // 
            this.textBoxNameArea.Location = new System.Drawing.Point(182, 43);
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
            this.tabPage3.Size = new System.Drawing.Size(926, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Должности";
            // 
            // DataGridViewPositions
            // 
            this.DataGridViewPositions.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DataGridViewPositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewPositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPositions.Location = new System.Drawing.Point(368, 62);
            this.DataGridViewPositions.Name = "DataGridViewPositions";
            this.DataGridViewPositions.RowTemplate.Height = 24;
            this.DataGridViewPositions.Size = new System.Drawing.Size(530, 368);
            this.DataGridViewPositions.TabIndex = 9;
            this.DataGridViewPositions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPositions_RowHeaderMouseClick);
            // 
            // ButtonDeletePosition
            // 
            this.ButtonDeletePosition.Location = new System.Drawing.Point(32, 343);
            this.ButtonDeletePosition.Name = "ButtonDeletePosition";
            this.ButtonDeletePosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeletePosition.TabIndex = 8;
            this.ButtonDeletePosition.Text = "Удалить";
            this.ButtonDeletePosition.UseVisualStyleBackColor = true;
            this.ButtonDeletePosition.Click += new System.EventHandler(this.ButtonDeletePosition_Click);
            // 
            // ButtonChangePosition
            // 
            this.ButtonChangePosition.Location = new System.Drawing.Point(32, 282);
            this.ButtonChangePosition.Name = "ButtonChangePosition";
            this.ButtonChangePosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangePosition.TabIndex = 7;
            this.ButtonChangePosition.Text = "Изменить";
            this.ButtonChangePosition.UseVisualStyleBackColor = true;
            this.ButtonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // ButtonAddPosition
            // 
            this.ButtonAddPosition.Location = new System.Drawing.Point(32, 224);
            this.ButtonAddPosition.Name = "ButtonAddPosition";
            this.ButtonAddPosition.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddPosition.TabIndex = 6;
            this.ButtonAddPosition.Text = "Добавить";
            this.ButtonAddPosition.UseVisualStyleBackColor = true;
            this.ButtonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // comboBoxNameArea
            // 
            this.comboBoxNameArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseOfEmployeesDataSet, "Areas.Area", true));
            this.comboBoxNameArea.DataSource = this.areasBindingSource;
            this.comboBoxNameArea.DisplayMember = "Area";
            this.comboBoxNameArea.FormattingEnabled = true;
            this.comboBoxNameArea.Location = new System.Drawing.Point(32, 164);
            this.comboBoxNameArea.Name = "comboBoxNameArea";
            this.comboBoxNameArea.Size = new System.Drawing.Size(102, 24);
            this.comboBoxNameArea.TabIndex = 3;
            this.comboBoxNameArea.ValueMember = "Area";
            // 
            // databaseOfEmployeesDataSet
            // 
            this.databaseOfEmployeesDataSet.DataSetName = "DatabaseOfEmployeesDataSet";
            this.databaseOfEmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.databaseOfEmployeesDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Участок:";
            // 
            // textBoxNamePosition
            // 
            this.textBoxNamePosition.Location = new System.Drawing.Point(32, 92);
            this.textBoxNamePosition.Name = "textBoxNamePosition";
            this.textBoxNamePosition.Size = new System.Drawing.Size(302, 22);
            this.textBoxNamePosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название должности:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxWorkerArea);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxWorkerGroup);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridViewWorkers);
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
            this.tabPage2.Size = new System.Drawing.Size(926, 449);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Работники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkerArea
            // 
            this.comboBoxWorkerArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseOfEmployeesDataSet, "Areas.Area", true));
            this.comboBoxWorkerArea.FormattingEnabled = true;
            this.comboBoxWorkerArea.Location = new System.Drawing.Point(408, 57);
            this.comboBoxWorkerArea.Name = "comboBoxWorkerArea";
            this.comboBoxWorkerArea.Size = new System.Drawing.Size(136, 24);
            this.comboBoxWorkerArea.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(405, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Участок:";
            // 
            // comboBoxWorkerGroup
            // 
            this.comboBoxWorkerGroup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseOfEmployeesDataSet, "Areas.Area", true));
            this.comboBoxWorkerGroup.FormattingEnabled = true;
            this.comboBoxWorkerGroup.Location = new System.Drawing.Point(820, 57);
            this.comboBoxWorkerGroup.Name = "comboBoxWorkerGroup";
            this.comboBoxWorkerGroup.Size = new System.Drawing.Size(82, 24);
            this.comboBoxWorkerGroup.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(817, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Группа ЭБ:";
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(156, 99);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.RowTemplate.Height = 24;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(745, 334);
            this.dataGridViewWorkers.TabIndex = 17;
            // 
            // ButtonDeleteWorker
            // 
            this.ButtonDeleteWorker.Location = new System.Drawing.Point(23, 343);
            this.ButtonDeleteWorker.Name = "ButtonDeleteWorker";
            this.ButtonDeleteWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonDeleteWorker.TabIndex = 16;
            this.ButtonDeleteWorker.Text = "Удалить";
            this.ButtonDeleteWorker.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeWorker
            // 
            this.ButtonChangeWorker.Location = new System.Drawing.Point(23, 233);
            this.ButtonChangeWorker.Name = "ButtonChangeWorker";
            this.ButtonChangeWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonChangeWorker.TabIndex = 15;
            this.ButtonChangeWorker.Text = "Изменить";
            this.ButtonChangeWorker.UseVisualStyleBackColor = true;
            // 
            // ButtonAddWorker
            // 
            this.ButtonAddWorker.Location = new System.Drawing.Point(23, 129);
            this.ButtonAddWorker.Name = "ButtonAddWorker";
            this.ButtonAddWorker.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddWorker.TabIndex = 14;
            this.ButtonAddWorker.Text = "Добавить";
            this.ButtonAddWorker.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkerPosition
            // 
            this.comboBoxWorkerPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseOfEmployeesDataSet, "Areas.Area", true));
            this.comboBoxWorkerPosition.FormattingEnabled = true;
            this.comboBoxWorkerPosition.Location = new System.Drawing.Point(572, 57);
            this.comboBoxWorkerPosition.Name = "comboBoxWorkerPosition";
            this.comboBoxWorkerPosition.Size = new System.Drawing.Size(218, 24);
            this.comboBoxWorkerPosition.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(569, 26);
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
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAreas.ResumeLayout(false);
            this.tabPageAreas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfEmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private DatabaseOfEmployeesDataSet databaseOfEmployeesDataSet;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DatabaseOfEmployeesDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxWorkerGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.Button ButtonDeleteWorker;
        private System.Windows.Forms.Button ButtonChangeWorker;
        private System.Windows.Forms.Button ButtonAddWorker;
        private System.Windows.Forms.ComboBox comboBoxWorkerPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWorkerArea;
        private System.Windows.Forms.Label label6;
    }
}

