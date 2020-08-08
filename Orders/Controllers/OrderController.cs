using Microsoft.AspNetCore.Mvc;

namespace Orders.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {

        [HttpGet("getorder")]
        public IActionResult GetOrder()
        {
            return Ok("order");
        }
    }
}