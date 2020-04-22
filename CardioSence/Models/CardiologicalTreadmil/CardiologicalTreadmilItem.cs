using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalTreadmil")]
    public class CardiologicalTreadmilItem
    {
        [Key]
        [Display(Name = "CardiologicalTreadmilId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int CardiologicalTreadmilId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        [Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CardiologicalTreadmilDate", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public DateTime? CardiologicalTreadmilDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.rsResident))]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "ResidentName", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string ResidentName { get; set; }

        [Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentLastName { get; set; }

        [Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentFirstName { get; set; }

        [Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentPatronymicName { get; set; }

        [Display(Name = "PatientId", ResourceType = typeof(Resources.rsResident))]
        public int? PatientId { get; set; }

        [Display(Name = "TreadmilProtocolId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? TreadmilProtocolId { get; set; }

        [Display(Name = "TreadmilProtocolId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string TreadmilProtocolName { get; set; }

        [Display(Name = "METSAchieved", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public double? METSAchieved { get; set; }

        [Display(Name = "TreadmilResultId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? TreadmilResultid { get; set; }

        [Display(Name = "TreadmilResultId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string TreadmilResultName { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string Comment { get; set; }
    }
}