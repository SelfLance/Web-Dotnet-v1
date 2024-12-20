using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp_v1.Views.Shared.Item
{
    public class item : PageModel
    {
        private readonly ILogger<item> _logger;

        public item(ILogger<item> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}