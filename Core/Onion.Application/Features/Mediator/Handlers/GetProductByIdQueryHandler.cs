using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Queries;
using Onion.Application.Features.Mediator.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class GetProductByIdQueryHandler:IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
    
}
