using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SupplyChain.Dapper.DapperExtensions
{
    public class TransactionScopeConnections<TDatabase>
        where TDatabase : IDatabase
    {
        /// <summary>
        /// 在不同线程中，且同一个IIS请求发生时保证连接针对当前上下文为统一实例
        /// </summary>
        static readonly Dictionary<Transaction, Dictionary<string, DatabaseConnectionWrapper>> transactionConnections
            = new();

        public static DatabaseConnectionWrapper GetConnection(DapperDbContextProvider<TDatabase> db)
        {
            Transaction currentTransaction = Transaction.Current;

            if (currentTransaction == null) return null;

            //事务对象下多个db操作类型
            Dictionary<string, DatabaseConnectionWrapper> connectionList;
            DatabaseConnectionWrapper connection;

            lock (transactionConnections)
            {
                if (!transactionConnections.TryGetValue(currentTransaction, out connectionList))
                {
                    connectionList = new Dictionary<string, DatabaseConnectionWrapper>();
                    transactionConnections.Add(currentTransaction, connectionList);

                    currentTransaction.TransactionCompleted += OnTransactionCompleted;
                }
            }

            lock (connectionList)
            {
                // 线程同步
                if (!connectionList.TryGetValue(db.ConnectionString, out connection))
                {
                    var dbConnection = db.GetNewOpenConnection(true);
                    connection = new DatabaseConnectionWrapper(dbConnection);
                    connectionList.Add(db.ConnectionString, connection);
                }
            }

            return connection;
        }

        static void OnTransactionCompleted(object send, TransactionEventArgs e)
        {
            Dictionary<string, DatabaseConnectionWrapper> connectionList;

            lock (transactionConnections)
            {
                if (!transactionConnections.TryGetValue(e.Transaction, out connectionList))
                {
                    return;
                }

                transactionConnections.Remove(e.Transaction);
            }

            lock (connectionList)
            {
                foreach (var connectionWrapper in connectionList.Values)
                {
                    connectionWrapper.Dispose();
                }
                if (connectionList.Values.Count > 0)
                {

                }
            }
        }
    }
}
