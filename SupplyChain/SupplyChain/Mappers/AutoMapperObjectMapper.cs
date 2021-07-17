using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Common.Mappers
{
    public class AutoMapperObjectMapper : IObjectMapper
    {
        private readonly IMapper Mapper;

        public AutoMapperObjectMapper(IMapper mapper)
        {
            Mapper = mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source, x => { });
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination, x => { });
        }
        //public TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<ObjectMapping.ObjectMapperItems> itemsSet)
        //{
        //    return Mapper.Map(source, destination, opts: (x) =>
        //    {
        //        var items = new ObjectMapping.ObjectMapperItems(iocManager);
        //        itemsSet(items);
        //        foreach (var item in items)
        //        {
        //            x.Items[item.Key] = item.Value;
        //        }
        //    });
        //}

        //public TDestination Map<TDestination>(object source, Action<ObjectMapping.ObjectMapperItems> itemsSet)
        //{
        //    return Mapper.Map<TDestination>(source, opts: (x) =>
        //    {
        //        var items = new ObjectMapping.ObjectMapperItems(iocManager);
        //        itemsSet(items);
        //        foreach (var item in items)
        //        {
        //            x.Items[item.Key] = item.Value;
        //        }
        //    });
        //}

        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source)
        {
            return Mapper.ProjectTo<TDestination>(source);
        }
    }
}
