using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Common;
using System.Data.SQLite;

namespace SQLiteBAL.Persistence.Persisters
{
    class TbGatilhoPersistente
    {
        public void Save(TbGatilho tbgatilho)
        {
            if (tbgatilho.id == NullValues.NullInt)
            {
                Insert(tbgatilho);
            }
            else
            {
                Update(tbgatilho);
            }
        }

        public long Insert(TbGatilho tbgatilho)
        {
            SqlDao dao = new SqlDao();
            Int64 ret = 0;

            var _sql = @"INSERT INTO tb_gatilho
		                    (tpgatilho
		                    ,palavrachave)
	                    VALUES
		                    (@tpgatilho
		                    ,@palavrachave)";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@tpgatilho", tbgatilho.tpgatilho));
                command.Parameters.Add(dao.CreateParameter("@palavrachave", tbgatilho.palavrachave, 255));
                dao.ExecuteNonQuery(command);

                 
            }

            _sql = @"SELECT seq
	                FROM sqlite_sequence where name = 'tb_gatilho'";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                ret = dao.GetSingleValue<Int64>(command);
            }
            
            dao = null;

            return ret;
        }

        public void Update(TbGatilho tbgatilho)
        {
            SqlDao dao = new SqlDao();

            var _sql = @"UPDATE tb_gatilho
	                    SET tpgatilho = @tpgatilho
		                    ,palavrachave = @palavrachave
	                    WHERE id = @id";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@id", tbgatilho.id));
                command.Parameters.Add(dao.CreateParameter("@tpgatilho", tbgatilho.tpgatilho));
                command.Parameters.Add(dao.CreateParameter("@palavrachave", tbgatilho.palavrachave, 255));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }

        public void Delete(TbGatilho tbgatilho)
        {
            SqlDao dao = new SqlDao();

            var _sql = "delete from tb_gatilho where id = @id";

            using (SQLiteCommand command = dao.GetSqlCommand(_sql))
            {
                command.Parameters.Add(dao.CreateParameter("@id", tbgatilho.id));
                dao.ExecuteNonQuery(command);
            }

            dao = null;
        }
    }
}
