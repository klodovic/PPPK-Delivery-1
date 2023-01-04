using SqlViewer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer.DAL
{
    internal class SqlRepository : IRepository
    {
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";
        private const string SelectDatabases = "SELECT name As Name FROM sys.databases";
        private const string SelectEntities = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.{1}S";
        private const string SelectProcedures = "SELECT SPECIFIC_NAME as Name, ROUTINE_DEFINITION as Definition FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";
        private const string SelectColumns = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'";
        private const string SelectProcedureParameters = "SELECT PARAMETER_NAME as Name, PARAMETER_MODE as Mode, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='{1}'";
        private const string SelectQuery = "SELECT * FROM {0}.{1}.{2}";

        private string cs;



        public void Login(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }


        public IEnumerable<Databases> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Databases
                            {
                                Name = dr["Name"].ToString()
                            };
                        }
                    }
                }
            }
        }


        public IEnumerable<DBEntity> GetDBEntities(Databases databases, DBEntityType dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format(SelectEntities, databases.Name, dBEntity.ToString());
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new DBEntity
                            {
                                Name = dr[nameof(DBEntity.Name)].ToString(),
                                Schema = dr[nameof(DBEntity.Schema)].ToString(),
                                Databases = databases
                            };
                        }
                    }
                }
            }
        }


        public IEnumerable<Procedure> GetProcedures(Databases databases)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format(SelectProcedures, databases.Name);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Procedure
                            {
                                Name = dr[nameof(Procedure.Name)].ToString(),
                                Definition = dr[nameof(Procedure.Definition)].ToString(),
                                Databases = databases
                            };
                        }
                    }
                }
            }
        }


        public IEnumerable<Column> GetDColumns(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format(SelectColumns, dBEntity.Databases.Name, dBEntity.Name);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Column
                            {
                                Name = dr[nameof(Column.Name)].ToString(),
                                DataType = dr[nameof(Column.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }



        public IEnumerable<ProceduresParams> GetParams(Procedure procedure)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format(SelectProcedureParameters, procedure.Databases.Name, procedure.Name);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new ProceduresParams
                            {
                                Name = dr[nameof(ProceduresParams.Name)].ToString(),
                                Mode = dr[nameof(ProceduresParams.Mode)].ToString(),
                                DataType = dr[nameof(ProceduresParams.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public DataSet CreateDataset(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format(SelectQuery, dBEntity.Databases.Name, dBEntity.Schema, dBEntity.Name), con);
                DataSet ds = new DataSet(dBEntity.Name);
                da.Fill(ds);
                ds.Tables[0].TableName = dBEntity.Name;
                return ds;
            }
        }

        /*
        public DataTable GetQueryResults(string query)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = query;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dr); 
                        return dataTable;
                    }
                }
            }
        }*/


        /*PROJEKTNI ZADATAK*/
        public DataTable GetQueryResults(string query, SqlInfoMessageEventHandler onInfoMessage, StatementCompletedEventHandler onStatementCompleted)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                con.InfoMessage += onInfoMessage;
                con.FireInfoMessageEventOnUserErrors = true;
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.StatementCompleted += onStatementCompleted;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dr);
                        return dataTable;
                    }
                }
            }
        }
    }
}
