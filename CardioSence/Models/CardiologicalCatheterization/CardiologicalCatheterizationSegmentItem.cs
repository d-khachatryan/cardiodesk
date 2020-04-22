using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalCatheterizationSegment")]
    public class CardiologicalCatheterizationSegmentItem
    {
        [Key]
        [Display(Name = "CardiologicalCatheterizationSegmentId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int CardiologicalCatheterizationSegmentId { get; set; }

        [Display(Name = "CardiologicalCatheterizationId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? CardiologicalCatheterizationId { get; set; }

        [Display(Name = "SegmentId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? SegmentId { get; set; }

        [Display(Name = "SegmentName", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public string SegmentName { get; set; }

        [Display(Name = "ArterialBypass", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? ArterialBypass { get; set; }

        [Display(Name = "VenousBypass", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? VenousBypass { get; set; }

        [Display(Name = "StenosisSize", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? StenosisSize { get; set; }

    }
}