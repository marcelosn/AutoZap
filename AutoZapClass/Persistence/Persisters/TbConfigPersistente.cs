using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using System.Data.SQLite;

namespace SQLiteBAL.Persistence.Persisters
{
    class TbConfigPersistente
    {
        public void Save(TbConfig tbconfig)
        {
            Update(tbconfig);
        }

        public void Insert(TbConfig tbconfig)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"INSERT INTO tb_config
		                (tpserver
		                ,username
		                ,password
		                ,server
		                ,port
		                ,nickname
		                ,autoresponse
		                ,httpport
		                ,empresareg
		                ,emailreg
		                ,serial
		                ,version)
	                VALUES
		                (@tpserver
		                ,@username
		                ,@password
		                ,@server
		                ,@port
		                ,@nickname
		                ,@autoresponse
		                ,@httpport
		                ,@empresareg
		                ,@emailreg
		                ,@serial
		                ,@version)";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tbconfig.tpserver));
                command.Parameters.Add(dao.CreateParameter("@username", tbconfig.username, 255));
                command.Parameters.Add(dao.CreateParameter("@password", tbconfig.password, 255));
                command.Parameters.Add(dao.CreateParameter("@server", tbconfig.server, 255));
                command.Parameters.Add(dao.CreateParameter("@port", tbconfig.port));
                command.Parameters.Add(dao.CreateParameter("@nickname", tbconfig.nickname, 50));
                command.Parameters.Add(dao.CreateParameter("@autoresponse", tbconfig.autoresponse, 255));
                command.Parameters.Add(dao.CreateParameter("@httpport", tbconfig.httpport));
                command.Parameters.Add(dao.CreateParameter("@empresareg", tbconfig.empresareg, 255));
                command.Parameters.Add(dao.CreateParameter("@emailreg", tbconfig.emailreg, 255));
                command.Parameters.Add(dao.CreateParameter("@serial", tbconfig.serial, 255));
                command.Parameters.Add(dao.CreateParameter("@version", tbconfig.version, 6));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }

        public void Update(TbConfig tbconfig)
        {
            Delete();
            Insert(tbconfig);
        }

        public void Delete()
        {
            SqlDao dao = new SqlDao();
            var _sql = @"Delete from tb_config";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }

    }
}
