using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbGatilhoGrupo
    {

            /*
    CREATE TABLE [tb_gatilho_grupo] (
	    [groupid] varchar(255) NOT NULL, 
	    [tpserver] bit NOT NULL DEFAULT 0, 
	    [gatilho_id] integer NOT NULL AUTOINCREMENT,
	    CONSTRAINT [sqlite_autoindex_tb_gatilho_grupo_1] PRIMARY KEY ([groupid], [tpserver], [gatilho_id])
    )*/

        public string groupid { get; set; }
        public bool tpserver { get; set; }
        public long gatilho_id { get; set; }

        public TbGatilhoGrupo()
        {
            groupid = NullValues.NullString;
            tpserver = false;
            gatilho_id = NullValues.NullInt;
        }

    }
}
