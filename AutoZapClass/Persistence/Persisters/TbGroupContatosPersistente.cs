using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using System.Data.SQLite;


namespace SQLiteBAL.Persistence.Persisters
{
    class TbGroupContatosPersistente
    {
        public void Save(TbGroupContatos tbgroupcontatos)
        {
            Update(tbgroupcontatos);
        }

        public void Insert(TbGroupContatos tbgroupcontatos)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"INSERT INTO tb_group_contatos
		                    (groupid
		                    ,username
		                    ,tpserver)
	                    VALUES
		                    (@groupid
		                    ,@username
		                    ,@tpserver)";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgroupcontatos.groupid, 255));
                command.Parameters.Add(dao.CreateParameter("@username", tbgroupcontatos.username, 255));
                command.Parameters.Add(dao.CreateParameter("@tpserver", tbgroupcontatos.tpserver));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }

        public void Update(TbGroupContatos tbgroupcontatos)
        {
            Delete(tbgroupcontatos);
            Insert(tbgroupcontatos);
        }

        public void Delete(TbGroupContatos tbgroupcontatos)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"delete from tb_group_contatos where groupid = @groupid and username = @username and tpserver = @tpserver";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgroupcontatos.groupid, 255));
                command.Parameters.Add(dao.CreateParameter("@username", tbgroupcontatos.username, 255));
                command.Parameters.Add(dao.CreateParameter("@tpserver", tbgroupcontatos.tpserver));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }
    }
}
