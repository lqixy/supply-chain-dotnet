using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper.DapperExtensions
{
    public class DapperDbContextProvider<TDatabase>
        : IDbContextProvider<TDatabase>
        where TDatabase : IDatabase
    {
        public TDatabase DbContext { get; private set; }

        public DapperDbContextProvider(TDatabase dbContext, IDbProviderFactory dbProviderFactory)
        {
            DbContext = dbContext;
            this.dbProviderFactory = dbProviderFactory ?? throw new ArgumentNullException(nameof(dbProviderFactory));
            ConnectionString = dbProviderFactory.ConnectionString;
        }

        public IDbProviderFactory dbProviderFactory { get; private set; }

        public string ConnectionString { get; private set; }

        // TODO
        public TDatabase GetDbContext()
        {
            var connectionWrapper = GetOpenConnection();
            DbContext.SetConnection(connectionWrapper.Connection);
            return DbContext;
        }


        protected DatabaseConnectionWrapper GetOpenConnection()
        {
            DatabaseConnectionWrapper connection =
                TransactionScopeConnections<TDatabase>.GetConnection(this);

            //var connectionWrapper = connection ?? GetNewOpenConnection();
            return connection;
        }

        internal DbConnection GetNewOpenConnection(bool isOpen = false)
        {
            DbConnection connection = null;

            try
            {
                connection = CreateConnection();
                if (isOpen) connection.Open();
            }
            catch
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                throw;
            }
            return connection;
        }

        private DbConnection CreateConnection()
        {
            DbConnection newConnection = dbProviderFactory.DbFactory.CreateConnection();
            newConnection.ConnectionString = dbProviderFactory.ConnectionString;
            return newConnection;
        }
    }
}
