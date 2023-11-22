
using Microsoft.AspNetCore.Mvc;
using ServMarkService.Models;
using ServMarkService.Services;

namespace ServMarkService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
        [HttpGet("{id}/Products")]
        public IActionResult GetProducts(int id, [FromQuery] int? limit, [FromQuery] int? offset)
        {
            return Ok(_service.GetProducts(id, limit, offset));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            await _service.Add(category);
            return Ok(category);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category category)
        {
            await _service.Update(id, category);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
