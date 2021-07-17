using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Common.Mappers
{
    public sealed class NullObjectMapper : IObjectMapper
    {
        public static NullObjectMapper Instance => new NullObjectMapper();

        public TDestination Map<TDestination>(object source)
        {
            throw new NotImplementedException();
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source)
        {
            throw new NotImplementedException();
        }
    }
}
