using SQLiteBAL.Common.DataShapes;
using System;
using System.Data;

namespace SQLiteBAL.Persistence.DataMappers
{
    class TbConfigMapper : IDataMapper
    {

        private bool   _isInitialized = false;

        private int  _ordinal_tpserver;
        private int  _ordinal_username;
        private int  _ordinal_password;
        private int  _ordinal_server;
        private int  _ordinal_port;
        private int  _ordinal_nickname;
        private int  _ordinal_autoresponse;
        private int  _ordinal_httpport;
        private int  _ordinal_empresareg;
        private int  _ordinal_emailreg;
        private int  _ordinal_serial;
        private int  _ordinal_version;
                       
        private void InitializeMapper(IDataReader reader)
        {
            PopulateOrdinals(reader);
            _isInitialized = true;
        }


        //get dados ordenacao
        public void PopulateOrdinals(IDataReader reader)
        {
            _ordinal_tpserver = reader.GetOrdinal("tpserver");
            _ordinal_username = reader.GetOrdinal("username");
            _ordinal_password = reader.GetOrdinal("password");
            _ordinal_server = reader.GetOrdinal("server");
            _ordinal_port = reader.GetOrdinal("port");
            _ordinal_nickname = reader.GetOrdinal("nickname");
            _ordinal_autoresponse = reader.GetOrdinal("autoresponse");
            _ordinal_httpport = reader.GetOrdinal("httpport");
            _ordinal_empresareg = reader.GetOrdinal("empresareg");
            _ordinal_emailreg = reader.GetOrdinal("emailreg");
            _ordinal_serial = reader.GetOrdinal("serial");
            _ordinal_version = reader.GetOrdinal("version");
        }

        public Object GetData(IDataReader reader)
        {
            // This is where we define the mapping between the object properties and the 
            // data columns. The convention that should be used is that the object property 
            // names are exactly the same as the column names. However if there is some 
            // compelling reason for the names to be different the mapping can be defined here.

            // We assume the reader has data and is already on the row that contains the data 
            //we need. We don't need to call read. As a general rule, assume that every field must 
            //be null  checked. If a field is null then the nullvalue for that  field has already 
            //been set by the DTO constructor, we don't have to change it.

            if (!_isInitialized) { InitializeMapper(reader); }
            TbConfig dto = new TbConfig();
            
            // Now we can load the data

            if (!reader.IsDBNull(_ordinal_tpserver)) { dto.tpserver = reader.GetBoolean(_ordinal_tpserver); }
            if (!reader.IsDBNull(_ordinal_username)) { dto.username = reader.GetString(_ordinal_username); }
            if (!reader.IsDBNull(_ordinal_password)) { dto.password = reader.GetString(_ordinal_password); }
            if (!reader.IsDBNull(_ordinal_server)) { dto.server = reader.GetString(_ordinal_server); }
            if (!reader.IsDBNull(_ordinal_port)) { dto.port = reader.GetInt16(_ordinal_port); }
            if (!reader.IsDBNull(_ordinal_nickname)) { dto.nickname = reader.GetString(_ordinal_nickname); }
            if (!reader.IsDBNull(_ordinal_autoresponse)) { dto.autoresponse = reader.GetString(_ordinal_autoresponse); }
            if (!reader.IsDBNull(_ordinal_httpport)) { dto.httpport = reader.GetInt16(_ordinal_httpport); }
            if (!reader.IsDBNull(_ordinal_empresareg)) { dto.empresareg = reader.GetString(_ordinal_empresareg); }
            if (!reader.IsDBNull(_ordinal_emailreg)) { dto.emailreg = reader.GetString(_ordinal_emailreg); }
            if (!reader.IsDBNull(_ordinal_serial)) { dto.serial = reader.GetString(_ordinal_serial); }
            if (!reader.IsDBNull(_ordinal_version)) { dto.version = reader.GetString(_ordinal_version); }
            return dto;
        }


        public int GetRecordCount(IDataReader reader)
        {
            Object count = reader["RecordCount"];
            return count == null ? 0 : Convert.ToInt32(count);
        }

    }
}
