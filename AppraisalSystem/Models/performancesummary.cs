using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalSystem.Models
{
    public class performancesummary
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PFNumber { get; set; }
        public string FullName { get; set; }
        public string SupervisorName { get; set; }
        public string FinancialYear { get; set; }
        public int PerformanceTargetScore { get; set; }
        public int ValuesandCompetenciesScore { get; set; }
        public int TotalScore { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? SubmissionDate { get; set; }
    }
}