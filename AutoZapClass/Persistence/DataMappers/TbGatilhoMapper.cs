using SQLiteBAL.Common.DataShapes;
using System;
using System.Data;

namespace SQLiteBAL.Persistence.DataMappers
{
    class TbGatilhoMapper : IDataMapper
    {
        private bool _isInitialized = false;

        private int _ordinal_id;
        private int _ordinal_tpgatilho;
        private int _ordinal_palavrachave;

        private void InitializeMapper(IDataReader reader)
        {
            PopulateOrdinals(reader);
            _isInitialized = true;
        }

        //get dados ordenacao
        public void PopulateOrdinals(IDataReader reader)
        {
            _ordinal_id = reader.GetOrdinal("id");
            _ordinal_tpgatilho = reader.GetOrdinal("tpgatilho");
            _ordinal_palavrachave = reader.GetOrdinal("palavrachave");

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
            TbGatilho dto = new TbGatilho();

            // Now we can load the data

            if (!reader.IsDBNull(_ordinal_id)) { dto.id = reader.GetInt32(_ordinal_id); }
            if (!reader.IsDBNull(_ordinal_tpgatilho)) { dto.tpgatilho = reader.GetInt16(_ordinal_tpgatilho); }
            if (!reader.IsDBNull(_ordinal_palavrachave)) { dto.palavrachave = reader.GetString(_ordinal_palavrachave); }

            return dto;
        }


        public int GetRecordCount(IDataReader reader)
        {
            Object count = reader["RecordCount"];
            return count == null ? 0 : Convert.ToInt32(count);
        }
    }
}
