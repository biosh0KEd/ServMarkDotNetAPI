using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServMarkService.Services.Product;

namespace ServMarkService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IImageService _service;
        public ImageController(IImageService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Product.Image image)
        {
            await _service.Add(image);
            return Ok(image);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Product.Image image)
        {
            await _service.Update(id, image);
            return Ok(image);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
