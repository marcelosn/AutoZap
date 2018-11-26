using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Persistence;
using SQLiteBAL.Persistence.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SQLiteBAL.Services
{
    public class GatilhoService
    {
        
        public List<TbGatilho> Get(long id = 0, string palavrachave = "")
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT id
	                            ,tpgatilho
	                            ,palavrachave
                            FROM tb_gatilho ";

            if (id != 0)
            {
                _sql = @"select * from (" + _sql + ") a where a.id = @id ";
            }

            if (!String.IsNullOrEmpty(palavrachave))
            {
                _sql = @"select * from ("+ _sql +") b where b.palavrachave like @palavrachave + '%' ";
            }


            _sql += " order by palavrachave asc";

            List<TbGatilho> tbgatilho = null;

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                if (id != 0)
                    command.Parameters.Add(dao.CreateParameter("@id", id));

                if (!String.IsNullOrEmpty(palavrachave))
                    command.Parameters.Add(dao.CreateParameter("@palavrachave", palavrachave, 255));

                tbgatilho = dao.GetList<TbGatilho>(command);
            }

            dao = null;

            return tbgatilho;
        }

        public TbGatilho GetSingle(long id = 0, string palavrachave = "")
        {
            return this.Get(id, palavrachave)[0];
        }

        public long Insert(TbGatilho _tbgatilho)
        {
            TbGatilhoPersistente tg = new TbGatilhoPersistente();
            return tg.Insert(_tbgatilho);
        }

        public void Update(TbGatilho _tbgatilho)
        {
            TbGatilhoPersistente tg = new TbGatilhoPersistente();
            tg.Update(_tbgatilho);
        }

        public void Delete(TbGatilho _tbgatilho)
        {
            TbGatilhoPersistente tg = new TbGatilhoPersistente();
            tg.Delete(_tbgatilho);
        }

        #region Gatilho Grupo

        public class ListaGrupos
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
                

        public List<ListaGrupos> GetListaGrupos(bool tpserver, long gatilho_id)
        {
            SqlDao dao = new SqlDao();
            string _sql = @"SELECT tg.groupid
	                            ,tg.groupname
                                ,tg.tpserver
                            FROM tb_group tg
                            WHERE tg.tpserver = 0
	                            AND (
		                            SELECT tgg.groupid
		                            FROM tb_gatilho_grupo tgg
		                            WHERE tgg.tpserver = tg.tpserver
			                            AND gatilho_id = @gatilho_id
			                            AND tgg.groupid = tg.groupid
		                            ) IS NULL
                            ORDER BY tg.groupname ASC ";

            List<ListaGrupos> listagrupos = new List<ListaGrupos>();

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));
                command.Parameters.Add(dao.CreateParameter("@gatilho_id", gatilho_id));

                List<TbGroup> tc = dao.GetList<TbGroup>(command);

                foreach (TbGroup t in tc)
                {
                    listagrupos.Add(new ListaGrupos
                    {
                        Id = t.groupid,
                        Name = t.groupname
                    });
                }

            }

            dao = null;

            return listagrupos;
        }

        public List<ListaGrupos> GetListaGruposSel(bool tpserver, long gatilho_id)
        {
            SqlDao dao = new SqlDao();
            string _sql = @"select * from (SELECT groupid
		                        ,(select t.groupname from tb_group t where t.groupid = tb_gatilho_grupo.groupid) as groupname
		                        ,tpserver		                       
	                        FROM tb_gatilho_grupo
	                        where gatilho_id = @gatilhoid and tpserver = @tpserver) tg
                            ORDER BY tg.groupname ASC ";

            List<ListaGrupos> listagrupos = new List<ListaGrupos>();

            using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpserver", tpserver));
                command.Parameters.Add(dao.CreateParameter("@gatilhoid", gatilho_id));

                List<TbGroup> tc = dao.GetList<TbGroup>(command);

                foreach (TbGroup t in tc)
                {
                    listagrupos.Add(new ListaGrupos
                    {
                        Id = t.groupid,
                        Name = t.groupname
                    });
                }

            }

            dao = null;

            return listagrupos;
        }

        public void DeleteGrupoGatilho(TbGatilhoGrupo tbgatilhogrupo)
        {
            TbGatilhoGrupoPersistente t = new TbGatilhoGrupoPersistente();
            t.Delete(tbgatilhogrupo);
        }

        public void InsertGrupoGatilho(TbGatilhoGrupo tbgatilhogrupo)
        {
            TbGatilhoGrupoPersistente t = new TbGatilhoGrupoPersistente();
            t.Insert(tbgatilhogrupo);
        }

        #endregion
    }
}
