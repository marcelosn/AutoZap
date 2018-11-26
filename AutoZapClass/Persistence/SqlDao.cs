using SQLiteBAL.Common;
using SQLiteBAL.Persistence.DataMappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SQLiteBAL.Persistence
{
    public class SqlDao
    {
        // Variaveis do db
        static string CurrPath = AppDomain.CurrentDomain.BaseDirectory;       
        static string nmdatabase = CurrPath + @"\data.db";
        static string conexao = "Data Source=" + nmdatabase + ";Password=cec130310;";        
        public static string versao = "1.0.0";

        public string DatabaseFile { get { return nmdatabase; } }

        #region "Database Helper Methods"

        //Conexao
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get
            {
                if(_conn == null)
                {
                    _conn = new SQLiteConnection(conexao);
                }

                return _conn;
            }

            set
            {
                _conn = value;
            }
        }


        // Construttor
        public SqlDao() { }
        public SqlDao(SQLiteConnection conn)
        {
            this.Conn = conn;
        }

        // GetDbSqlCommand
        public SQLiteCommand GetSqlCommand(string sqlQuery)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = Conn;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sqlQuery;
            return command;
        }

        // GetDbSprocCommand
        public SQLiteCommand GetSprocCommand(string sprocName)
        {
            SQLiteCommand command = new SQLiteCommand(sprocName);
            command.Connection = Conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }

        // CreateNullParameter
        public SQLiteParameter CreateNullParameter(string name, DbType paramType)
        {
            SQLiteParameter parameter = new SQLiteParameter();
            parameter.DbType = paramType;
            parameter.ParameterName = name;
            parameter.Value = null;
            parameter.Direction = ParameterDirection.Input;
            return parameter;
        }


        // CreateNullParameter - with size for nvarchars
        public SQLiteParameter CreateNullParameter(string name, DbType paramType, int size)
        {
            SQLiteParameter parameter = new SQLiteParameter();
            parameter.DbType = paramType;
            parameter.ParameterName = name;
            parameter.Size = size;
            parameter.Value = null;
            parameter.Direction = ParameterDirection.Input;
            return parameter;
        }


        // CreateOutputParameter
        public  SQLiteParameter CreateOutputParameter(string name, DbType paramType)
        {
            SQLiteParameter parameter = new SQLiteParameter();
            parameter.DbType = paramType;
            parameter.ParameterName = name;
            parameter.Direction = ParameterDirection.Output;
            return parameter;
        }


        // CreateOuputParameter - with size for nvarchars
        public  SQLiteParameter CreateOutputParameter(string name, DbType paramType, int size)
        {
            SQLiteParameter parameter = new SQLiteParameter();
            parameter.DbType = paramType;
            parameter.Size = size;
            parameter.ParameterName = name;
            parameter.Direction = ParameterDirection.Output;
            return parameter;
        }


        // CreateParameter - uniqueidentifier
        public  SQLiteParameter CreateParameter(string name, Guid value)
        {
            if (value.Equals(NullValues.NullGuid))
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Guid);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Guid;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }


        // CreateParameter - int
        public  SQLiteParameter CreateParameter(string name, int value)
        {
            if (value == NullValues.NullInt)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Int32);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Int32;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }


        // CreateParameter - datetime
        public  SQLiteParameter CreateParameter(string name, DateTime value)
        {
            if (value == NullValues.NullDateTime)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.DateTime);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.DateTime;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - bool
        public SQLiteParameter CreateParameter(string name, bool? value)
        {
            if (value == null)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Boolean);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Boolean;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - decimal
        public SQLiteParameter CreateParameter(string name, decimal value)
        {
            if (value == NullValues.NullDecimal)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Decimal);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Decimal;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - long
        public SQLiteParameter CreateParameter(string name, long value)
        {
            if (value == NullValues.NullDecimal)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Int64);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Int64;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }


        // CreateParameter - double
        public SQLiteParameter CreateParameter(string name, double value)
        {
            if (value == NullValues.NullDouble)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.Double);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.Double;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - nvarchar
        public SQLiteParameter CreateParameter(string name, string value, int size)
        {
            if (String.IsNullOrEmpty(value))
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, DbType.StringFixedLength);
            }
            else
            {
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.StringFixedLength;
                parameter.Size = size;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        #endregion

        #region "Data Projection Methods"

        // ExecuteNonQuery
        public int ExecuteNonQuery(SQLiteCommand command)
        {
            int ret = -1;

            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                ret = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error executing query", e);
            }
            finally
            {
                command.Connection.Close();               
            }

            return ret;
            
        }

        //consulta Reader
        public SQLiteDataReader ExecuteReader(SQLiteCommand command)
        {
            SQLiteDataReader ret = null;

            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                ret = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception("Error executing query", e);
            }
           

            return ret;
        }

        // ExecuteScalar
        public Object ExecuteScalar(SQLiteCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                return command.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception("Error executing query", e);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // GetSingleValue
        public T GetSingleValue<T>(SQLiteCommand command)
        {
            T returnValue = default(T);
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0)) { returnValue = (T)reader[0]; }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
            }
            return returnValue;
        }

        // GetStringList
        public List<string> GetStringList(SQLiteCommand command)
        {
            List<string> returnList = null;
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    returnList = new List<string>();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0)) { returnList.Add(reader.GetString(0)); }
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
            }
            return returnList;
        }

        // GetSingle
        public T GetSingle<T>(SQLiteCommand command) where T : class
        {
            T dto = null;
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    IDataMapper mapper = new DataMapperFactory().GetMapper(typeof(T));
                    dto = (T)mapper.GetData(reader);
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
            }
            // return the DTO, it's either populated with data or null.
            return dto;
        }

        // GetList
        public List<T> GetList<T>(SQLiteCommand command) where T : class
        {
            List<T> dtoList = new List<T>();
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IDataMapper mapper = new DataMapperFactory().GetMapper(typeof(T));
                    while (reader.Read())
                    {
                        T dto = null;
                        dto = (T)mapper.GetData(reader);
                        dtoList.Add(dto);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
            }
            // We return either the populated list if there was data,
            // or if there was no data we return an empty list.
            return dtoList;
        }
       
        #endregion

    }
}
