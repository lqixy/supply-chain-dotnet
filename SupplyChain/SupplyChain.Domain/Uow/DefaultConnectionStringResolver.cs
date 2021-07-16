using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Domain.Uow
{
    public class DefaultConnectionStringResolver : IConnectionStringResolver
    {
        public virtual string GetNameOrConnectionString(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) name = "Default";
            if (ConfigurationManager.ConnectionStrings[name] != null)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }

            throw new ArgumentNullException($"未找到数据库连接配置 [{name}]");
        }
    }
}
