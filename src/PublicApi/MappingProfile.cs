using System;
using AutoMapper;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.PublicApi.CatalogBrandEndpoints;
using Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;
using Microsoft.eShopWeb.PublicApi.CatalogTypeEndpoints;
using Microsoft.eShopWeb.PublicApi.OrderEndpoints;

namespace Microsoft.eShopWeb.PublicApi;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CatalogItem, CatalogItemDto>();
        CreateMap<CatalogType, CatalogTypeDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Type));
        CreateMap<CatalogBrand, CatalogBrandDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Brand));

        CreateMap<Order, OrderDto>();

        /*CreateMap<Order, OrderDto>()*/
        /*    .ForMember(dto => dto.BuyerId, opts => opts.MapFrom(src => Guid.Parse(src.BuyerId)))*/
        /*    .ReverseMap()*/
        /*    .ForMember(dest => dest.BuyerId, opts => opts.MapFrom(dto => dto.BuyerId.ToString()));*/
    }
}
