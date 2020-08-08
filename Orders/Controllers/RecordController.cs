using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Controllers
{
    [ApiController]
    [Route("api/order/record")]
    public class RecordController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("record");
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            return Ok("list");
        }
    }
}