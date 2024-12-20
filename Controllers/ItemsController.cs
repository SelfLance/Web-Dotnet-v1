
using Microsoft.AspNetCore.Mvc;

using WebApp_v1.Models;

namespace WebApp_v1.Controllers
{

    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Test1" };
            // var item1 = new Item() { Name = "Test" };
            return View(item);
        }


    }
}