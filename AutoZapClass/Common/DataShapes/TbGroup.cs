using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbGroup
    {

        /*CREATE TABLE [tb_group] (
    [groupid] varchar(255) NOT NULL, 
    [groupname] varchar(255) NOT NULL, 
    [tpserver] bit NOT NULL DEFAULT 0,
    CONSTRAINT [sqlite_autoindex_tb_group_1] PRIMARY KEY ([groupid], [tpserver])
    )*/

        public string groupid { get; set; }
        public string groupname { get; set; }
        public bool tpserver { get; set;  }

        public TbGroup()
        {
            groupid = NullValues.NullString;
            groupname = NullValues.NullString;
            tpserver = false;
        }

    }
}
