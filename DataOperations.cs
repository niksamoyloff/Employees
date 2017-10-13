using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public class DataOperations
    {

        public void DisplayData(string sqlcmd, DataGridView DataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    conn.Open();
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd, conn))
                    {
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);
                        DataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangeRecord(string sqlcmd, List<SqlParameter> prm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseOfEmployeesConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlcmd, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddRange(prm.ToArray<SqlParameter>());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непредвиденная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
