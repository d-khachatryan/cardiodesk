using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalTreadmil
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalTreadmilId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int CardiologicalTreadmilId { get; set; }


        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalTreadmilDate", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public DateTime? CardiologicalTreadmilDate { get; set; }

        //[Display(Name = "TreadmilProtocolId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? TreadmilProtocolId { get; set; }

        //[Display(Name = "METSAchieved", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public double? METSAchieved { get; set; }

        //[Display(Name = "TreadmilResultId", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public int? TreadmilResultid { get; set; }

        //[Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string Comment { get; set; }
    }
}