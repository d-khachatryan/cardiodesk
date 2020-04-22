using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCatheterizationSegment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalCatheterizationSegmentId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int CardiologicalCatheterizationSegmentId { get; set; }

        [ForeignKey("CardiologicalCatheterization")]
        [Display(Name = "CardiologicalCatheterizationId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? CardiologicalCatheterizationId { get; set; }


        public CardiologicalCatheterization CardiologicalCatheterization { get; set; }

        [UIHint("Segment")]
        [Display(Name = "SegmentId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? SegmentId { get; set; }

        [Display(Name = "ArterialBypass", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? ArterialBypass { get; set; }

        [Display(Name = "VenousBypass", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? VenousBypass { get; set; }

        [Display(Name = "StenosisSize", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? StenosisSize { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}