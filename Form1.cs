using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        List<SqlParameter> paramsArea = new List<SqlParameter>();
        List<SqlParameter> paramsPosition = new List<SqlParameter>();
        List<SqlParameter> paramsWorker = new List<SqlParameter>();
        List<SqlParameter> paramsSIZ = new List<SqlParameter>();
        List<SqlParameter> paramsIssue = new List<SqlParameter>();
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
            DataGridViewFilter_LoadData();
            area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
            position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
            worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
            siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
            issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
            HideColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetSIZ.SIZ' table. You can move, or remove it, as needed.
            sIZTableAdapter.Fill(this.databaseOfEmployeesDataSetSIZ.SIZ);            
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetWorkers.Workers' table. You can move, or remove it, as needed.
            workersTableAdapter.Fill(this.databaseOfEmployeesDataSetWorkers.Workers);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetGroups.Groups' table. You can move, or remove it, as needed.
            groupsTableAdapter.Fill(this.databaseOfEmployeesDataSetGroups.Groups);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetPositions.Positions' table. You can move, or remove it, as needed.
            positionsTableAdapter.Fill(this.databaseOfEmployeesDataSetPositions.Positions);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetAreas.Areas' table. You can move, or remove it, as needed.
            areasTableAdapter.Fill(this.databaseOfEmployeesDataSetAreas.Areas);
            
        }

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
            ID = Convert.ToInt32(DataGridViewArea.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNameArea.Text = DataGridViewArea.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ButtonAddArea_Click(object sender, EventArgs e)
        {
            if (textBoxNameArea.Text != "")
            {
                paramsArea.Add(new SqlParameter("@area", textBoxNameArea.Text));
                area.ChangeRecord(area.SqlInsertCmd, paramsArea);
                MessageBox.Show("Запись добавлена.");
                area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                ClearParamsArea();
            }
            else
            {
                MessageBox.Show("Введите название участка.");
            }
        }

        private void ButtonChangeArea_Click(object sender, EventArgs e)
        {
            if (textBoxNameArea.Text != "")
            {
                paramsArea.Add(new SqlParameter("@id", ID));
                paramsArea.Add(new SqlParameter("@area", textBoxNameArea.Text));
                area.ChangeRecord(area.SqlUpdateCmd, paramsArea);
                MessageBox.Show("Запись изменена.");
                area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                ClearParamsArea();
            }
            else
            {
                MessageBox.Show("Выберите запись для изменения.");
            }
        }

        private void ButtonDeleteArea_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsArea.Add(new SqlParameter("@id", ID));
                area.ChangeRecord(area.SqlDeleteCmd, paramsArea);
                MessageBox.Show("Запись удалена.");
                area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
                ClearParamsArea();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
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
            ID = Convert.ToInt32(DataGridViewPositions.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNamePosition.Text = DataGridViewPositions.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxNameArea.Text = DataGridViewPositions.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ButtonAddPosition_Click(object sender, EventArgs e)
        {
            if (textBoxNamePosition.Text != "")
            {
                paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.Text));
                position.ChangeRecord(position.SqlInsertCmd, paramsPosition);
                MessageBox.Show("Запись добавлена.");
                position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                ClearParamsPosition();
            }
            else
            {
                MessageBox.Show("Введите название должности.");
            }
        }
        
        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            if (textBoxNamePosition.Text != "")
            {
                paramsPosition.Add(new SqlParameter("@id", ID));
                paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.Text));
                position.ChangeRecord(position.SqlUpdateCmd, paramsPosition);
                MessageBox.Show("Запись изменена.");
                position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                ClearParamsPosition();
            }
            else
            {
                MessageBox.Show("Выберете запись для изменения");
            }
        }

        private void ButtonDeletePosition_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsPosition.Add(new SqlParameter("@id", ID));
                position.ChangeRecord(position.SqlDeleteCmd, paramsPosition);
                MessageBox.Show("Запись удалена.");
                position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
                ClearParamsPosition();                
            }
            else
            {
                MessageBox.Show("Выберете запись для удаления");
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
            ID = Convert.ToInt32(DataGridViewWorkers.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNameWorker.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxWorkerArea.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxWorkerPosition.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxWorkerGroup.Text = DataGridViewWorkers.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            if (textBoxNameWorker.Text != "")
            {
                paramsWorker.Add(new SqlParameter("@nameWorker", textBoxNameWorker.Text));
                paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.Text));
                paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.Text));
                paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.Text));
                worker.ChangeRecord(worker.SqlInsertCmd, paramsWorker);
                MessageBox.Show("Запись добавлена.", "Добавление нового работника");
                worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                ClearParamsWorker();
            }
            else
            {
                MessageBox.Show("Введите ФИО работника");
            }
        }

        private void ButtonChangeWorker_Click(object sender, EventArgs e)
        {
            if (textBoxNameWorker.Text != "")
            {
                paramsWorker.Add(new SqlParameter("@id", ID));
                paramsWorker.Add(new SqlParameter("@nameWorker", textBoxNameWorker.Text));
                paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.Text));
                paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.Text));
                paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.Text));
                worker.ChangeRecord(worker.SqlUpdateCmd, paramsWorker);
                MessageBox.Show("Запись изменена.", "Изменение записи");
                worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                ClearParamsWorker();
            }
            else
            {
                MessageBox.Show("Введите ФИО работника");
            }
        }

        private void ButtonDeleteWorker_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsWorker.Add(new SqlParameter("@id", ID));
                worker.ChangeRecord(worker.SqlDeleteCmd, paramsWorker);
                MessageBox.Show("Запись удалена", "Удаление записи");
                worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
                ClearParamsWorker();
            }
            else
            {
                MessageBox.Show("Выберете запись для удаления");
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
            ID = Convert.ToInt32(DataGridViewSIZ.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNameSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxInventNumbSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTypeOfSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerWorkabilitySIZ.Value = Convert.ToDateTime(DataGridViewSIZ.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void ButtonAddSIZ_Click(object sender, EventArgs e)
        {
            if(textBoxNameSIZ.Text != "")
            {
                paramsSIZ.Add(new SqlParameter("@nameSIZ", textBoxNameSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@invNumbSIZ", textBoxInventNumbSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@typeOfSIZ", textBoxTypeOfSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@workSIZ", dateTimePickerWorkabilitySIZ.Value.ToShortDateString()));
                siz.ChangeRecord(siz.SqlInsertCmd, paramsSIZ);
                MessageBox.Show("Запись добавлена.", "Добавление нового СИЗ/прибора");
                siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                ClearParamsSIZ();

            }
            else
            {
                MessageBox.Show("Введите название СИЗ/прибора");
            }
        }

        private void ButtonChangeSIZ_Click(object sender, EventArgs e)
        {
            if (textBoxNameSIZ.Text != "")
            {
                paramsSIZ.Add(new SqlParameter("@id", ID));
                paramsSIZ.Add(new SqlParameter("@nameSIZ", textBoxNameSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@invNumbSIZ", textBoxInventNumbSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@typeOfSIZ", textBoxTypeOfSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@workSIZ", dateTimePickerWorkabilitySIZ.Value.ToShortDateString()));
                siz.ChangeRecord(siz.SqlUpdateCmd, paramsSIZ);
                MessageBox.Show("Запись изменена.", "Изменение записи");
                siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                ClearParamsSIZ();
            }
            else
            {
                MessageBox.Show("Введите название СИЗ/прибора");
            }
        }

        private void ButtonDeleteSIZ_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsSIZ.Add(new SqlParameter("@id", ID));
                siz.ChangeRecord(siz.SqlDeleteCmd, paramsSIZ);
                MessageBox.Show("Запись удалена.", "Удаление записи");
                siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
                ClearParamsSIZ();
            }
            else
            {
                MessageBox.Show("Выберете запись для удаления.");
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
            ID = Convert.ToInt32(DataGridViewIssue.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBoxIssueWorker.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxIssueSIZ.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxTypeOfSIZ.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerIssueSIZ.Value = Convert.ToDateTime(DataGridViewIssue.Rows[e.RowIndex].Cells[4].Value.ToString());
            dateTimePickerIssueWorkability.Value = Convert.ToDateTime(DataGridViewIssue.Rows[e.RowIndex].Cells[5].Value.ToString());
            textBoxNotationOfIssue.Text = DataGridViewIssue.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void ButtonAddIssue_Click(object sender, EventArgs e)
        {
            paramsIssue.Add(new SqlParameter("@issueWorker", comboBoxIssueWorker.Text));
            paramsIssue.Add(new SqlParameter("@issueSIZ", comboBoxIssueSIZ.Text));
            paramsIssue.Add(new SqlParameter("@issueDate", dateTimePickerIssueSIZ.Value.ToShortDateString()));
            paramsIssue.Add(new SqlParameter("@issueNotation", textBoxNotationOfIssue.Text));
            issue.ChangeRecord(issue.SqlInsertCmd, paramsIssue);
            MessageBox.Show("Запись добавлена.", "Добавление записи");
            issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
            ClearParamsIssue();
        }

        private void ButtonChangeIssue_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsIssue.Add(new SqlParameter("@id", ID));
                paramsIssue.Add(new SqlParameter("@issueWorker", comboBoxIssueWorker.Text));
                paramsIssue.Add(new SqlParameter("@issueSIZ", comboBoxIssueSIZ.Text));
                paramsIssue.Add(new SqlParameter("@issueDate", dateTimePickerIssueSIZ.Value.ToShortDateString()));
                paramsIssue.Add(new SqlParameter("@issueNotation", textBoxNotationOfIssue.Text));
                issue.ChangeRecord(issue.SqlUpdateCmd, paramsIssue);
                MessageBox.Show("Запись изменена.", "Изменение записи");
                issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
                ClearParamsIssue();
            }
            else
            {
                MessageBox.Show("Выберете запись для изменения.");
            }
        }

        private void ButtonDeleteIssue_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                paramsIssue.Add(new SqlParameter("@id", ID));
                issue.ChangeRecord(issue.SqlDeleteCmd, paramsIssue);
                MessageBox.Show("Запись удалена.", "Удаление записи");
                issue.DisplayData(issue.SqlDispayCmd, DataGridViewIssue);
                ClearParamsIssue();
            }
            else
            {
                MessageBox.Show("Выберете запись для удаления.");
            }
        }

        /// <summary>
        /// After adding a rows in DataGridView's refill DataSets of types. 
        /// </summary>
        /// 
        private void DataGridViewArea_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            areasTableAdapter.Fill(databaseOfEmployeesDataSetAreas.Areas);
        }

        private void DataGridViewPositions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            positionsTableAdapter.Fill(databaseOfEmployeesDataSetPositions.Positions);
        }

        private void DataGridViewWorkers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            workersTableAdapter.Fill(databaseOfEmployeesDataSetWorkers.Workers);
        }

        private void DataGridViewSIZ_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sIZTableAdapter.Fill(databaseOfEmployeesDataSetSIZ.SIZ);
        }

        /// <summary>
        /// Filter
        /// </summary>
        /// 
        private void DataGridViewFilter_LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString);
                conn.Open();
                string sqlcmd = "SELECT w.NameWorker 'ФИО работника', a.Area 'Участок', p.Position 'Должность', " +
                                "s.NameSIZ 'СИЗ / Прибор', i.DateOfIssueSIZ 'Дата выдачи', s.WorkabilitySIZ 'Годность', i.Notation 'Примечание' " +
                                "FROM Areas AS a, Issue AS i, Workers AS w, SIZ AS s, Positions AS p " +
                                "WHERE i.IdWorker = w.IdWorker AND i.IdSIZ = s.IdSIZ AND a.IdArea = w.AreaWorker AND p.IdPosition = w.PositionWorker;";
                SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn);
                adapt.Fill(dt);
                DataGridViewFilter.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ComboBoxAreaFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Участок LIKE '%{0}%'", comboBoxAreaFilter.Text);
            DataGridViewFilter.DataSource = dv;
        }

        private void ButtonResetFilter_Click(object sender, EventArgs e)
        {
            dt.Clear();
            DataGridViewFilter_LoadData();
        }

    }
}
