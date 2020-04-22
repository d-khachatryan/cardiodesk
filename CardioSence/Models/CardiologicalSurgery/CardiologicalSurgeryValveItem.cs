using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalSurgeryValve")]
    public class CardiologicalSurgeryValveItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalSurgeryValveId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryValveId { get; set; }

        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }

        [Display(Name = "ValveSurgeryTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ValveSurgeryTypeId { get; set; }

        [Display(Name = "ValveSurgeryTypeName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ValveSurgeryTypeName { get; set; }

        [Display(Name = "ProthesisId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ProthesisId { get; set; }

        [Display(Name = "ProthesisName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ProthesisName { get; set; }

        [Display(Name = "ImplantId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ImplantId { get; set; }

        [Display(Name = "ImplantName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ImplantName { get; set; }

        [Display(Name = "ImplantSizeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ImplantSizeId { get; set; }

        [Display(Name = "ImplantSizeName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ImplantSizeName { get; set; }

        [Display(Name = "ValveTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ValveTypeId { get; set; }

        [Display(Name = "ValveTypeName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ValveTypeName { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string Comment { get; set; }
    }
}