using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppraisalSystem.Models
{
    public class performancetargets
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PFNumber { get; set; }
        public string FullName { get; set; }
        public string SupervisorName { get; set; }
        public string FinancialYear { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_1 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_1 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_1 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_1 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_1 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_2 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_2 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_2 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_2 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_2 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_3 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_3 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_3 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_3 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_3 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_4 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_4 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_4 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_4 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_4 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_5 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_5 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_5 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_5 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_5 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_6 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_6 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_6 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_6 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_6 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_7 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_7 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_7 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_7 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_7 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_8 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_8 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_8 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_8 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_8 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_9 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_9 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_9 { get; set; }


        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_9 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_9 { get; set; }

        //New Objective and Target
        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Objective")]
        [DataType(DataType.MultilineText)]
        public string Objective_10 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string Target_10 { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        [Display(Name = "Target")]
        [DataType(DataType.MultilineText)]
        public string ResultAchieved_10 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? IndividualRating_10 { get; set; }

        [Range(1, 5, ErrorMessage = "Value Must be between 1 and 5!")]
        public int? SupervisorRating_10 { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? PTSettingDate { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? PTAppraisalDate { get; set; }

        public int? NumberofTargets { get; set; }
        public int? PTTotalScore { get; set; }
        public int? VCTotalScore { get; set; }
        public int OverallScore { get; set; }
    }
}