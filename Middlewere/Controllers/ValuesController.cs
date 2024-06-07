using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Middlewere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public void GetValues()
        {
            Console.WriteLine("values");
        }
    }
}
