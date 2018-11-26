using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLiteBAL.Persistence.Persisters
{
    public class CreateStructs
    {
        public bool Create()
        {
            SqlDao dao = new SqlDao();

            if (!System.IO.File.Exists(dao.DatabaseFile))
            {
                SQLiteConnection.CreateFile(dao.DatabaseFile);
                
                // Prepara a base
                using (SQLiteConnection _conn = new SQLiteConnection("Data Source=" + dao.DatabaseFile + ";"))
                {
                    _conn.Open();
                    _conn.ChangePassword("cec130310");
                    _conn.Close();
                }
            }
            else { 

                return true; 
            }

            var _sql = @"CREATE TABLE IF NOT EXISTS tb_config (
                    tpserver bit NOT NULL DEFAULT 0, 
                    username varchar(255), 
                    password varchar(255), 
                    server varchar(255), 
                    port int, 
                    nickname varchar(50) NOT NULL DEFAULT 'AutoZap', 
                    autoresponse varchar(255) NOT NULL DEFAULT 'Obrigado pelo seu retorno, mas infelizmente este é um sistema autonomo de envio de mensagens, favor contatar o SAC.', 
                    httpport int, 
                    empresareg varchar(255), 
                    emailreg varchar(255), 
                    serial varchar(255), 
                    version varchar(6) NOT NULL DEFAULT '1.0.0'
                    )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);

                TbConfigPersistente tb = new TbConfigPersistente();
                tb.Save(new Common.DataShapes.TbConfig());
            }

            _sql = @"CREATE TABLE IF NOT EXISTS tb_contatos (
	                    username varchar(255) NOT NULL, 
	                    nickname varchar(255) NOT NULL, 
	                    tpserver bit NOT NULL DEFAULT 0,
	                    CONSTRAINT sqlite_autoindex_tb_contatos_1 PRIMARY KEY (username, tpserver)
                    )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }


            _sql = @"CREATE TABLE IF NOT EXISTS tb_gatilho (
	            id integer PRIMARY KEY AUTOINCREMENT, 
	            tpgatilho int NOT NULL DEFAULT 0, 
	            palavrachave varchar(255) NOT NULL
            )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }


            _sql = @"CREATE TABLE IF NOT EXISTS tb_gatilho_grupo (
	            groupid varchar(255) NOT NULL, 
	            tpserver bit NOT NULL DEFAULT 0, 
	            gatilho_id integer not null,
	            CONSTRAINT sqlite_autoindex_tb_gatilho_grupo_1 PRIMARY KEY (groupid, tpserver, gatilho_id)
            )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }

            _sql = @"CREATE TABLE IF NOT EXISTS tb_group (
	            groupid varchar(255) NOT NULL, 
	            groupname varchar(255) NOT NULL, 
	            tpserver bit NOT NULL DEFAULT 0,
	            CONSTRAINT sqlite_autoindex_tb_group_1 PRIMARY KEY (groupid, tpserver)
            )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }

            _sql = @"CREATE TABLE IF NOT EXISTS tb_group_contatos (
	            groupid varchar(255) NOT NULL, 
	            username varchar(255) NOT NULL, 
	            tpserver bit NOT NULL DEFAULT 0,
	            CONSTRAINT sqlite_autoindex_tb_group_contatos_1 PRIMARY KEY (groupid, username, tpserver)
            )";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                dao.ExecuteNonQuery(command);
            }
   
            return true;
        }

        public void Update()
        {
            SqlDao dao = new SqlDao();
            string _sql = @"select version from tb_config";

            string versao = dao.GetSingleValue<string>(dao.GetSqlCommand(_sql));

            /*
             * if (String.Compare(versao, "1.0.11") < 0)
            {
            }
             * */

            // Restrutura o Arquivo
            dao.ExecuteNonQuery(dao.GetSqlCommand("VACUUM"));
        }
    }
}
