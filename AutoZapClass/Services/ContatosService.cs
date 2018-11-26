using SQLiteBAL.Common;
using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Persistence;
using SQLiteBAL.Persistence.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Services
{
    public class ContatosService : ServiceBase
    {
        public List<TbContatos> Get(bool tpserver, string username = "", string nickname = "")
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT username
		                        ,nickname
		                        ,tpserver
	                        FROM tb_contatos where tpserver = @tpserver ";

            if (!String.IsNullOrEmpty(username))
            {
                _sql += " and username = @username ";
            }

            if (!String.IsNullOrEmpty(nickname))
            {
                _sql += " and nickname like @nickname + '%' ";
            }

            _sql += " order by nickname asc";

            List<TbContatos> tbcontatos = null;

            using(System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql)){
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));
               
                if (!String.IsNullOrEmpty(username))
                    command.Parameters.Add(dao.CreateParameter("@username", username, 255));

                if (!String.IsNullOrEmpty(nickname))
                    command.Parameters.Add(dao.CreateParameter("@nickname", nickname, 255));

                tbcontatos = dao.GetList<TbContatos>(command);
            }

            dao = null;

            return tbcontatos;
        }

        public TbContatos GetSingle(bool tpserver, string username)
        {
            return this.Get(tpserver, username)[0];
        }

        public void Insert(TbContatos _tbcontatos)
        {
            TbContatosPersistente tc = new TbContatosPersistente();
            tc.Insert(_tbcontatos);
        }

        public void Update(TbContatos _tbcontatos)
        {
            TbContatosPersistente tc = new TbContatosPersistente();
            tc.Update(_tbcontatos);
        }

        public void Delete(TbContatos _tbcontatos)
        {
            TbContatosPersistente tc = new TbContatosPersistente();
            tc.Delete(_tbcontatos);
        }

    }
}
