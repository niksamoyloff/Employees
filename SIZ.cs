using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SIZ : DataOperations
    {
        private string sqlDispayCmd = "SELECT * FROM SIZ";
            //"SELECT IdSIZ, NameSIZ, InventoryNumberSIZ, FORMAT(WorkabilitySIZ, 'd', 'de-de') AS WorkabilitySIZ FROM SIZ;";

        private string sqlInsertCmd = "INSERT INTO SIZ (NameSIZ, InventoryNumberSIZ, WorkabilitySIZ) " +
            "VALUES (@nameSIZ, @invNumbSIZ, CONVERT(date, @workSIZ, 104));";

        private string sqlUpdateCmd = "UPDATE SIZ SET NameSIZ = @nameSIZ, InventoryNumberSIZ = @invNumbSIZ, " +
            "WorkabilitySIZ = CONVERT(date, @workSIZ, 104) WHERE IdSIZ = @id;";

        private string sqlDeleteCmd = "DELETE SIZ WHERE IdSIZ = @id;";

        public string SqlDispayCmd { get => sqlDispayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public SIZ() { }
    }
}
