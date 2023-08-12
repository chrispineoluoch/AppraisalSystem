using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppraisalSystem.Models
{
    public class personaldetails
    {
        public int Id { get; set; }

        //Personal Details
        public string FullName { get; set; }
        public string PFNumber { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string JobGroup { get; set; }
        public string NatureofEmployment { get; set; }
        public string StaffCategory { get; set; }
        public string SupervisorName { get; set; }
        public string SupervisorPFNumber { get; set; }
        public string UserName { get; set; }

        //Qualifications and Technical Skills

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Academic Qualifications")]
        [DataType(DataType.MultilineText)]
        public string AcademicQualifications { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Personal Certifications")]
        [DataType(DataType.MultilineText)]
        public string ProfessionalCertifications{ get; set; }
    }
}