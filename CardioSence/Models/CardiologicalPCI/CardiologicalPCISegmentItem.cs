using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalPCISegment")]
    public class CardiologicalPCISegmentItem
    {
        [Key]
        [Display(Name = "CardiologicalPCISegmentId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int CardiologicalPCISegmentId { get; set; }

        [Display(Name = "CardiologicalPCIId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? CardiologicalPCIId { get; set; }

        [Display(Name = "StentId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? StentId { get; set; }

        [Display(Name = "StentName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string StentName { get; set; }

        [Display(Name = "SegmentId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? SegmentId { get; set; }

        [Display(Name = "SegmentName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string SegmentName { get; set; }

        [Display(Name = "LesionTypeId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? LesionTypeId { get; set; }

        [Display(Name = "LesionTypeName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string LesionTypeName { get; set; }

        [Display(Name = "Restenosis", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public bool? Restenosis { get; set; }

        [Display(Name = "Bifurcation", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public bool? Bifurcation { get; set; }

        [Display(Name = "TIMIBId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? TIMIBId { get; set; }

        [Display(Name = "TimiBName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string TimiBName { get; set; }

        [Display(Name = "TIMIAId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? TIMIAId { get; set; }

        [Display(Name = "TimiAName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string TimiAName { get; set; }

        [Display(Name = "StenosisPercentage", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? StenosisPercentage { get; set; }

        [Display(Name = "StentTypeId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? StentTypeId { get; set; }

        [Display(Name = "StentTypeName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string StentTypeName { get; set; }

        [Display(Name = "DirectStent", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public bool? DirectStent { get; set; }

        [Display(Name = "DrugElutionTypeId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? DrugElutionTypeId { get; set; }

        [Display(Name = "DrugElutionTypeName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string DrugElutionTypeName { get; set; }

        [Display(Name = "StentBallonSize", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public double? StentBallonSize { get; set; }

        [Display(Name = "Stentlength", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public double? Stentlength { get; set; }
    }
}