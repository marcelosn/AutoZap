using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbGroupContatos
    {
        /*
        * CREATE TABLE [tb_group_contatos] (
        [groupid] varchar(255) NOT NULL, 
        [username] varchar(255) NOT NULL, 
        [tpserver] bit NOT NULL DEFAULT 0,
        CONSTRAINT [sqlite_autoindex_tb_group_contatos_1] PRIMARY KEY ([groupid], [username], [tpserver])
        )*/

        public string groupid { get; set; }
        public string username { get; set; }
        public bool tpserver { get; set; }

        public TbGroupContatos()
        {
            groupid = NullValues.NullString;
            username = NullValues.NullString;
            tpserver = false;
        }
    }
}
