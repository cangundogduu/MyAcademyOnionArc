using MediatR;
using Onion.Application.Features.Mediator.Results;

namespace Onion.Application.Features.Mediator.Queries
{
    public class GetProductByIdQuery(Guid id) : IRequest<GetProductByIdQueryResult>
    {
        public Guid Id { get; init; } = id;
    }

}
