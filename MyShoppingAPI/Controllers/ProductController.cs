using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShoppingEntity;
using MyShoppingService.Services;

namespace MyShoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        ILogger _logger;
        public ProductController(IProductService productService, ILogger logger)
        {

            _productService = productService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _productService.GetProducts();
            return Ok(result);
        }
        [HttpPost("Create")] // here we are giving API name because sometime if we multiple post then it will confuse so we are giveing like this.  
        public IActionResult AddProduct([FromBody] Product product)
            {
            object err = "Product name mus be passed..";
            if (product.Name == "")
                return BadRequest(err);//400
            _productService.AddProduct(product);
            Response response = new Response();
            response.statuscode = "200";
            response.result = "Product added successfully..";
            response.message = "Success";
            //object result = "Product added successfully..";
            //return Ok(result);
            return Ok(response);

        }
        [HttpPut("Update")]
        public IActionResult UpdateProduct([FromBody]Product product, int id)

        {
            _productService.UpdateProduct(product, id);
            object result = "Product Updated successfully..";
            return Ok(result);

        }

       
        [HttpGet("GetProductById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetProductById(id);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            object result = "Product deleted successfully..";
            return Ok(result);
        }
    }
    public class Response
    {
        public object result { get; set; }
        public string statuscode { get; set; }
        public string message { get; set; }
    }
}
