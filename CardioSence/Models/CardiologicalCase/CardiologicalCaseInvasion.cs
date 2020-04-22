using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCaseInvasion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalCaseInvasionId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseInvasionId { get; set; }

        [ForeignKey("CardiologicalCase")]
        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }
        public CardiologicalCase CardiologicalCase { get; set; }

        [UIHint("Invasion")]
        [Display(Name = "InvasionId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? InvasionId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "InvasionDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public DateTime? InvasionDate { get; set; }

        [UIHint("Organization")]
        [Display(Name = "OrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? OrganizationId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}