using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbContatos
    {
        /*CREATE TABLE [tb_contatos] (
	[username] varchar(255) NOT NULL, 
	[nickname] varchar(255) NOT NULL, 
	[tpserver] bit NOT NULL DEFAULT 0,
	CONSTRAINT [sqlite_autoindex_tb_contatos_1] PRIMARY KEY ([username], [tpserver])
    )*/

        public string username { get; set; }
        public string nickname { get; set; }
        public bool tpserver { get; set; }

        public TbContatos()
        {

            username = NullValues.NullString;
            nickname = NullValues.NullString;
            tpserver = false;
        }
    }
}
