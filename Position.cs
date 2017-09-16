using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Position : DataOperations
    {
        private int idPosition;
        private string namePosition;
        private string sqlDisplayCmd = "SELECT Positions.IdPosition, Positions.Position, Areas.Area " +
            "FROM [Positions],[Areas] " +
            "WHERE Positions.Area=Areas.IdArea";
        private string sqlInsertCmd = "INSERT INTO [Positions] (Position, Area) " +
            "VALUES (@position, (SELECT IdArea FROM [Areas] WHERE Area=@area))";
        private string sqlUpdateCmd = "UPDATE [Positions] " +
            "SET Position=@position, Area=a.IdArea " +
            "FROM (SELECT IdArea, Area FROM [Areas]) AS a " +
            "WHERE Positions.IdPosition=@id AND a.Area=@area";
        private string sqlDeleteCmd = "DELETE [Positions] WHERE IdPosition=@id";

        public int IdPosition { get => idPosition; set => idPosition = value; }
        public string NamePosition { get => namePosition; set => NamePosition = value; }
        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Position() { }
    }
}
