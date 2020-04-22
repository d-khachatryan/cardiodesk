using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalObjective")]
    public class CardiologicalObjectiveItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalObjectiveId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int CardiologicalObjectiveId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        [Display(Name = "ResidentId", ResourceType = typeof(Resources.rsResident))]
        public int? ResidentId { get; set; }

        // էս մասը լոկալիզացիան արդեն դրվածա
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.rsResident))]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "ResidentName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentName { get; set; }

        [Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentLastName { get; set; }

        [Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentFirstName { get; set; }

        [Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentPatronymicName { get; set; }

        [Display(Name = "PatientId", ResourceType = typeof(Resources.rsResident))]
        public int? PatientId { get; set; }
        // էս մասը լոկալիզացիան արդեն դրվածա

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CardiologicalObjectiveDate", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public DateTime? CardiologicalObjectiveDate { get; set; }

        [Display(Name = "Temperature", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public double? Temperature { get; set; }

        [Display(Name = "Pulse", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? Pulse { get; set; }

        [Display(Name = "RNIBP", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string RNIBP { get; set; }

        [Display(Name = "LNIBP", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LNIBP { get; set; }

        [Display(Name = "LungId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LungId { get; set; }

        [Display(Name = "LungName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LungName { get; set; }

        [Display(Name = "HeartSoundTypeId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? HeartSoundTypeId { get; set; }

        [Display(Name = "HeartSoundTypeName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string HeartSoundTypeName { get; set; }

        [Display(Name = "HeartMurmurTypeId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? HeartMurmurTypeId { get; set; }

        [Display(Name = "HeartMurmurTypeName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string HeartMurmurTypeName { get; set; }

        [Display(Name = "RCBId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RCBId { get; set; }

        [Display(Name = "RCBBruitName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string RCBBruitName { get; set; }

        [Display(Name = "LCBId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LCBId { get; set; }

        [Display(Name = "LCBBruitName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LCBBruitName { get; set; }

        [Display(Name = "AbdominalStatusId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? AbdominalStatusId { get; set; }

        [Display(Name = "AbdominalStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string AbdominalStatusName { get; set; }

        [Display(Name = "LiverId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LiverId { get; set; }

        [Display(Name = "LiverName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LiverName { get; set; }

        [Display(Name = "RRAId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RRAId { get; set; }

        [Display(Name = "RRAArteriaStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string RRAArteriaStatusName { get; set; }

        [Display(Name = "LRAId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LRAId { get; set; }

        [Display(Name = "LRAArteriaStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LRAArteriaStatusName { get; set; }

        [Display(Name = "RADPId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? RADPId { get; set; }

        [Display(Name = "RADArteriaStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string RADArteriaStatusName { get; set; }

        [Display(Name = "LADPId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? LADPId { get; set; }

        [Display(Name = "LADArteriaStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string LADArteriaStatusName { get; set; }

        [Display(Name = "PeripherialStatusId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? PeripherialStatusId { get; set; }

        [Display(Name = "PeripherialStatusName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string PeripherialStatusName { get; set; }

        [Display(Name = "PhysicianId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? PhysicianId { get; set; }

        [Display(Name = "PhysicianName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string PhysicianName { get; set; }
    }
}