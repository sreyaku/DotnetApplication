using Microsoft.AspNetCore.Mvc;
using ProductDetails.Model;
using ProductDetails.Services;
using System.Threading.Tasks;

namespace ProductDetails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("/getAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _productService.GetProductList();

            return Ok(result);
        }

        [HttpGet("/getProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _productService.GetProduct(id);

            return Ok(result);
        }

        [HttpPost("/addProduct")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var result = await _productService.CreateProduct(product);

            return Ok(result);
        }

        [HttpPut("/updateProduct")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Product product)
        {
            var result = await _productService.UpdateProduct(product);

            return Ok(result);
        }

        [HttpDelete("DeleteProduct/{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _productService.DeleteProduct(id);

            return Ok(result);
        }

    }
}
