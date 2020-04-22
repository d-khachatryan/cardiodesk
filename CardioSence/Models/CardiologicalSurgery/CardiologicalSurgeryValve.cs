using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalSurgeryValve
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalSurgeryValveId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryValveId { get; set; }

        [ForeignKey("CardiologicalSurgery")]
        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }
        public CardiologicalSurgery CardiologicalSurgery { get; set; }

        [Display(Name = "ValveSurgeryTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ValveSurgeryTypeId { get; set; }

        [Display(Name = "ProthesisId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ProthesisId { get; set; }

        [Display(Name = "ImplantId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ImplantId { get; set; }

        [Display(Name = "ImplantSizeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ImplantSizeId { get; set; }

        [Display(Name = "ValveTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ValveTypeId { get; set; }

        [Display(Name = "SegmentC2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string Comment { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}