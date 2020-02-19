using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brians_Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Xml;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Brians_Website.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Brians_Website.Controllers
{
    public class ApiController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public ActionResult Api() => View();

        [HttpPost]
        public ActionResult TravelApi(CheckAPIModel model)
        {
            try
            {
                if (model.TrainStation != null) //make new class to call for APIs
                {
                    model.TrainData = new ApiHelper().GetTrainData(model.TrainStation);
                }
                else
                {
                    model.BusData = new ApiHelper().GetBusTimes(model.BusStation);
                }
            }
            catch(Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View("~/Views/Api/Api.cshtml", model);
        }

        [HttpPost]
        public ActionResult DictionaryApi(CheckAPIModel model)
        {
            model.DictionaryData = new ApiHelper().GetSearchedWord(model.WordToSearch);

            return View("~/Views/Api/Api.cshtml", model);
        }

        [HttpPost]
        public ActionResult CurrencyApi(CheckAPIModel model)
        {
            var listofCurrencys = GetCurrencyList();

            model.CurrencyList = GetCurrencyList();

            return View("~/Views/Api/Api.cshtml", model);
        }

        [Route("ApiController/NewsApi")]
        public ActionResult NewsApi()
        {
            var mod = new ApiHelper().GetNews();

            CheckAPIModel model = new CheckAPIModel();
            model.NewsData = mod;

            return View("~/Views/Api/Api.cshtml", model);
        }

        private SelectList GetCurrencyList()
        {
            var currencySelectList = new SelectList(
            new List<SelectListItem>
            {
                        new SelectListItem {Text = "US Dollor", Value = "USD"},
                        new SelectListItem {Text = "Euro", Value = "Euro"},
                        new SelectListItem {Text = "British Pound", Value = "BPD"},
                        new SelectListItem {Text = "Aus Dollor", Value = "AUD"},
                        ////new SelectListItem {Text = "Irish Punt", Value = "IRP"},
            }, 
            "Value", "Text");

            return currencySelectList;
        }
    }
}