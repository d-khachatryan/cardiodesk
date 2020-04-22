using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalECG")]
    public class CardiologicalECGItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalECGId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int CardiologicalECGId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        [Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? ResidentId { get; set; }

        [Display(Name = "PatientId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? PatientId { get; set; }

        [Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ResidentLastName { get; set; }

        [Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ResidentFirstName { get; set; }

        [Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ResidentPatronymicName { get; set; }

        [Display(Name = "ResidentName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ResidentName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public DateTime? BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CardiologicalECGDate", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public DateTime? CardiologicalECGDate { get; set; }

        [Display(Name = "HR", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? HR { get; set; }

        [Display(Name = "RhythmTypeID", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? RhythmTypeID { get; set; }

        [Display(Name = "RhythmTypeName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string RhythmTypeName { get; set; }

        [Display(Name = "AxisDegree", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string AxisDegree { get; set; }

        [Display(Name = "PQ", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? PQ { get; set; }

        [Display(Name = "QT", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? QT { get; set; }

        [Display(Name = "LVHId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? LVHId { get; set; }

        [Display(Name = "VHName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string VHName { get; set; }

        [Display(Name = "RVHId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? RVHId { get; set; }

        [Display(Name = "RVHName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string RVHName { get; set; }

        [Display(Name = "ZoneIshemiaId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? ZoneIshemiaId { get; set; }

        [Display(Name = "ZoneName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ZoneName { get; set; }

        [Display(Name = "ZoneInfarctionId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? ZoneInfarctionId { get; set; }

        [Display(Name = "ZoneName1", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ZoneName1 { get; set; }

        [Display(Name = "LaunId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? LaunId { get; set; }

        [Display(Name = "LaunName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string LaunName { get; set; }

        [Display(Name = "PAC", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public Boolean? PAC { get; set; }

        [Display(Name = "ConductionDisturbanceId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? ConductionDisturbanceId { get; set; }

        [Display(Name = "ConductionDisturbanceName", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string ConductionDisturbanceName { get; set; }

        [Display(Name = "BBBId", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public int? BBBId { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalECG))]
        public string Comment { get; set; }
    }
}