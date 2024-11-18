using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ABC
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public string Type { get; set; } = string.Empty;

        public string Subtype { get; set; } = string.Empty;

        public string ReportedBy { get; set; } = string.Empty;
        public string Project { get; set; } = string.Empty;

        public string SpecificLocation { get; set; } = string.Empty;


    }
}