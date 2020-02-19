using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brians_Website.Models
{
    public class ApiBusHelperModel
    {
        public string Fullname { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Name { get; set; }

        public List<string> RouteNumbers { get; set; }
    }
}
