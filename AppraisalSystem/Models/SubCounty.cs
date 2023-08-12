using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppraisalSystem.Models
{
    public class SubCounty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int CountyId { get; set; }
        public int SubCountyId { get; set; }
        public string SubCountyName { get; set; }
        public virtual County County_VC { get; set; }
    }
}