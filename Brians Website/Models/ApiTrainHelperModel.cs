using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brians_Website.Models
{
    public class ApiTrainHelperModel
    {
        public string StationName { get; set; }

        public string TrainDate { get; set; }

        public string Destination { get; set; }

        public string OrignTime { get; set; }

        public string DestinationTime{ get; set; }

        public string DueIn { get; set; }

        public string Late { get; set; }

        public string Origin { get; set; }

        public string Status { get; set; }

        public string LastLocation { get; set; }

        public string Direction { get; set; }

        public string ExpectedArival { get; set; }

        public string ExpectedDepart { get; set; }

        public string SheduleDepart { get; set; }
    }
}
