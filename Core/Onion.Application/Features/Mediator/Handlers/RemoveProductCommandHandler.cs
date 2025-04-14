using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class RemoveProductCommandHandler:IRequestHandler<RemoveProductCommand, bool>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        

        public RemoveProductCommandHandler(IRepository<Product> productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            
        }


        public async Task<bool> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteAsync(request.id);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
    
}
