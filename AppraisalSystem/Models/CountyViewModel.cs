using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalSystem.Models
{
    public class CountyViewModel
    {
        public string County { get; set; }
        public int NumberofCases { get; set; }
        public int SelfQuarantineCases { get; set; }
        public int GovernmentQuarantineCases { get; set; }
        public int TotalPositiveTests { get; set; }
        public int NegativeTests { get; set; }
        public int TotNumberofRecoveries { get; set; }
        public int NumberofDeaths { get; set; }
    }
}