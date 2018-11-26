﻿using SQLiteBAL.Common.DataShapes;
using System;
using System.Data;

namespace SQLiteBAL.Persistence.DataMappers
{
    class TbGroupMapper : IDataMapper
    {
        private bool _isInitialized = false;

        private int _ordinal_groupid;
        private int _ordinal_groupname;
        private int _ordinal_tpserver;

        private void InitializeMapper(IDataReader reader)
        {
            PopulateOrdinals(reader);
            _isInitialized = true;
        }

        //get dados ordenacao
        public void PopulateOrdinals(IDataReader reader)
        {
            _ordinal_groupid = reader.GetOrdinal("groupid");
            _ordinal_groupname = reader.GetOrdinal("groupname");
            _ordinal_tpserver = reader.GetOrdinal("tpserver");

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
            TbGroup dto = new TbGroup();

            // Now we can load the data

            if (!reader.IsDBNull(_ordinal_groupid)) { dto.groupid = reader.GetString(_ordinal_groupid); }
            if (!reader.IsDBNull(_ordinal_groupname)) { dto.groupname = reader.GetString(_ordinal_groupname); }
            if (!reader.IsDBNull(_ordinal_tpserver)) { dto.tpserver = reader.GetBoolean(_ordinal_tpserver); }

            return dto;
        }


        public int GetRecordCount(IDataReader reader)
        {
            Object count = reader["RecordCount"];
            return count == null ? 0 : Convert.ToInt32(count);
        }
    }
}
