using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalEchoCGVelocity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalEchoCGVelocityId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int CardiologicalEchoCGVelocityId { get; set; }

        [ForeignKey("CardiologicalEchoCG")]        
        [Display(Name = "CardiologicalEchoCGId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGId { get; set; }

        public CardiologicalEchoCG CardiologicalEchoCG { get; set; }

        [UIHint("Valve")]
        [Display(Name = "ValveId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? ValveId { get; set; }

        [Display(Name = "Velocity", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? Velocity { get; set; }

        [UIHint("Stenosis")]
        [Display(Name = "StenosisId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? StenosisId { get; set; }

        [Display(Name = "Area", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? Area { get; set; }

        [Display(Name = "Gradient", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? Gradient { get; set; }

        [UIHint("Insufficiency")]
        [Display(Name = "InsufficiencyId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? InsufficiencyId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}