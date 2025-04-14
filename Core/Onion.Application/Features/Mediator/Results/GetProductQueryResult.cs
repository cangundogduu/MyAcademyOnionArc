﻿using Onion.Application.Features.CQRS.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Results
{
    public record GetProductQueryResult(Guid ProductId, string ProductName, decimal Price, int Stock, Guid CategoryId);
}
