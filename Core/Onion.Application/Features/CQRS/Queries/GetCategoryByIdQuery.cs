using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Queries
{
    public record GetCategoryByIdQuery(Guid id);
    
}
