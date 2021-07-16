using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.ObjectMappings
{
    public sealed class NullObjectMapper : IObjectMapper
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullObjectMapper Instance { get; } = new NullObjectMapper();

        public TDestination Map<TDestination>(object source)
        {
            throw new Exception("ObjectMapping.IObjectMapper should be implemented in order to map objects.");
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            throw new Exception("ObjectMapping.IObjectMapper should be implemented in order to map objects.");
        }

        //public TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<ObjectMapperItems> itemsSet)
        //{
        //    throw new Exception("ObjectMapping.IObjectMapper should be implemented in order to map objects.");
        //}

        //public TDestination Map<TDestination>(object source, Action<ObjectMapperItems> itemsSet)
        //{
        //    throw new Exception("ObjectMapping.IObjectMapper should be implemented in order to map objects.");
        //}

        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source)
        {
            throw new Exception("ObjectMapping.IObjectMapper should be implemented in order to map objects.");
        }
    }
}
