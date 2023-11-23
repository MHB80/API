using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.JavaScript;

namespace apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hellodev : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("hello world");

        [HttpPost]
        public IActionResult Post(JSObject payload)
        { 
            return Ok (payload);
        }
    }

}
