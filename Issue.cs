using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Issue : DataOperations
    {
        private string sqlDispayCmd = "SELECT i.IdRecord, w.NameWorker 'ФИО работника', s.NameSIZ 'СИЗ / Прибор', i.DateOfIssueSIZ, i.Notation 'Примечание' " +
            "FROM Issue AS i, Workers AS w, SIZ AS s " +
            "WHERE i.IdWorker = w.IdWorker AND i.IdSIZ = s.IdSIZ;";

        private string sqlInsertCmd = "INSERT INTO Issue(IdWorker, IdSIZ, DateOfIssueSIZ, Notation) " +
            "VALUES ((SELECT IdWorker FROM Workers WHERE NameWorker = @issueWorker), " +
            "(SELECT IdSIZ FROM SIZ WHERE NameSIZ = @issueSIZ), CONVERT(date, @issueDate, 104), @issueNotation);";

        private string sqlUpdateCmd = "UPDATE Issue " +
            "SET IdWorker = q.IdWorker, IdSIZ = q.IdSIZ, DateOfIssueSIZ = CONVERT(date, @issueDate, 104), Notation = @issueNotation " +
            "FROM (SELECT w.IdWorker, w.NameWorker, s.IdSIZ, s.NameSIZ FROM Workers AS w, SIZ AS s) AS q " +
            "WHERE Issue.IdRecord = @id AND q.NameWorker = @issueWorker AND q.NameSIZ = @issueSIZ;";

        private string sqlDeleteCmd = "DELETE Issue WHERE IdRecord = @id;";

        public string SqlDispayCmd { get => sqlDispayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Issue() { }
    }
}
