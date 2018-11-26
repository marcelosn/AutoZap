using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbGatilho
    {
        
        /*CREATE TABLE [tb_gatilho] (
	[id] integer NOT NULL PRIMARY KEY AUTOINCREMENT, 
	[tpgatilho] int NOT NULL DEFAULT 0, 
	[palavrachave] varchar(255) NOT NULL
    )*/
        public long id { get; set; }
        public int tpgatilho { get; set; }
        public string palavrachave { get; set; }

        public TbGatilho()
        {
            id = NullValues.NullInt;
            tpgatilho = 0;
            palavrachave = NullValues.NullString;
        }

    }
}
