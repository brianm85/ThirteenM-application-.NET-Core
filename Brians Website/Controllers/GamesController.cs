using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brians_Website.Helpers;
using Brians_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Brians_Website.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Games()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DictionaryApi(CheckAPIModel model)
        {
            model.DictionaryData = new ApiHelper().GetSearchedWord(model.WordToSearch);

            return PartialView("~/Views/Shared/_DictionaryApi.cshtml", model);
        }
    }
}