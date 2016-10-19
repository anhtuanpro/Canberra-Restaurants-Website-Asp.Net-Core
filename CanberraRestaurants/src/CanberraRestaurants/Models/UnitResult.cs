using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanberraRestaurants.Models
{
    public class UnitResult
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Assignment1Mark { get; set; }
        public string Assignment2Mark { get; set; }
        public string ExamMark { get; set; }
        public string TotalMark { get; set; }
        public string Grade { get; set; }
    }

}
