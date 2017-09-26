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
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;User Instance = False;AttachDbFilename='C:\\USERS\\NIKSA\\DOCUMENTS\\VISUAL STUDIO 2017\\PROJECTS\\EMPLOYEES\\EMPLOYEES\\BIN\\DEBUG\\DATABASEOFEMPLOYEES.MDF';Integrated Security = True;Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public void DisplayData(string sqlcmd, DataGridView DataGridView)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(sqlcmd, con);
            adapt.Fill(dt);
            DataGridView.DataSource = dt;
            con.Close();
        }

        public void ChangeRecord(string sqlcmd, List<SqlParameter> prm)
        {
            cmd = new SqlCommand(sqlcmd, con);
            con.Open();
            cmd.Parameters.AddRange(prm.ToArray<SqlParameter>());
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
