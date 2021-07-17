using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper.DapperExtensions
{
    public class DatabaseConnectionWrapper : IDisposable
    {
        public DbConnection Connection { get; private set; }

        public DatabaseConnectionWrapper(DbConnection connection)
        {
            Connection = connection;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "As designed. This is a reference counting disposable.")]
        public void Dispose()
        {
            Dispose(true);
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "As designed. This is a reference counting disposable.")]
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
                Connection.Dispose();
                Connection = null;
                GC.SuppressFinalize(this);
            }
        }
    }
}
