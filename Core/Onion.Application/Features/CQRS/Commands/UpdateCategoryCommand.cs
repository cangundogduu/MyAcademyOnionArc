using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Commands
{
    public record UpdateCategoryCommand(Guid CategoryId, string CategoryName);
    
}
