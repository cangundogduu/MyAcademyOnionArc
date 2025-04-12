using AutoMapper;
using Onion.Application.Features.CQRS.Commands;
using Onion.Application.Features.CQRS.Results;
using Onion.Domain.Entities;

namespace Onion.Application.Mapper
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();


        }
    }
}
