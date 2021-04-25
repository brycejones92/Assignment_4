using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Complaints
    {

        [key]
        public int CASE_NUM { get; set; }
        public string CASE_CLASS { get; set; }
        public string TYPE_OF_BUSINESS { get; set; }
        public DateTime OPEN_DATE { get; set; }
        public DateTime CLOSED_DATE { get; set; }
        public string OUTCOME { get; set; }



    }
}
