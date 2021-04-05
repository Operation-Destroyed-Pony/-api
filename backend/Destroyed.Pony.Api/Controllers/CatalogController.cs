using Microsoft.AspNetCore.Mvc;
using Destroyed.Pony.Domain.Catalog;

namespace Destroyed.Pony.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }

}

