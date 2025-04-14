using AutoMapper;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Features.Mediator.Results;
using Onion.Domain.Entities;

namespace Onion.Application.Mapper
{
    public class ProductMappingProfile:Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, GetProductQueryResult>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();

        }
    }
}
