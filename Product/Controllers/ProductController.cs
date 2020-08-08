using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Product.Controller
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [HttpGet("getproduct")]
        public IActionResult GetProduct()
        {
            return Ok(new[] { "test1", "test2" });
        }
    }
}