using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brians_Website.Models
{
    public class CheckAPIModel
    {
        public string LoginUsername { get; set; }

        public string LoginPassword { get; set; }

        [Display(Name = "Enter word to search ")]
        public string WordToSearch { get; set; }

        [Display(Name = "Result")]
        public string SearchedWord { get; set; }

        [Display(Name = "Amount")]
        public double AmmountToConvert { get; set; }

        [Display(Name = "To")]
        public string ConvertedCurrency { get; set; }

        [Display(Name = "From")]
        public string CurrencyToConvert { get; set; }

        [Display(Name = "Currency after")]
        public double CurrencyConverted { get; set; }

        [Display(Name = "Train station")]
        public string TrainStation { get; set; }

        [Display(Name = "Bus station")]
        public string BusStation { get; set; }

        public DateTime TrainStationTime { get; set; }

        public List<ApiTrainHelperModel> TrainData { get; set; }

        public ApiBusHelperModel BusData { get; set; }

        public ApiDictionaryModel DictionaryData { get; set; }

        public List<ApiNewsHelperModel> NewsData { get; set; }

        public SelectList CurrencyList { get; set; }

    }
}
