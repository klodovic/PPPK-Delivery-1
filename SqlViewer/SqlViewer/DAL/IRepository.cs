using SqlViewer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlViewer.DAL
{
    public interface IRepository
    {
        IEnumerable<Databases> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Databases databases, DBEntityType dBEntity);
        IEnumerable<Column> GetDColumns(DBEntity dBEntity);
        IEnumerable<ProceduresParams> GetParams(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Databases databases);
        void Login(string server, string username, string password);
        DataSet CreateDataset(DBEntity dBEntity);
        //DataTable GetQueryResults(string query);
        DataTable GetQueryResults(string query, SqlInfoMessageEventHandler onInfoMessage, StatementCompletedEventHandler onStatementCompleted);

    }
}