using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Hazard
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public string Type { get; set; } = string.Empty;

        public string HazardObserved { get; set; } = string.Empty;

    }
}