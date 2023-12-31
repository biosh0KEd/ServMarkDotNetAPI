using Microsoft.AspNetCore.Mvc;
using ServMarkService.Models.Product;
using ServMarkService.Services.Product;

namespace ServMarkService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] int? limit, [FromQuery] int? offset)
        {
            return Ok(_service.GetAll(limit, offset));
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _service.GetById(id);
            if (product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            await _service.Add(product);
            return Ok(product);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Product product)
        {
            await _service.Update(id, product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
