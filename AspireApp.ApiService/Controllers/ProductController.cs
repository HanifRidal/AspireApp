using AspireApp.BL.Services;
using AspireApp.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspireApp.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<BaseResponseModel>>GetProducts()
        {
            //dependency injection
            var products = await productService.GetProducts();
            return Ok(new BaseResponseModel{ Success = true, Data = products });
        }
    }
}
