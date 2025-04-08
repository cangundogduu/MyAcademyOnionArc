using AutoMapper;
using Onion.Application.Features.CQRS.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryQueryHandler(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _categoryRepository.GetAllAsync();

            return _mapper.Map<List<GetCategoryQueryResult>>(categories);

        }
    }
}
