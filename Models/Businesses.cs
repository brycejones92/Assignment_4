using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Businesses
    {
        [key]
        public int BUSINESS_ID { get; set; }
        public LinkedList<Complaints> complaint { get; set; }

        public List<Locations> Location { get; set; }

        public string BUSINESS_TYPE { get; set; }

    }
}
