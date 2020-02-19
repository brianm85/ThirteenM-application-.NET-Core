using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brians_Website.Models
{
    public class VisualModel
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public double Price { get; set; }

        public bool PaidInFull { get; set; }
    }
}
