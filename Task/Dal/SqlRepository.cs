using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Dal
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

        public void LogIn(string server, string username, string password)
        {
            string css = string.Format(ConnectionString, server, username, password);
            using (SqlConnection con = new SqlConnection(css))
            {
                con.Open();
                cs = css;
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectEntities, database.Name, dBEntity.ToString());
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new DBEntity
                            {
                                Name = dr[nameof(DBEntity.Name)].ToString(),
                                Schema = dr[nameof(DBEntity.Schema)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Procedure> GetProcedures(Database database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedures, database.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Procedure
                            {
                                Name = dr[nameof(Procedure.Name)].ToString(),
                                Definition = dr[nameof(Procedure.Definition)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Column> GetColumns(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectColumns, dBEntity.Database.Name, dBEntity.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Column
                            {
                                Name = dr[nameof(Column.Name)].ToString(),
                                DataType = dr[nameof(Column.DataType)].ToString(),
                            };
                        }
                    }
                }
            }
        }


        public IEnumerable<ProcedureParams> GetParams(Procedure procedure)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedureParameters, procedure.Database.Name, procedure.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new ProcedureParams
                            {
                                Name = dr[nameof(ProcedureParams.Name)].ToString(),
                                DataType = dr[nameof(ProcedureParams.DataType)].ToString(),
                                Mode = dr[nameof(ProcedureParams.Mode)].ToString()
                            };
                        }
                    }
                }
            }
        }
        public QueryResult GetQueryResults(string command, string database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.FireInfoMessageEventOnUserErrors = true;
                con.StatisticsEnabled = true;
                con.InfoMessage += Con_InfoMessage;
                con.Open();
                con.ChangeDatabase(database);
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = command;
                    cmd.CommandType = System.Data.CommandType.Text;
                    int affectedRows = cmd.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        
                        DataTable dt = new DataTable();
                        if (affectedRows <= 0)
                        {
                            affectedRows = da.Fill(dt);
                        }
                        
                        //var str = con.RetrieveStatistics();
                        string message = String.Format($"({affectedRows} rows(s) affected)");
                        return new QueryResult {DataTable = dt, Message = infoMessage, OnCompleteMessage = message};
                    }
                }
              
            }
        }



        private string infoMessage;
        private void Con_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            infoMessage = e.Message;
        }
    }
}
