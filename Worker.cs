using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Worker : DataOperations
    {
        private string sqlDisplayCmd = "SELECT w.IdWorker, w.NameWorker 'ФИО работника', a.Area 'Участок', p.Position 'Должность', g.GroupOfES 'Группа ЭБ' " +
            "FROM Workers AS w, Areas AS a, Positions AS p, Groups AS g " +
            "WHERE w.AreaWorker = a.IdArea AND w.PositionWorker = p.IdPosition AND w.GroupWorker = g.IdGroupOfES;";
        private string sqlInsertCmd = "INSERT INTO Workers (NameWorker, AreaWorker, PositionWorker, GroupWorker) " +
            "VALUES (@nameWorker, (SELECT IdArea FROM Areas WHERE Area = @areaWorker), (SELECT IdPosition FROM Positions WHERE Position = @positionWorker), (SELECT IdGroupOfES FROM Groups WHERE GroupOfES = @groupWorker));";
        private string sqlUpdateCmd = "UPDATE Workers " +
            "SET NameWorker = @nameWorker, AreaWorker = @areaWorker, PositionWorker = q.IdPosition, GroupWorker = q.IdGroupOfES " +
            "FROM (SELECT a.IdArea, a.Area, p.IdPosition, p.Position, g.IdGroupOfES, g.GroupOfES FROM Areas AS a, Positions AS p, Groups AS g) AS q " +
            "WHERE Workers.IdWorker = @id AND q.Area = @areaWorker AND q.Position = @positionWorker AND q.GroupOfES = @groupWorker;";
        private string sqlDeleteCmd = "DELETE Workers WHERE IdWorker = @id;";

        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Worker() { }
    }
}
