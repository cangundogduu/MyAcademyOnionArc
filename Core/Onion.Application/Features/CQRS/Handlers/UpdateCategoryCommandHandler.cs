using AutoMapper;
using Onion.Application.Features.CQRS.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IRepository<Category> repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateCategoryCommand command)
        {
            var category = _mapper.Map<Category>(command);
            _repository.Update(category);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
