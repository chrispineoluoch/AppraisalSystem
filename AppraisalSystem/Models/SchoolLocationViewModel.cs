using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppraisalSystem.Models;

namespace AppraisalSystem.Models
{
    public class SchoolLocationViewModel
    {
        public int CountyId { get; set; }
        public int SubCountyId { get; set; }
        public int ZoneId { get; set; }
        public int SchoolId { get; set; }
        public IEnumerable<County> County_VM { get; set; }
        public IEnumerable<SubCounty> SubCounty_VM { get; set; }
    }
}