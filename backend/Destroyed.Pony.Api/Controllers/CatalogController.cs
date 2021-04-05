using Microsoft.AspNetCore.Mvc;
using Destroyed.Pony.Domain.Catalog;
using System.Collections.Generic;

namespace Destroyed.Pony.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item ("Shorts", "Ohio State shorts", "Nike", 44.99m)
            };

            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new item("Shirt", "Ohio State Shirt.", "Nike", 29.99m);
            item.Id = id;

            return Ok(item);
    }

}

