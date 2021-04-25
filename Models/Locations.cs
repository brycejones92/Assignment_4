using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Locations
    {
        [key]
        public int LOC_ID { get; set; }
        public decimal POINT { get; set; }
        public string ADDRESS { get; set; }
        public int PRECEL_ID { get; set; }

    }
}
