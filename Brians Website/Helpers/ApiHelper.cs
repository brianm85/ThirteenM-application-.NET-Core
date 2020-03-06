using Brians_Website.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ThirteenM.Models;

namespace Brians_Website.Helpers
{
    public class ApiHelper
    {
        public List<ApiTrainHelperModel> GetTrainData(string res)
        {
            var webRequest = WebRequest.Create(@"http://api.irishrail.ie/realtime/realtime.asmx/getStationDataByNameXML?StationDesc=" + res);

            using (var response = webRequest.GetResponse())
            {
                using (var rd = new StreamReader(response.GetResponseStream()))
                {
                    res = rd.ReadToEnd();
                }
            }
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(res);

            string json = JsonConvert.SerializeXmlNode(doc);

            var details = JObject.Parse(json);

            var stationdataobject = details["ArrayOfObjStationData"];

            var stationdatalist = stationdataobject["objStationData"].ToList();

            var bbb = stationdatalist[0];

            var list = new List<ApiTrainHelperModel>();
            foreach(var station in stationdatalist)
            {
                var mod = new ApiTrainHelperModel
                {
                    TrainDate = station["Traindate"].ToString(),
                    Origin = station["Origin"].ToString(),
                    OrignTime = station["Origintime"].ToString(),
                    Destination = station["Destination"].ToString(),
                    DestinationTime = station["Destinationtime"].ToString(),
                    Status = station["Status"].ToString(),
                    LastLocation = station["Lastlocation"].ToString(),
                    DueIn = station["Duein"].ToString(),
                    ExpectedArival = station["Exparrival"].ToString(),
                    Direction = station["Direction"].ToString()
                };
                list.Add(mod);
            }

            return list;
        }

        public ApiBusHelperModel GetBusTimes(string busStation)
        {
            var res = busStation;
            var webRequest = WebRequest.Create(@"https://data.smartdublin.ie/cgi-bin/rtpi/busstopinformation?stopid=" + busStation + "&format=JSON");

            using (var response = webRequest.GetResponse())
            {
                using (var rd = new StreamReader(response.GetResponseStream()))
                {
                    res = rd.ReadToEnd();
                }
            }

            dynamic data = JObject.Parse(res);

            var routes = data.results[0].operators[0].routes;

            var routeslist = new List<string>();
            foreach (var rt in routes)
            {
                routeslist.Add(rt.Value);
            }

            var model = new ApiBusHelperModel
            {
                RouteNumbers = routeslist,
                Fullname = data.results[0].fullname.Value,
                Latitude = data.results[0].latitude.Value,
                Longitude = data.results[0].longitude.Value,
                Name = data.results[0].operators[0].name.Value
            };

            return model;
        }

        public ApiDictionaryModel GetSearchedWord(string searchstring)
        {
            var res = "";
            string word_id = searchstring;
            const string lang_code = "en-gb";
            const string fields = "definitions";
            const string strictMatch = "false";
            string WEBSERVICE_URL = "https://od-api.oxforddictionaries.com:443/api/v2/entries/" + lang_code + '/' + word_id + "?fields=" + fields + "&strictMatch=" + strictMatch;
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("app_id", "eb93273d");
                    webRequest.Headers.Add("app_key", "	ee2e5292e477ea56908db90b1f5b21e0");

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            res = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            var model = new ApiDictionaryModel();

            dynamic data = JObject.Parse(res);

            var definition = data.results[0].lexicalEntries[0].entries[0].senses[0].definitions[0].Value;
            var deflist = new List<string>();
            deflist.Add(definition);

            model.Lexical = data.results[0].lexicalEntries[0].lexicalCategory.text.Value;

            foreach (var item in data.results[0].lexicalEntries[0].entries[0].senses[0].subsenses)
            {
                var ex = item.definitions[0].Value;
                deflist.Add(ex);
            }

            model.Definitions = deflist;

            return model;
        }

        public List<ApiNewsHelperModel> GetNews()
        {
            var webkey = "2f3e9c21b967485f8489c7e4fa707bf7";
            var webRequest = WebRequest.Create(@"http://newsapi.org/v2/top-headlines?country=ie&apiKey=" + webkey);
            var res = "";

            using (var response = webRequest.GetResponse())
            {
                using (var rd = new StreamReader(response.GetResponseStream()))
                {
                    res = rd.ReadToEnd();
                }
            }

            dynamic data = JObject.Parse(res);

            var numberOfStories = Int32.Parse(Convert.ToString(data.totalResults.Value));

            var model = new List<ApiNewsHelperModel>();


            foreach (var item in data.articles)
            {
                model.Add(new ApiNewsHelperModel
                {
                    Source = item.source.name.Value,
                    Author = item.author.Value,
                    Title = item.title.Value,
                    Description = item.description.Value,
                    Content = item.content.Value,
                    Link = new Uri(item.url.Value)
                });
            }

            return model;
        }

        public string GetCurrency(CheckAPIModel model)
        {
            var curFrom = model.CurrencyFrom;
            var curTo = model.CurrencyTo;
            var amt = model.AmmountToConvert.ToString();
            var st = "https://currency-converter5.p.rapidapi.com/currency/convert?format=json&from=" + curFrom + "&to=" + curTo + "&amount=" + amt;
            var client = new RestClient(st);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7d8d99d373mshc3117de52882fb3p1e2c5djsnac4bb85ece25");
            IRestResponse response = client.Execute(request);

            dynamic data = JObject.Parse(response.Content);
            var ba = data.rates.Value; //FIX ME rates { key, value [values ]}
            var userObj = JsonConvert.DeserializeObject<ApiCurrencyConverterModel>(ba);



            return null;
        }


    }
}
