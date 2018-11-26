using SQLiteBAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Services
{
    public abstract class ServiceBase
    {
        // SharedSqlDao
        private SqlDao _sharedSqlDao;
        public SqlDao SharedSqlDao
        {
            get
            {
                if (_sharedSqlDao == null) { _sharedSqlDao = new SqlDao(); }
                return _sharedSqlDao;
            }
            set
            {
                _sharedSqlDao = value;
            }
        }
    }
}
