using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Brians_Website.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Games()
        {
            return View();
        }
    }
}