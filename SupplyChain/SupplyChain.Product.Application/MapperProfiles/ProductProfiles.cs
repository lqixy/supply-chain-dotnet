using AutoMapper;
using SupplyChain.Product.Application.Contracts.Dto;
using SupplyChain.Product.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.MapperProfiles
{
    public class ProductProfiles : Profile
    {
        public ProductProfiles()
        {
            CreateMap<ProductInfo, ProductInfoDto>();
        }
    }
}
