using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper.DapperExtensions
{
    public class Database : IDatabase
    {
        private IDbTransaction transaction;

        public IDbConnection Connection { get; private set; }


        public IDbTransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            transaction = Connection.BeginTransaction(isolationLevel);
            return transaction;
        }

        public void Commit()
        {
            transaction.Commit();
            transaction.Dispose();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            transaction = null;
        }

        public void Rollback()
        {
            transaction.Rollback();
            transaction.Dispose();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            transaction = null;
        }

        public void SetConnection(IDbConnection dbConnection)
        {
            Connection = dbConnection;
        }
    }
}
