using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using System.Data.SQLite;

namespace SQLiteBAL.Persistence.Persisters
{
    class TbContatosPersistente
    {
        /*public void Save(TbContatos tbcontatos)
        {
            if (!String.IsNullOrEmpty(tbcontatos.username))
            {
                try
                {
                    Insert(tbcontatos);
                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("O usuário {0} já foi cadastrado.", tbcontatos.username));
                }                
            }
        }*/

        public void Insert(TbContatos tbcontatos)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"INSERT INTO tb_contatos
		                (username
		                ,nickname
		                ,tpserver)
	                VALUES
		                (@username
		                ,@nickname
		                ,@tpserver)";
            try
            {
                using (SQLiteCommand command = dao.GetSqlCommand(_sql))
                {
                    command.Parameters.Add(dao.CreateParameter("@username", tbcontatos.username, 255));
                    command.Parameters.Add(dao.CreateParameter("@nickname", tbcontatos.nickname, 255));
                    command.Parameters.Add(dao.CreateParameter("@tpserver", tbcontatos.tpserver));
                    dao.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("O usuário {0} já foi cadastrado.", tbcontatos.username));
            }

            dao = null;
        }

        public void Update(TbContatos tbcontatos)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"UPDATE tb_contatos
	                    SET nickname = @nickname
		                    ,tpserver = @tpserver
	                    WHERE username = @username";
            try
            {
                using (SQLiteCommand command = dao.GetSqlCommand(_sql))
                {
                    command.Parameters.Add(dao.CreateParameter("@username", tbcontatos.username, 255));
                    command.Parameters.Add(dao.CreateParameter("@nickname", tbcontatos.nickname, 255));
                    command.Parameters.Add(dao.CreateParameter("@tpserver", tbcontatos.tpserver));
                    dao.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex) {

                throw new Exception(String.Format("O usuário {0} já foi cadastrado.", tbcontatos.username));

            }

            dao = null;
        }

        public void Delete(TbContatos tbcontatos)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"DELETE FROM tb_contatos
                    		WHERE username = @username";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@username", tbcontatos.username, 255));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }
    }
}
