using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Position : DataOperations
    {
        private string sqlDisplayCmd = "SELECT IdPosition, p.Position 'Должность', a.Area 'Участок' " +
            "FROM Positions AS p, Areas AS a " +
            "WHERE p.Area=a.IdArea;";
        private string sqlInsertCmd = "INSERT INTO Positions (Position, Area) " +
            "VALUES (@position, (SELECT IdArea FROM Areas WHERE Area=@area));";
        private string sqlUpdateCmd = "UPDATE Positions " +
            "SET Position=@position, Area=a.IdArea " +
            "FROM (SELECT IdArea, Area FROM Areas) AS a " +
            "WHERE Positions.IdPosition=@id AND a.Area=@area;";
        private string sqlDeleteCmd = "DELETE Positions WHERE IdPosition=@id;";

        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Position() { }
    }
}
