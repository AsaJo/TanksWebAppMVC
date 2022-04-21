using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TanksWebAppMVC.Controllers
{
    public class TankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TankHistory()
        {
            return View();
        }
    }
}
