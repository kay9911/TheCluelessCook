using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheCluelessCook.Controllers
{
    public class ShoppingListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}