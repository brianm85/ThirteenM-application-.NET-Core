using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brians_Website.Models
{
    public class ApiNewsHelperModel
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Source { get; set; }

        public Uri Link { get; set; }
    }
}
