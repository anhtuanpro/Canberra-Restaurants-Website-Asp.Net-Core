using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CanberraRestaurants.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
        public string Heading { get; set; }
        public string Restaurant { get; set; }
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
        public int Rating { get; set; }
        [Display(Name = "Agree")]
        public int AgreeNumber { get; set; }
        [Display(Name = "Disagree")]
        public int DisagreeNumber { get; set; }
    }
}
