using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppraisalSystem.Models
{
    public class County
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public virtual ICollection<SubCounty> SubCounty_IC { get; set; }
    }
}