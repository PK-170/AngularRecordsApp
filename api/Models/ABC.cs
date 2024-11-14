using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ABC
    {
        public int Id { get; set; }
        public required DateTime Date { get; set; }
        public string? Email { get; set; } = string.Empty;

        public required string Phone { get; set; } = string.Empty;
    }
}