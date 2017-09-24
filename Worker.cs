using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Worker
    {
        private string sqlDisplayCmd = "SELECT w.IdWorker, w.NameWorker 'ФИО работника', p.Position 'Должность', g.GroupOfES 'Группа ЭБ' " +
            "FROM Workers AS w, Positions AS p, Groups AS g " +
            "WHERE w.PositionWorker=p.IdPosition and w.GroupWorker=g.IdGroup;";
        private string sqlInsertCmd = "INSERT INTO Workers(NameWorker, PositionWorker, GroupWorker) " +
            "VALUES(@nameWorker, (SELECT IdPosition FROM Positions WHERE Position= @positionWorker), (SELECT IdGroup FROM Groups WHERE GroupOfES=@group));";
        private string sqlUpdateCmd = "UPDATE Workers " +
            "SET NameWorker = @nameWorker, PositionWorker = q.IdPosition, GroupWorker = q.IdGroup " +
            "FROM (SELECT p.IdPosition, p.Position, g.IdGroup, g.GroupOfES FROM Positions AS p, Groups AS g) AS q " +
            "WHERE Workers.IdWorker=@id AND q.Position= @positionWorker AND q.GroupOfES= @group;";
        private string sqlDeleteCmd = "DELETE Workers WHERE IdWorker=@id";

        public string SqlDisplayCmd { get => sqlDisplayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Worker() { }
    }
}
