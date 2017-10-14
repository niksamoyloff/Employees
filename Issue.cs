using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Issue : DataOperations
    {
        private string sqlDispayCmd = "SELECT i.IdRecord, " +
                                             "w.NameWorker 'ФИО работника', " +
                                             "s.NameSIZ 'СИЗ / Прибор', " +
                                             "s.TypeOfSIZ 'Тип', " +
                                             "i.DateOfIssueSIZ 'Дата выдачи', " +
                                             "s.WorkabilitySIZ 'Годность', " +
                                             "i.Notation 'Примечание' " +
                                      "FROM Issue AS i, Workers AS w, SIZ AS s " +
                                      "WHERE i.IdWorker = w.IdWorker AND i.IdSIZ = s.IdSIZ";

        private string sqlInsertCmd = "INSERT INTO Issue(IdWorker, IdSIZ, IdTypeOfSIZ, DateOfIssueSIZ, Notation) " +
                                      "VALUES ((SELECT IdWorker FROM Workers WHERE NameWorker = @issueWorker), " +
                                              "(SELECT IdSIZ FROM SIZ WHERE NameSIZ = @issueSIZ), " +
                                              "(SELECT IdSIZ FROM SIZ WHERE TypeOfSIZ = @typeOfSIZ), " +
                                              "CONVERT(date, @issueDate, 104), @issueNotation);";

        private string sqlUpdateCmd = "UPDATE Issue " +
                                      "SET IdWorker = q.IdWorker, " +
                                          "IdSIZ = q.IdSIZ, " +
                                          "IdTypeOfSIZ = q.IdSIZ, " +
                                          "DateOfIssueSIZ = CONVERT(date, @issueDate, 104), " +
                                          "Notation = @issueNotation " +
                                      "FROM (SELECT w.IdWorker, w.NameWorker, s.IdSIZ, s.NameSIZ, s.TypeOfSIZ FROM Workers AS w, SIZ AS s) AS q " +
                                      "WHERE Issue.IdRecord = @id AND q.NameWorker = @issueWorker AND q.NameSIZ = @issueSIZ AND q.TypeOfSIZ = @typeOfSIZ;";

        private string sqlDeleteCmd = "DELETE Issue WHERE IdRecord = @id;";

        public string SqlDispayCmd { get => sqlDispayCmd; }
        public string SqlInsertCmd { get => sqlInsertCmd; }
        public string SqlUpdateCmd { get => sqlUpdateCmd; }
        public string SqlDeleteCmd { get => sqlDeleteCmd; }

        public Issue() { }
    }
}
