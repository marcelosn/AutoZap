using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Persistence;
using SQLiteBAL.Persistence.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Services
{
    public class GrupoService : ServiceBase
    {


        public List<TbGroup> Get(bool tpserver, string groupid = "", string groupname = "")
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT groupid
		                        ,groupname
		                        ,tpserver
	                        FROM tb_group where tpserver = @tpserver ";

            if (!String.IsNullOrEmpty(groupname))
            {
                _sql += @" and groupname like @groupname + '%' ";
            }

            if (!String.IsNullOrEmpty(groupid))
            {
                _sql += @" and groupid = @groupid ";
            }

            _sql += " order by groupname asc";

            List<TbGroup> tbgroup = null;

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));

                if (!String.IsNullOrEmpty(groupname))
                    command.Parameters.Add(dao.CreateParameter("@groupname", groupname, 255));

                if (!String.IsNullOrEmpty(groupid))
                    command.Parameters.Add(dao.CreateParameter("@groupid", groupid, 255));

                tbgroup = dao.GetList<TbGroup>(command);
            }

            dao = null;

            return tbgroup;
        }

        public TbGroup GetSingle(bool tpserver, string groupid)
        {
            return this.Get(tpserver, groupid)[0];
        }

        public void Insert(TbGroup _tbgroup)
        {
            TbGroupPersistente tg = new TbGroupPersistente();
            tg.Insert(_tbgroup);
        }

        public void Update(TbGroup _tbgroup)
        {
            TbGroupPersistente tg = new TbGroupPersistente();
            tg.Update(_tbgroup);
        }

        public void Delete(TbGroup _tbgroup)
        {
            TbGroupPersistente tg = new TbGroupPersistente();
            tg.Delete(_tbgroup);
        }

        

        #region Grupo Usuario

        public class ListaContatos
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public List<ListaContatos> GetListaContatos(bool tpserver, string groupid)
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT  tc.username
	                                ,tc.nickname
                                    ,tc.tpserver 
                            FROM tb_contatos tc
                            WHERE tc.tpserver = @tpserver
	                            AND (
		                            SELECT tgc.username
		                            FROM tb_group_contatos tgc
		                            WHERE tgc.username = tc.username
		                            and tgc.tpserver = tc.tpserver
		                            and tgc.groupid = @groupid
		                            ) is null
                            ORDER BY tc.nickname ASC ";

            List<ListaContatos> listcontatos = new List<ListaContatos>();

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));
                command.Parameters.Add(dao.CreateParameter("@groupid", groupid, 255));

                List<TbContatos> tc = dao.GetList<TbContatos>(command);

                foreach (TbContatos t in tc)
                {
                    listcontatos.Add(new ListaContatos
                    {
                        Id = t.username,
                        Name = t.nickname
                    });
                }

            }

            dao = null;

            return listcontatos;
        }

        public List<ListaContatos> GetContatosGrupo(bool tpserver, string groupid)
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT tgc.username
	                            ,tc.nickname
                            FROM tb_group_contatos tgc
	                            ,tb_contatos tc
                            WHERE tgc.username = tc.username
	                            AND tgc.tpserver = @tpserver
	                            AND groupid = @groupid
                            ORDER BY tc.nickname ASC ";

            List<ListaContatos> listcontatos = new List<ListaContatos>();

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));
                command.Parameters.Add(dao.CreateParameter("@groupid", groupid, 255));

                List<TbContatos> tc = dao.GetList<TbContatos>(command);

                foreach (TbContatos t in tc)
                {
                    listcontatos.Add(new ListaContatos
                    {
                        Id = t.username,
                        Name = t.nickname
                    });
                }

            }

            dao = null;

            return listcontatos;
        }

        public void DeleteUsuarioGrupo(TbGroupContatos tbgroupcontatos)
        {
            TbGroupContatosPersistente t = new TbGroupContatosPersistente();
            t.Delete(tbgroupcontatos);
        }

        public void InsertGrupoUsuario(TbGroupContatos tbgroupcontatos)
        {
            TbGroupContatosPersistente t = new TbGroupContatosPersistente();
            t.Insert(tbgroupcontatos);
        }

        #endregion
    }
}
