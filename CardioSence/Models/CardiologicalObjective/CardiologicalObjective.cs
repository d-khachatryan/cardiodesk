using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalObjective
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalObjectiveId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int CardiologicalObjectiveId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ConsultationDate", ResourceType = typeof(Resources.rsResident))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalObjectiveDate", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public DateTime? CardiologicalObjectiveDate { get; set; }

        //[Display(Name = "Temperature", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public double? Temperature { get; set; }

        //[Display(Name = "Pulse", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? Pulse { get; set; }

        //[Display(Name = "RNIBP", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string RNIBP { get; set; }

        //[Display(Name = "LNIBP", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LNIBP { get; set; }

        //[Display(Name = "LungId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LungId { get; set; }

        //[Display(Name = "HeartSoundTypeId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? HeartSoundTypeId { get; set; }

        //[Display(Name = "HeartMurmurTypeId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? HeartMurmurTypeId { get; set; }

        //[Display(Name = "RCBId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RCBId { get; set; }

        //[Display(Name = "LCBId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LCBId { get; set; }

        //[Display(Name = "AbdominalStatusId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? AbdominalStatusId { get; set; }

        //[Display(Name = "LiverId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LiverId { get; set; }

        //[Display(Name = "RRAId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RRAId { get; set; }

        //[Display(Name = "LRAId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LRAId { get; set; }

        //[Display(Name = "RADPId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RADPId { get; set; }

        //[Display(Name = "LADPId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LADPId { get; set; }

        //[Display(Name = "PeripherialStatusId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? PeripherialStatusId { get; set; }

        //[Display(Name = "PhysicianId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? PhysicianId { get; set; }

        //Ենթաաղյուսակների բաժին
        public virtual ICollection<CardiologicalObjectiveDrug> CardiologicalObjectiveDrugs { get; set; }
    }
}