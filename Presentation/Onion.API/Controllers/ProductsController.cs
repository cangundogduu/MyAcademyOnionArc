using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Features.Mediator.Queries;

namespace Onion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var results = await _mediator.Send(new GetProductQuery());
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == false)
            {
                return BadRequest("Ürün oluşturulamadı.");
            }
            return Created();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
            {
                return NotFound("Değer bulunamadı.");
            }
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == false)
            {
                return BadRequest("Ürün güncellenemedi.");
            }

            return Ok("Ürün başarı ile güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
            {
                return NotFound("Değer bulunamadı.");
            }

            var result = await _mediator.Send(new RemoveProductCommand(id));
            if (result == false)
            {
                return BadRequest("Ürün silinemedi.");
            }
            return Ok("Ürün başarı ile silindi.");
        }
    }
}
