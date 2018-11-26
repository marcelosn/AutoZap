using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Persistence;
using SQLiteBAL.Persistence.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Services
{
     public partial class OpcoesService : ServiceBase
    {
         public TbConfig Get()
         {
             SqlDao dao = new SqlDao();
             string _sql = "select * from tb_config";
             return dao.GetSingle<TbConfig>(dao.GetSqlCommand(_sql));
         }

         public void Post(TbConfig tbconfig)
         {
             TbConfigPersistente tb = new TbConfigPersistente();
             tb.Save(tbconfig);
         }
    }
}
