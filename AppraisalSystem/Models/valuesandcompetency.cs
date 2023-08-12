using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalSystem.Models
{
    public class valuesandcompetency
    {
        public int Id { get; set; }
        public string PFNumber { get; set; }
        public string FullName { get; set; }
        public string FinancialYear { get; set; }
        public string TeamSpirit { get; set; }
        public string Integrity { get; set; }
        public string InitiativeandSelfdrive { get; set; }
        public string InterpersonalRelations { get; set; }
        public string PunctualityandAttendance { get; set; }
        public string TechnicalCompetencies { get; set; }
        public string DependabilityandResourcefulness { get; set; }
        public string ResourceManagement { get; set; }
        public string DeliveryandPromptness { get; set; }
        public string AttitudetoWorkandColleagues { get; set; }
        public string TotalScore { get; set; }

        [Display(Name = "Date of Update")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? DateofSubmission { get; set; }
    }
}