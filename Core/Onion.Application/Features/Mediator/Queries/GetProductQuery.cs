using MediatR;
using Onion.Application.Features.Mediator.Results;

namespace Onion.Application.Features.Mediator.Queries
{
    public class GetProductQuery:IRequest<List<GetProductQueryResult>>
    {
        
    }
}
