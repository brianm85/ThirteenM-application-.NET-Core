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
        public ActionResult Api() => View();

        [Route("ApiController/TrainTimes")]
        public ActionResult TrainTimes()
        {
            var model = new CheckAPIModel();
            return View("~/Views/Api/Travel.cshtml", model);
        }

        [HttpPost]
        public ActionResult TrainTimesApi(CheckAPIModel model)
        {
            try
            {
                if (model.TrainStation != null) //make new class to call for APIs
                {
                    model.TrainData = new ApiHelper().GetTrainData(model.TrainStation);
                }
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View("~/Views/Api/Travel.cshtml", model);
        }

        [Route("ApiController/BusStopInfo")]
        public ActionResult BusStopInfo()
        {
            var model = new CheckAPIModel();
            return View("~/Views/Api/BusStopInfo.cshtml", model);
        }

        [HttpPost]
        public ActionResult BusStopInfoApi(CheckAPIModel model)
        {
            try
            {
                if (model.BusStation != null) //make new class to call for APIs
                {
                    model.BusData = new ApiHelper().GetBusTimes(model.BusStation);
                }
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View("~/Views/Api/BusStopInfo.cshtml", model);
        }

        [Route("ApiController/Dictionary")]
        public ActionResult Dictionary()
        {
            var model = new CheckAPIModel();
            return View("~/Views/Api/Dictionary.cshtml", model);
        }

        [HttpPost]
        public ActionResult DictionaryApi(CheckAPIModel model)
        {
            try
            {
                model.DictionaryData = new ApiHelper().GetSearchedWord(model.WordToSearch);

                return View("~/Views/Api/Dictionary.cshtml", model);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [Route("ApiController/Currency")]
        public ActionResult Currency()
        {
            var model = new CheckAPIModel();
            return View("~/Views/Api/Currency.cshtml", model);
        }

        [HttpPost]
        public ActionResult CurrencyApi(CheckAPIModel model)
        {
            try
            {
                var bla = new ApiHelper().GetCurrency(model);
                model.CurrencyList = GetCurrencyList();

                return View("~/Views/Api/Currency.cshtml", model);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }


        [Route("ApiController/NewsApi")]
        public ActionResult NewsApi()
        {
            try
            {
                var mod = new ApiHelper().GetNews();

                CheckAPIModel model = new CheckAPIModel();
                model.NewsData = mod;

                return View("~/Views/Api/News.cshtml", model);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        private SelectList GetCurrencyList()
        {
            var currencySelectList = new SelectList(
            new List<SelectListItem>
            {
                new SelectListItem {Text = "US Dollor", Value = "USD"},
                new SelectListItem {Text = "Euro", Value = "EUR"},
                new SelectListItem {Text = "British Pound", Value = "GBP"},
                new SelectListItem {Text = "Aus Dollor", Value = "AUD"},
                new SelectListItem {Text = "Irish Punt", Value = "IEP"},
            }, 
            "Value", "Text");

            return currencySelectList;
        }
    }
}