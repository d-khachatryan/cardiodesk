using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalEchoCGVelocity")]
    public class CardiologicalEchoCGVelocityItem
    {

        [Key]
        [Display(Name = "CardiologicalEchoCGVelocityId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGVelocityId { get; set; }

        [Display(Name = "CardiologicalEchoCGId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGId { get; set; }

        [Display(Name = "ValveId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? ValveId { get; set; }

        [Display(Name = "ValveName", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string ValveName { get; set; }

        [Display(Name = "Velocity", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? Velocity { get; set; }

        [Display(Name = "StenosisId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? StenosisId { get; set; }

        [Display(Name = "StenosisName", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string StenosisName { get; set; }

        [Display(Name = "Area", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? Area { get; set; }

        [Display(Name = "Gradient", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? Gradient { get; set; }

        [Display(Name = "InsufficiencyId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? InsufficiencyId { get; set; }

        [Display(Name = "InsufficiencyName", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string InsufficiencyName { get; set; }
    }
}