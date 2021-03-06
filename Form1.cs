﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Employees
{
    public partial class Form1 : Form
    {
        int ID = 0;
        Area area = new Area();
        Position position = new Position();
        Worker worker = new Worker();
        SIZ siz = new SIZ();
        Issue issue = new Issue();
        DataTable dtFilter = new DataTable();
        List<SqlParameter> paramsArea = new List<SqlParameter>();
        List<SqlParameter> paramsPosition = new List<SqlParameter>();
        List<SqlParameter> paramsWorker = new List<SqlParameter>();
        List<SqlParameter> paramsSIZ = new List<SqlParameter>();
        List<SqlParameter> paramsIssue = new List<SqlParameter>();
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewFilter_LoadData();
            area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
            position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
            worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
            siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
            issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
            HideColumns();
            ComboBoxAreaAreas_LoadData();
            ComboBoxIssueSIZ_LoadData();
            TextBoxIssueNameWorker_LoadData();
            ComboBoxWorkerGroups_LoadData();
        }

        /// <summary>
        /// Hide records ID
        /// </summary>
        private void HideColumns()
        {
            DataGridViewArea.Columns[0].Visible = false;
            DataGridViewPositions.Columns[0].Visible = false;
            DataGridViewWorkers.Columns[0].Visible = false;
            DataGridViewSIZ.Columns[0].Visible = false;
            DataGridViewIssue.Columns[0].Visible = false;
        }

        /// <summary>
        /// Area methods. 
        /// </summary>
        private void ClearParamsArea()
        {
            ID = 0;
            textBoxNameArea.Text = "";
            paramsArea.Clear();
        }

        private void DataGridViewArea_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DataGridViewArea.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNameArea.Text = DataGridViewArea.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonAddArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameArea.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewArea.RowCount; i++)
                    {
                        if (DataGridViewArea.Rows[i].Cells[1].Value.ToString() == textBoxNameArea.Text)
                        {
                            MessageBox.Show("Участок уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        paramsArea.Add(new SqlParameter("@area", textBoxNameArea.Text));
                        area.ChangeRecord(area.SqlInsertCmd, paramsArea);
                        AutoClosingMessageBox.Show("Запись добавлена.", "Добавление записи", 1000);
                        area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                        ClearParamsArea();
                    }
                }
                else
                {
                    MessageBox.Show("Введите название участка.", "Добавление записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
            
        }

        private void ButtonChangeArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameArea.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewArea.RowCount; i++)
                    {
                        if (DataGridViewArea.Rows[i].Cells[1].Value.ToString() == textBoxNameArea.Text)
                        {
                            MessageBox.Show("Участок уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        if (MessageBox.Show("Изменить запись?", "Изменение записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            paramsArea.Add(new SqlParameter("@id", ID));
                            paramsArea.Add(new SqlParameter("@area", textBoxNameArea.Text));
                            area.ChangeRecord(area.SqlUpdateCmd, paramsArea);
                            area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                            ClearParamsArea();
                        }
                    }                
                }
                else
                {
                    MessageBox.Show("Выберите запись для изменения.", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
            
        }

        private void ButtonDeleteArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {                    
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        paramsArea.Add(new SqlParameter("@id", ID));
                        area.ChangeRecord(area.SqlDeleteCmd, paramsArea);
                        area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                        ClearParamsArea();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите запись для удаления.", "Удаление записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }
        
        /// <summary>
        /// Position methods.
        /// </summary>
        private void ClearParamsPosition()
        {
            ID = 0;
            textBoxNamePosition.Text = "";
            paramsPosition.Clear();
        }

        private void DataGridViewPositions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DataGridViewPositions.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNamePosition.Text = DataGridViewPositions.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxNameArea.Text = DataGridViewPositions.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonAddPosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamePosition.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewPositions.RowCount; i++)
                    {
                        if (DataGridViewPositions.Rows[i].Cells[1].Value.ToString() == textBoxNamePosition.Text 
                            && DataGridViewPositions.Rows[i].Cells[2].Value.ToString() == comboBoxNameArea.Text)
                        {
                            MessageBox.Show("Должность уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                        paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.Text));
                        position.ChangeRecord(position.SqlInsertCmd, paramsPosition);
                        AutoClosingMessageBox.Show("Запись добавлена.", "Добавление записи", 1000);
                        position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                        ClearParamsPosition();
                    }
                }
                else
                {
                    MessageBox.Show("Введите название должности.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }
        
        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamePosition.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewPositions.RowCount; i++)
                    {
                        if (DataGridViewPositions.Rows[i].Cells[1].Value.ToString() == textBoxNamePosition.Text 
                            && DataGridViewPositions.Rows[i].Cells[2].Value.ToString() == comboBoxNameArea.Text)
                        {
                            MessageBox.Show("Должность уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        if (MessageBox.Show("Изменить запись?", "Изменение записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            paramsPosition.Add(new SqlParameter("@id", ID));
                            paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                            paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.Text));
                            position.ChangeRecord(position.SqlUpdateCmd, paramsPosition);
                            position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                            ClearParamsPosition();
                        }
                    }                      
                }
                else
                {
                    MessageBox.Show("Выберете запись для изменения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonDeletePosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        paramsPosition.Add(new SqlParameter("@id", ID));
                        position.ChangeRecord(position.SqlDeleteCmd, paramsPosition);
                        position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                        ClearParamsPosition();
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для удаления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }
        
        /// <summary>
        /// Worker methods. 
        /// </summary>
        private void ClearParamsWorker()
        {
            ID = 0;
            textBoxNameWorker.Text = "";
            paramsWorker.Clear();
        }

        private void DataGridViewWorkers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DataGridViewWorkers.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNameWorker.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxWorkerArea.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxWorkerPosition.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxWorkerGroup.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameWorker.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewWorkers.RowCount; i++)
                    {
                        if (DataGridViewWorkers.Rows[i].Cells[1].Value.ToString() == textBoxNameWorker.Text
                            && DataGridViewWorkers.Rows[i].Cells[2].Value.ToString() == comboBoxWorkerArea.Text
                            && DataGridViewWorkers.Rows[i].Cells[3].Value.ToString() == comboBoxWorkerPosition.Text
                            && DataGridViewWorkers.Rows[i].Cells[4].Value.ToString() == comboBoxWorkerGroup.Text)
                        {
                            MessageBox.Show("Работник уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        paramsWorker.Add(new SqlParameter("@nameWorker", textBoxNameWorker.Text));
                        paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.Text));
                        paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.Text));
                        paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.Text));
                        worker.ChangeRecord(worker.SqlInsertCmd, paramsWorker);
                        AutoClosingMessageBox.Show("Запись добавлена.", "Добавление записи", 1000);
                        worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                        ClearParamsWorker();
                    }
                }
                else
                {
                    MessageBox.Show("Введите ФИО работника");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonChangeWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameWorker.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewWorkers.RowCount; i++)
                    {
                        if (DataGridViewWorkers.Rows[i].Cells[1].Value.ToString() == textBoxNameWorker.Text
                            && DataGridViewWorkers.Rows[i].Cells[2].Value.ToString() == comboBoxWorkerArea.Text
                            && DataGridViewWorkers.Rows[i].Cells[3].Value.ToString() == comboBoxWorkerPosition.Text
                            && DataGridViewWorkers.Rows[i].Cells[4].Value.ToString() == comboBoxWorkerGroup.Text)
                        {
                            MessageBox.Show("Работник уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        if (MessageBox.Show("Изменить запись?", "Изменение записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            paramsWorker.Add(new SqlParameter("@id", ID));
                            paramsWorker.Add(new SqlParameter("@nameWorker", textBoxNameWorker.Text));
                            paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.Text));
                            paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.Text));
                            paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.Text));
                            worker.ChangeRecord(worker.SqlUpdateCmd, paramsWorker);
                            worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                            ClearParamsWorker();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для изменения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonDeleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        paramsWorker.Add(new SqlParameter("@id", ID));
                        worker.ChangeRecord(worker.SqlDeleteCmd, paramsWorker);
                        worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                        ClearParamsWorker();
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для удаления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        /// <summary>
        /// SIZ methods.
        /// </summary>
        private void ClearParamsSIZ()
        {
            ID = 0;
            textBoxNameSIZ.Text = "";
            textBoxInventNumbSIZ.Text = "";
            paramsSIZ.Clear();
        }

        private void DataGridViewSIZ_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DataGridViewSIZ.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNameSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxInventNumbSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxTypeOfSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonAddSIZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameSIZ.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewSIZ.RowCount; i++)
                    {
                        if (DataGridViewSIZ.Rows[i].Cells[1].Value.ToString() == textBoxNameSIZ.Text
                            && DataGridViewSIZ.Rows[i].Cells[2].Value.ToString() == textBoxInventNumbSIZ.Text
                            && DataGridViewSIZ.Rows[i].Cells[3].Value.ToString() == textBoxTypeOfSIZ.Text)
                        {
                            MessageBox.Show("СИЗ/Прибор уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        paramsSIZ.Add(new SqlParameter("@nameSIZ", textBoxNameSIZ.Text));
                        paramsSIZ.Add(new SqlParameter("@invNumbSIZ", textBoxInventNumbSIZ.Text));
                        paramsSIZ.Add(new SqlParameter("@typeOfSIZ", textBoxTypeOfSIZ.Text));
                        siz.ChangeRecord(siz.SqlInsertCmd, paramsSIZ);
                        AutoClosingMessageBox.Show("Запись добавлена.", "Добавление записи", 1000);
                        siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                        ClearParamsSIZ();
                    }
                }
                else
                {
                    MessageBox.Show("Введите название СИЗ/прибора");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonChangeSIZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameSIZ.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewSIZ.RowCount; i++)
                    {
                        if (DataGridViewSIZ.Rows[i].Cells[1].Value.ToString() == textBoxNameSIZ.Text
                            && DataGridViewSIZ.Rows[i].Cells[2].Value.ToString() == textBoxInventNumbSIZ.Text
                            && DataGridViewSIZ.Rows[i].Cells[3].Value.ToString() == textBoxTypeOfSIZ.Text)
                        {
                            MessageBox.Show("СИЗ/Прибор уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        if (MessageBox.Show("Изменить запись?", "Изменение записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            paramsSIZ.Add(new SqlParameter("@id", ID));
                            paramsSIZ.Add(new SqlParameter("@nameSIZ", textBoxNameSIZ.Text));
                            paramsSIZ.Add(new SqlParameter("@invNumbSIZ", textBoxInventNumbSIZ.Text));
                            paramsSIZ.Add(new SqlParameter("@typeOfSIZ", textBoxTypeOfSIZ.Text));
                            siz.ChangeRecord(siz.SqlUpdateCmd, paramsSIZ);
                            siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                            ClearParamsSIZ();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите название СИЗ/прибора");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonDeleteSIZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        paramsSIZ.Add(new SqlParameter("@id", ID));
                        siz.ChangeRecord(siz.SqlDeleteCmd, paramsSIZ);
                        siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                        ClearParamsSIZ();
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        /// <summary>
        /// Issue methods.
        /// </summary>
        private void ClearParamsIssue()
        {
            ID = 0;
            textBoxNotationOfIssue.Text = "";
            paramsIssue.Clear();
        }

        private void DataGridViewIssue_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DataGridViewIssue.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxIssueNameWorker.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxIssueSIZ.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxInventNumbSIZ.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePickerIssueSIZ.Value = Convert.ToDateTime(DataGridViewIssue.Rows[e.RowIndex].Cells[4].Value.ToString());
                dateTimePickerIssueWorkability.Value = Convert.ToDateTime(DataGridViewIssue.Rows[e.RowIndex].Cells[5].Value.ToString());
                textBoxNotationOfIssue.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Нет даты выдачи или годности.", "Ошибка");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonAddIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIssueNameWorker.Text != "")
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewIssue.RowCount; i++)
                    {
                        if (DataGridViewIssue.Rows[i].Cells[1].Value.ToString() == textBoxIssueNameWorker.Text
                            && DataGridViewIssue.Rows[i].Cells[2].Value.ToString() == comboBoxIssueSIZ.Text
                            && DataGridViewIssue.Rows[i].Cells[3].Value.ToString() == comboBoxInventNumbSIZ.Text
                            && DataGridViewIssue.Rows[i].Cells[4].Value.ToString() == dateTimePickerIssueSIZ.Value.ToShortDateString()
                            && DataGridViewIssue.Rows[i].Cells[5].Value.ToString() == dateTimePickerIssueWorkability.Value.ToShortDateString()
                            && DataGridViewIssue.Rows[i].Cells[6].Value.ToString() == textBoxNotationOfIssue.Text)
                        {
                            MessageBox.Show("СИЗ/Прибор работнику уже выдан.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        paramsIssue.Add(new SqlParameter("@issueWorker", textBoxIssueNameWorker.Text));
                        paramsIssue.Add(new SqlParameter("@issueSIZ", comboBoxIssueSIZ.Text));
                        paramsIssue.Add(new SqlParameter("@typeOfSIZ", comboBoxInventNumbSIZ.Text));
                        paramsIssue.Add(new SqlParameter("@issueDate", dateTimePickerIssueSIZ.Value.ToShortDateString()));
                        paramsIssue.Add(new SqlParameter("@workSIZ", dateTimePickerIssueWorkability.Value.ToShortDateString()));
                        paramsIssue.Add(new SqlParameter("@issueNotation", textBoxNotationOfIssue.Text));
                        issue.ChangeRecord(issue.SqlInsertCmd, paramsIssue);
                        AutoClosingMessageBox.Show("Запись добавлена.", "Добавление записи", 1000);
                        issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
                        ClearParamsIssue();
                        DataGridViewFilter_LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Выберете работника");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonChangeIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    bool flag = false; // Flag for detecting last item in column
                    for (int i = 0; i < DataGridViewIssue.RowCount; i++)
                    {
                        if (DataGridViewIssue.Rows[i].Cells[1].Value.ToString() == textBoxIssueNameWorker.Text
                            && DataGridViewIssue.Rows[i].Cells[2].Value.ToString() == comboBoxIssueSIZ.Text
                            && DataGridViewIssue.Rows[i].Cells[3].Value.ToString() == comboBoxInventNumbSIZ.Text
                            && DataGridViewIssue.Rows[i].Cells[4].Value.ToString() == dateTimePickerIssueSIZ.Value.ToShortDateString()
                            && DataGridViewIssue.Rows[i].Cells[5].Value.ToString() == dateTimePickerIssueWorkability.Value.ToShortDateString()
                            && DataGridViewIssue.Rows[i].Cells[6].Value.ToString() == textBoxNotationOfIssue.Text)
                        {
                            MessageBox.Show("Запись о выдаче уже существует.", "Ошибка:");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) // Last item detected
                    {
                        if (MessageBox.Show("Изменить запись?", "Изменение записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            paramsIssue.Add(new SqlParameter("@id", ID));
                            paramsIssue.Add(new SqlParameter("@issueWorker", textBoxIssueNameWorker.Text));
                            paramsIssue.Add(new SqlParameter("@issueSIZ", comboBoxIssueSIZ.Text));
                            paramsIssue.Add(new SqlParameter("@typeOfSIZ", comboBoxInventNumbSIZ.Text));
                            paramsIssue.Add(new SqlParameter("@issueDate", dateTimePickerIssueSIZ.Value.ToShortDateString()));
                            paramsIssue.Add(new SqlParameter("@issueNotation", textBoxNotationOfIssue.Text));
                            paramsIssue.Add(new SqlParameter("@workSIZ", dateTimePickerIssueWorkability.Value.ToShortDateString()));
                            issue.ChangeRecord(issue.SqlUpdateCmd, paramsIssue);
                            issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
                            ClearParamsIssue();
                            DataGridViewFilter_LoadData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для изменения.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ButtonDeleteIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        paramsIssue.Add(new SqlParameter("@id", ID));
                        issue.ChangeRecord(issue.SqlDeleteCmd, paramsIssue);
                        issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
                        ClearParamsIssue();
                        DataGridViewFilter_LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Выберете запись для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        /// <summary>
        /// After adding a rows in DataGridView's refill DataSets of types. 
        /// </summary>
        /// 
        private void DataGridViewArea_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewArea.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewArea.RowHeadersWidth = 55;
            }
            ComboBoxAreaAreas_LoadData();
        }

        private void DataGridViewPositions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewPositions.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewPositions.RowHeadersWidth = 55;
            }
            ComboBoxWorkerPosition_LoadData();
        }

        private void DataGridViewWorkers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewWorkers.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewWorkers.RowHeadersWidth = 55;
            }
            TextBoxIssueNameWorker_LoadData();
        }

        private void DataGridViewSIZ_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewSIZ.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewSIZ.RowHeadersWidth = 55;
            }
            ComboBoxIssueSIZ_LoadData();
        }

        private void DataGridViewIssue_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewIssue.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewIssue.RowHeadersWidth = 55;
            }
        }

        /// <summary>
        /// Filter
        /// </summary>
        /// 
        private void DataGridViewFilter_LoadData()
        {
            dtFilter.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT s.NameSIZ 'СИЗ / Прибор', s.InventoryNumberSIZ 'Инвентарный номер', "+ //a.Area 'Участок', p.Position 'Должность', " +
                                    "i.WorkabilitySIZ 'Годность', w.NameWorker 'ФИО работника' " + //i.DateOfIssueSIZ 'Дата выдачи', i.Notation 'Примечание' " +
                                    "FROM Issue AS i, Workers AS w, SIZ AS s " + //Areas AS a, Positions AS p 
                                    "WHERE i.IdWorker = w.IdWorker AND i.IdSIZ = s.IdSIZ;"; //AND a.IdArea = w.AreaWorker AND p.IdPosition = w.PositionWorker
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        adapt.Fill(dtFilter);
                        DataGridViewFilter.DataSource = dtFilter;
                    }                        
                }

                var sourceNames = new AutoCompleteStringCollection();
                var sourceSIZ = new AutoCompleteStringCollection();
                foreach (DataGridViewRow row in DataGridViewFilter.Rows)
                {
                    sourceNames.Add(Convert.ToString(row.Cells[3].Value));
                    sourceSIZ.Add(Convert.ToString(row.Cells[0].Value));
                }
                textBoxNameWorkerFilter.AutoCompleteCustomSource = sourceNames;
                textBoxNameSIZFilter.AutoCompleteCustomSource = sourceSIZ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }

        }

        private void DataGridViewFilter_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewFilter.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                DataGridViewFilter.RowHeadersWidth = 55;
            }
        }

        /* private void ComboBoxFilterArea_SelectedIndexChanged(object sender, EventArgs e)
         {
             DataView dv = new DataView(dtFilter);
             dv.RowFilter = string.Format("Участок LIKE '%{0}%'", comboBoxAreaFilter.Text);
             DataGridViewFilter.DataSource = dv;
         } */

        private void ButtonResetFilter_Click(object sender, EventArgs e)
        {
            DataGridViewFilter_LoadData();
            ComboBoxAreaAreas_LoadData();
        }

        private void TextBoxFilterNameWorker_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtFilter);
            dv.RowFilter = string.Format("[ФИО работника] LIKE '%{0}%'", textBoxNameWorkerFilter.Text);
            DataGridViewFilter.DataSource = dv;
        }

        private void TextBoxFilterNameSIZ_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtFilter);
            dv.RowFilter = string.Format("[СИЗ / Прибор] LIKE '%{0}%'", textBoxNameSIZFilter.Text);
            DataGridViewFilter.DataSource = dv;
        }

        private void ButtonFilterShowDate_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtFilter);
            dv.RowFilter = string.Format("[Годность] >= '{0}' AND [Годность] <= '{1}'", dateTimePickerFilterStart.Value.ToShortDateString(), dateTimePickerFilterEnd.Value.ToShortDateString());
            DataGridViewFilter.DataSource = dv;
        }

        private void ComboBoxWorkerArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxWorkerPosition_LoadData();
        }

        private void ComboBoxIssueSIZ_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxIssueInventoryNumberSIZ_LoadData();
        }

        private void ComboBoxWorkerArea_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxWorkerPosition_LoadData();
        }

        private void ComboBoxIssueSIZ_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxIssueInventoryNumberSIZ_LoadData();
        }

        private void ComboBoxWorkerPosition_LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT p.Position FROM Positions AS p INNER JOIN Areas AS a ON p.Area = a.IdArea and a.Area LIKE N'" + comboBoxWorkerArea.Text + "';";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dtComboBoxWorkerPosition = new DataTable();
                        adapt.Fill(dtComboBoxWorkerPosition);
                        comboBoxWorkerPosition.DataSource = dtComboBoxWorkerPosition;
                        comboBoxWorkerPosition.DisplayMember = "Position";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ComboBoxAreaAreas_LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT Areas.Area FROM Areas;";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dtComboBoxArea = new DataTable();
                        adapt.Fill(dtComboBoxArea);

                        comboBoxWorkerArea.DataSource = dtComboBoxArea;
                        comboBoxWorkerArea.DisplayMember = "Area";
                        comboBoxWorkerArea.SelectedIndex = -1;

                        comboBoxWorkerPosition.DataSource = null;

                        comboBoxNameArea.BindingContext = new BindingContext();
                        comboBoxNameArea.DataSource = dtComboBoxArea;
                        comboBoxNameArea.DisplayMember = "Area";
                        comboBoxNameArea.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ComboBoxWorkerGroups_LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT GroupOfES FROM Groups;";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dtComboBoxGroups = new DataTable();
                        adapt.Fill(dtComboBoxGroups);

                        comboBoxWorkerGroup.DataSource = dtComboBoxGroups;
                        comboBoxWorkerGroup.DisplayMember = "GroupOfES";
                        comboBoxWorkerGroup.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка");
            }
        }

        private void ComboBoxIssueSIZ_LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT DISTINCT SIZ.NameSIZ FROM SIZ;";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dtComboBoxNameSIZ = new DataTable();
                        adapt.Fill(dtComboBoxNameSIZ);

                        comboBoxIssueSIZ.DataSource = dtComboBoxNameSIZ;
                        comboBoxIssueSIZ.DisplayMember = "NameSIZ";
                        comboBoxIssueSIZ.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка.");
            }
        }

        private void ComboBoxIssueInventoryNumberSIZ_LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    string sqlcmd = "SELECT DISTINCT SIZ.InventoryNumberSIZ FROM SIZ WHERE SIZ.NameSIZ LIKE N'" + comboBoxIssueSIZ.Text + "' ORDER BY InventoryNumberSIZ DESC;";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dtComboBoxTypeOfSIZ = new DataTable();
                        adapt.Fill(dtComboBoxTypeOfSIZ);

                        comboBoxInventNumbSIZ.DataSource = dtComboBoxTypeOfSIZ;
                        comboBoxInventNumbSIZ.DisplayMember = "InventoryNumberSIZ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка.");
            }
        }

        private void TextBoxIssueNameWorker_LoadData()
        {
            var sourceNames = new AutoCompleteStringCollection();

            foreach (DataGridViewRow row in DataGridViewWorkers.Rows)
            {
                sourceNames.Add(Convert.ToString(row.Cells[1].Value));
            }

            textBoxIssueNameWorker.AutoCompleteCustomSource = sourceNames;
        }
        
        private void DisplayInExcel()
        {
            Excel.Application excelReport = new Excel.Application();
            Excel.Workbook workBook = excelReport.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)excelReport.ActiveSheet;

            try
            {
                workSheet = workBook.ActiveSheet;
                workSheet.Name = "Экспорт";  

                int cellRowIndex = 3;
                int cellColumnIndex = 1;

                if (DataGridViewFilter.Rows.Count == 0)
                {
                    MessageBox.Show("Пустой фильтр, нечего экспортировать.", "Упс!");
                }
                else
                {
                    Excel.Range caption = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[1, 5]];
                    caption.Merge(Type.Missing);
                    caption.Font.Size = 16;
                    caption.Font.Bold = true;
                    caption.Value = "Выдача СИЗ / Приборов сотрудникам";
                    caption.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    for (int i = -1; i < DataGridViewFilter.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridViewFilter.Columns.Count; j++)
                        {                            
                            if (cellRowIndex == 3)
                            {
                                if (cellColumnIndex == 1)
                                {
                                    workSheet.Cells[cellRowIndex, 1] = "№";
                                    ((Excel.Range)workSheet.Cells[cellRowIndex, 1]).Font.Bold = true;
                                    cellColumnIndex++;
                                }
                                workSheet.Cells[cellRowIndex, cellColumnIndex] = DataGridViewFilter.Columns[j].HeaderText;
                                ((Excel.Range)workSheet.Cells[cellRowIndex, cellColumnIndex]).Font.Bold = true;
                            }
                            else
                            {
                                if (cellColumnIndex == 1)
                                {
                                    workSheet.Cells[cellRowIndex, 1] = DataGridViewFilter.Rows[i].Index + 1;
                                    cellColumnIndex++;
                                }
                                workSheet.Cells[cellRowIndex, cellColumnIndex] = DataGridViewFilter.Rows[i].Cells[j].Value.ToString().Replace(" 0:00:00", "");
                                ((Excel.Range)workSheet.Cells[cellRowIndex, cellColumnIndex]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            }
                            ((Excel.Range)workSheet.Cells[cellRowIndex, cellColumnIndex]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                            cellColumnIndex++;
                        }
                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }
                    workSheet.Columns.AutoFit();
                    excelReport.Visible = true;
                    excelReport.WindowState = Excel.XlWindowState.xlMaximized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка.");
            }
            //finally
            //{
            //    workBook.Save();
            //    workBook.Close(false);
            //    excelReport.Quit();
            //}
        }

        private void ButtonExportToExcel_Click(object sender, EventArgs e)
        {
            DisplayInExcel();
        }

    }
}
