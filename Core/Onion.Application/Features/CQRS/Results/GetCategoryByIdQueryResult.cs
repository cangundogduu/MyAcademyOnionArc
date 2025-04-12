using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Results
{
    public record GetCategoryByIdQueryResult(Guid CategoryId, string CategoryName);
    
}
