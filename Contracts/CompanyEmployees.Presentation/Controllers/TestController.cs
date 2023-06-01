using ActionFilters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [ServiceFilter(typeof(ControllerFilterExample), Order = 2)]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [ServiceFilter(typeof(ActionFilterExample), Order = 1)]
        public IEnumerable<string> Get()
        {
            return new string[] { "example", "data" };
        }
    }
}