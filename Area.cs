using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Employees
{
    public class Area : DataOperations
    {
        private int idArea;
        private string nameArea;
        private string sqlInsertCmd = "INSERT INTO [Areas] (Area) VALUES (@area)";
        private string sqlDisplayCmd = "SELECT * FROM [Areas]";
        private string sqlUpdateCmd = "UPDATE [Areas] SET Area=@area WHERE IdArea=@id";
        private string sqlDeleteCmd = "DELETE [Areas] WHERE IdArea=@id";

        public int IdArea { get => idArea; set => idArea = value; }
        public string NameArea { get => nameArea; set => nameArea = value; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Area() { }
    }
}
