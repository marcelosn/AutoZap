using System;
using System.Collections.Generic;

namespace SQLiteBAL.Common.DataShapes
{
    public class TbConfig
    {

         public bool tpserver { get; set; }
	     public string username { get; set; }
	     public string password { get; set; }
	     public string server { get; set; }
	     public int port { get; set; }
	     public string nickname { get; set; }
	     public string autoresponse { get; set; }
	     public int httpport { get; set; } 
	     public string empresareg { get; set; }
	     public string emailreg { get; set; }
	     public string serial { get; set; }
         public string version { get; set; }

         public TbConfig()
         {
             tpserver = false;
             username = NullValues.NullString;
             password = NullValues.NullString;
             server = NullValues.NullString;
             port = NullValues.NullInt;
             nickname = "AutoZap";
             autoresponse = "Obrigado pelo seu retorno, mas infelizmente este é um sistema autonomo de envio de mensagens, favor contatar o SAC.";
             httpport = 8086;
             empresareg = NullValues.NullString;
             emailreg = NullValues.NullString;
             serial = NullValues.NullString;
             version = SQLiteBAL.Persistence.SqlDao.versao;
         }

    }
}
