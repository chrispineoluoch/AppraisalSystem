using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppraisalSystem.Models
{
    public class supervisorcomments
    {
        public int Id { get; set; }
        public string PFNumber { get; set; }
        public string FinancialYear { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string EmployeeStrengths { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string EmployeeDifficulties { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string SupervisorPerformanceComments { get; set; }
        public string SupervisorName { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? SupervisorDate { get; set; }        
    }
}