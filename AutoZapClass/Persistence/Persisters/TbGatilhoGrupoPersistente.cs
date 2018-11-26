using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using System.Data.SQLite;


namespace SQLiteBAL.Persistence.Persisters
{
    class TbGatilhoGrupoPersistente
    {
        public void Save(TbGatilhoGrupo tbgatilhogrupo)
        {
            Update(tbgatilhogrupo);
        }

        public void Insert(TbGatilhoGrupo tbgatilhogrupo)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"INSERT INTO tb_gatilho_grupo
		                    (groupid
		                    ,tpserver
		                    ,gatilho_id)
	                    VALUES
		                    (@groupid
		                    ,@tpserver
		                    ,@gatilho_id)";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgatilhogrupo.groupid, 255));
                command.Parameters.Add(dao.CreateParameter("@tpserver", tbgatilhogrupo.tpserver));
                command.Parameters.Add(dao.CreateParameter("@gatilho_id", tbgatilhogrupo.gatilho_id));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }

        public void Update(TbGatilhoGrupo tbgatilhogrupo)
        {
            Delete(tbgatilhogrupo);
            Insert(tbgatilhogrupo);
        }

        public void Delete(TbGatilhoGrupo tbgatilhogrupo)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"delete from tb_gatilho_grupo where groupid = @groupid and tpserver = @tpserver and gatilho_id = @gatilho_id";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgatilhogrupo.groupid, 255));
                command.Parameters.Add(dao.CreateParameter("@tpserver", tbgatilhogrupo.tpserver));
                command.Parameters.Add(dao.CreateParameter("@gatilho_id", tbgatilhogrupo.gatilho_id));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }
    }
}
