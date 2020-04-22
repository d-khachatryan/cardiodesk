using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalPCI")]
    public class CardiologicalPCIItem
    {
        [Key]
        [Display(Name = "CardiologicalPCIId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int CardiologicalPCIId { get; set; }

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
        [Display(Name = "CardiologicalPCIDate", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public DateTime? CardiologicalPCIDate { get; set; }

        [Display(Name = "PhysicianId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? PhysicianId { get; set; }

        [Display(Name = "PhysicianName", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string PhysicianName { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string Comment { get; set; }

        [Display(Name = "PCIMovieURL", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string PCIMovieURL { get; set; }

        [Display(Name = "PCIImageURL", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string PCIImageURL { get; set; }

    }
}