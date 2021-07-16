using AutoMapper;
using SupplyChain.HttpApi.Controllers.Products.ViewModels.Outpus;
using SupplyChain.Product.Application.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.HttpApi.Controllers.Products.MpperProfiles
{
    public class ProductViewMapperProfiles : Profile
    {
        public ProductViewMapperProfiles()
        {
            CreateMap<ProductInfoDto, ProductInfoOutput>()
                .AfterMap((d, o) =>
                {
                    o.Name = d.ProductName;
                })
                ;
        }
    }
}
