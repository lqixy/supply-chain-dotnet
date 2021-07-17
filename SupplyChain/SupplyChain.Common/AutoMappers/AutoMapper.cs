using AutoMapper;
using SupplyChain.ObjectMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObjectMapper = SupplyChain.ObjectMappings.IObjectMapper;

namespace SupplyChain.Common.AutoMapper
{
    public class AutoMapper : IObjectMapper
    {
        protected readonly IMapper mapper;

        public AutoMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source, x => { });
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return mapper.Map(source, destination, x => { });
        }

        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source)
        {
            return mapper.ProjectTo<TDestination>(source);
        }
    }
}
