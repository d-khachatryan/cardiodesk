using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalSurgeryProcedure")]
    public class CardiologicalSurgeryProcedureItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalSurgeryProcedureId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryProcedureId { get; set; }

        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }

        [Display(Name = "MedicalProcedureId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? MedicalProcedureId { get; set; }

        [Display(Name = "MedicalProcedureName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string MedicalProcedureName { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string Comment { get; set; }
    }
}