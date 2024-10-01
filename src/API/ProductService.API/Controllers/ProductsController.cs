using Microsoft.AspNetCore.Mvc;
using ProductService.API.Manager;

namespace ProductService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductManager productManager;
        public ProductsController(IProductManager _productManager) => productManager = _productManager;

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await productManager.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var result = await productManager.GetProductByIdAsync(id);
            return Ok(result);
        }
    }
}
