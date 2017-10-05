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
        List<SqlParameter> paramsArea = new List<SqlParameter>();
        List<SqlParameter> paramsPosition = new List<SqlParameter>();
        List<SqlParameter> paramsWorker = new List<SqlParameter>();
        List<SqlParameter> paramsSIZ = new List<SqlParameter>();

        public Form1()
        {
            InitializeComponent();
            area.DisplayData(area.SqlDisplayCmd, DataGridViewArea);
            position.DisplayData(position.SqlDisplayCmd, DataGridViewPositions);
            worker.DisplayData(worker.SqlDisplayCmd, DataGridViewWorkers);
            siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
            DataGridViewArea.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetSIZ.SIZ' table. You can move, or remove it, as needed.
            this.sIZTableAdapter.Fill(this.databaseOfEmployeesDataSetSIZ.SIZ);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetWorkers.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseOfEmployeesDataSetWorkers.Workers);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetGroups.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.databaseOfEmployeesDataSetGroups.Groups);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetPositions.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.databaseOfEmployeesDataSetPositions.Positions);
            // TODO: This line of code loads data into the 'databaseOfEmployeesDataSetAreas.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.databaseOfEmployeesDataSetAreas.Areas);

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

        private void ButtonAddPosition_Click(object sender, EventArgs e)
        {
            if (textBoxNamePosition.Text != "")
            {
                paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.SelectedValue.ToString()));
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

        private void DataGridViewPositions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewPositions.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNamePosition.Text = DataGridViewPositions.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxNameArea.SelectedValue = DataGridViewPositions.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            if (textBoxNamePosition.Text != "")
            {
                paramsPosition.Add(new SqlParameter("@id", ID));
                paramsPosition.Add(new SqlParameter("@position", textBoxNamePosition.Text));
                paramsPosition.Add(new SqlParameter("@area", comboBoxNameArea.SelectedValue.ToString()));
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
            comboBoxWorkerArea.SelectedValue = DataGridViewWorkers.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxWorkerPosition.SelectedValue = DataGridViewWorkers.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxWorkerGroup.SelectedValue = DataGridViewWorkers.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            if (textBoxNameWorker.Text != "")
            {
                paramsWorker.Add(new SqlParameter("@nameWorker", textBoxNameWorker.Text));
                paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.SelectedValue.ToString()));
                paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.SelectedValue.ToString()));
                paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.SelectedValue.ToString()));
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
                paramsWorker.Add(new SqlParameter("@areaWorker", comboBoxWorkerArea.SelectedValue.ToString()));
                paramsWorker.Add(new SqlParameter("@positionWorker", comboBoxWorkerPosition.SelectedValue.ToString()));
                paramsWorker.Add(new SqlParameter("@groupWorker", comboBoxWorkerGroup.SelectedValue.ToString()));
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

        private void ButtonAddSIZ_Click(object sender, EventArgs e)
        {
            if(textBoxNameSIZ.Text != "")
            {
                paramsSIZ.Add(new SqlParameter("@nameSIZ", textBoxNameSIZ.Text));
                paramsSIZ.Add(new SqlParameter("@invNumbSIZ", textBoxInventNumbSIZ.Text));
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
                MessageBox.Show("Запись удалена", "Удаление записи");
                siz.DisplayData(siz.SqlDispayCmd, DataGridViewSIZ);
            }
            else
            {
                MessageBox.Show("Выберете запись для удаления");
            }
        }

        private void DataGridViewSIZ_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewSIZ.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxNameSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxInventNumbSIZ.Text = DataGridViewSIZ.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePickerWorkabilitySIZ.Value = Convert.ToDateTime(DataGridViewSIZ.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
