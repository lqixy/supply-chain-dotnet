using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Common.Mappers
{
    public interface IObjectMapper
    {
        /// <summary>
        /// Converts an object to another. Creates a new object of <see cref="TDestination"/>.
        /// </summary>
        /// <typeparam name="TDestination">Type of the destination object</typeparam>
        /// <param name="source">Source object</param>
        TDestination Map<TDestination>(object source);
        //TDestination Map<TDestination>(object source, Action<ObjectMapperItems> itemsSet);

        /// <summary>
        /// Execute a mapping from the source object to the existing destination object
        /// </summary>
        /// <typeparam name="TSource">Source type</typeparam>
        /// <typeparam name="TDestination">Destination type</typeparam>
        /// <param name="source">Source object</param>
        /// <param name="destination">Destination object</param>
        /// <returns>Returns the same <see cref="destination"/> object after mapping operation</returns>
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
        //TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<ObjectMapperItems> itemsSet);
        /// <summary>
        /// Project the input queryable.
        /// </summary>
        /// <remarks>Projections are only calculated once and cached</remarks>
        /// <typeparam name="TDestination">Destination type</typeparam>
        /// <param name="source">Queryable source</param>
        /// <returns>Queryable result, use queryable extension methods to project and execute result</returns>
        IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source);
    }
}
