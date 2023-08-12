using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppraisalSystem.Models
{
    public class traininganddevelopmentplan
    {
        public int Id { get; set; }
        public string PFNumber { get; set; }
        public string FullName { get; set; }
        public string FinancialYear { get; set; }
        public string TrainingProgram { get; set; }
        public string TrainingInstitute { get; set; }
        public string TotalCost { get; set; }
        public string NumberofDays { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string ApraiseeComents { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string HODComments { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? DateofSubmission { get; set; }

        public string SupervisorName { get; set; }
    }
}