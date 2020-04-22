using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CardioSence.Models
{
    public class CardiologicalPCI
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalPCIId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int CardiologicalPCIId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalPCIDate", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public DateTime? CardiologicalPCIDate { get; set; }

        //[Display(Name = "PhysicianId", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public int? PhysicianId { get; set; }

        //[Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string Comment { get; set; }

        //[Display(Name = "PCIMovieURL", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string PCIMovieURL { get; set; }

        //[Display(Name = "PCIImageURL", ResourceType = typeof(Resources.rsCardiologicalPCI))]
        public string PCIImageURL { get; set; }

        //Ենթաաղյուսակների բաժին
        public virtual ICollection<CardiologicalPCISegment> CardiologicalPCISegments { get; set; }
    }
}