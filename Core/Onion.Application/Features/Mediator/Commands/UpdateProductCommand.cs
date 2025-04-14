using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Commands
{
    public record UpdateProductCommand:IRequest<bool>
    {
        public Guid ProductId { get; init; }
        public string ProductName { get; init; }
        public decimal Price { get; init; }
        public int Stock { get; init; }
        public Guid CategoryId { get; init; }
    }
}
