using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp_v1.Models;

namespace WebApp_v1.Controllers
{
    [Route("[controller]")]
    public class Item : Controller
    {
        private readonly ILogger<Item> _logger;
        private string Name;

        public Item(ILogger<Item> logger)
        {
            _logger = logger;
        }

        public Item()
        {
        }

        public IActionResult Items()
        {
            Item item1 = new Item() { Name = "Test" };
            return View(item1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}