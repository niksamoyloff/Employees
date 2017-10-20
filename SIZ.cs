using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SIZ : DataOperations
    {
        private string sqlDispayCmd = "SELECT IdSIZ, NameSIZ 'Наименование СИЗ/прибора', InventoryNumberSIZ 'Инвентарный номер', TypeOfSIZ 'Тип' FROM SIZ;";

        private string sqlInsertCmd = "INSERT INTO SIZ (NameSIZ, InventoryNumberSIZ, TypeOfSIZ) " +
            "VALUES (@nameSIZ, @invNumbSIZ, @typeOfSIZ);";

        private string sqlUpdateCmd = "UPDATE SIZ SET NameSIZ = @nameSIZ, InventoryNumberSIZ = @invNumbSIZ, TypeOfSIZ = @typeOfSIZ WHERE IdSIZ = @id;";

        private string sqlDeleteCmd = "DELETE SIZ WHERE IdSIZ = @id;";

        public string SqlDispayCmd { get => sqlDispayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public SIZ() { }
    }
}
