using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using System.Data.SQLite;


namespace SQLiteBAL.Persistence.Persisters
{
    class TbGroupPersistente
    {
        /*public void Save(TbGroup tbgroup)
        {

        }*/

        public void Insert(TbGroup tbgroup)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"INSERT INTO tb_group
		                    (groupid
		                    ,groupname
		                    ,tpserver)
	                    VALUES
		                    (@groupid
		                    ,@groupname
		                    ,@tpserver)";
            try
            {
                using (SQLiteCommand command = dao.GetSqlCommand(_sql))
                {
                    command.Parameters.Add(dao.CreateParameter("@groupid", tbgroup.groupid, 255));
                    command.Parameters.Add(dao.CreateParameter("@groupname", tbgroup.groupname, 255));
                    command.Parameters.Add(dao.CreateParameter("@tpserver", tbgroup.tpserver));
                    dao.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("O grupo cod {0} já foi cadastrado.", tbgroup.groupid));
            }

            dao = null;
        }

        public void Update(TbGroup tbgroup)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"UPDATE tb_group
	                    SET groupname = @groupname
		                    ,tpserver = @tpserver
	                    WHERE groupid = @groupid";
            try
            {
                using (SQLiteCommand command = dao.GetSqlCommand(_sql))
                {
                    command.Parameters.Add(dao.CreateParameter("@groupid", tbgroup.groupid, 255));
                    command.Parameters.Add(dao.CreateParameter("@groupname", tbgroup.groupname, 255));
                    command.Parameters.Add(dao.CreateParameter("@tpserver", tbgroup.tpserver));
                    dao.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("O grupo cod {0} já foi cadastrado.", tbgroup.groupid));
            }

            dao = null;
        }

        public void Delete(TbGroup tbgroup)
        {
            SqlDao dao = new SqlDao();

            //Deleta os usuários
            var _sql = @"DELETE FROM tb_group_contatos
		            where groupid = @groupid";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgroup.groupid, 255));
                dao.ExecuteNonQuery(command);
            }

            //Deleta o grupo
             _sql = @"delete from tb_group where groupid = @groupid";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@groupid", tbgroup.groupid, 255));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }
    }
}
