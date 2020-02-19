using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brians_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Brians_Website.Controllers
{
    public class VisualsController : Controller
    {
        public ActionResult Visuals()
        {
            var modellist = new List<VisualModel>
            {
                new VisualModel
                {
                    FirstName = "Paul",
                    SecondName = "Bishop",
                    DateOfBirth = new DateTime(27/04/1999),
                    Price = 49.99,
                    PaidInFull = false
                },
                new VisualModel
                {
                    FirstName = "John",
                    SecondName = "Bishop",
                    DateOfBirth = new DateTime(27/03/1990),
                    Price = 49.99,
                    PaidInFull = true
                },
                new VisualModel
                {
                    FirstName = "Paul",
                    SecondName = "Ryan",
                    DateOfBirth = new DateTime(21/03/2001),
                    Price = 149.99,
                    PaidInFull = true
                },
                new VisualModel
                {
                    FirstName = "Alex",
                    SecondName = "Friel",
                    DateOfBirth = new DateTime(27/03/1990),
                    Price = 9.99,
                    PaidInFull = false
                },
                new VisualModel
                {
                    FirstName = "Jenny",
                    SecondName = "Harper",
                    DateOfBirth = new DateTime(01/06/1960),
                    Price = 27.00,
                    PaidInFull = true
                },
                new VisualModel
                {
                    FirstName = "Paul",
                    SecondName = "Harper",
                    DateOfBirth = new DateTime(27/12/1961),
                    Price = 28.20,
                    PaidInFull = true
                },
            };
            return View(modellist);
        }
    }
}