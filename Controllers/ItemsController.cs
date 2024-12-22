
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();
            return View(items);
        }

    }
}