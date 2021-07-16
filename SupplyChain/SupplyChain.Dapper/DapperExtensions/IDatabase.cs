using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper.DapperExtensions
{
    public interface IDatabase
    {

        IDbConnection Connection { get; }

        /// <summary>
        /// 设置数据库连接
        /// </summary>
        /// <param name="dbConnection"></param>
        void SetConnection(IDbConnection dbConnection);

    }
}
