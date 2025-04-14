using MediatR;

namespace Onion.Application.Features.Mediator.Commands
{
    public record RemoveProductCommand(Guid id):IRequest<bool>;
   
    
}
