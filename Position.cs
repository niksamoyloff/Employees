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
        private string sqlDisplayCmd = "SELECT * FROM [Positions]";
        private string sqlInsertCmd = "INSERT INTO [Positions] (Position, Area) VALUES (@position, (SELECT IdArea FROM [Areas] WHERE Area = @area))";
        private string sqlChangeCmd = "UPDATE [Positions] SET Position=@position, Area=Areas.IdArea WHERE Areas.Area=@area";
        private string sqlDeleteCmd = "DELETE [Positions] WHERE IdPosition=@id";

        public int IdPosition { get => idPosition; set => idPosition = value; }
        public string NamePosition { get => namePosition; set => NamePosition = value; }
        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlChangeCmd { get => sqlChangeCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Position() { }
    }
}
