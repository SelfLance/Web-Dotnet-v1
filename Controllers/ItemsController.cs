
using Microsoft.AspNetCore.Mvc;
using WebApp_v1.Data;
using WebApp_v1.Models;

namespace WebApp_v1.Controllers
{

    public class ItemsController : Controller
    {
        public readonly MyAppContext _context;

        public ItemsController(MyAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Items;
            return View(items);
        }

    }
}