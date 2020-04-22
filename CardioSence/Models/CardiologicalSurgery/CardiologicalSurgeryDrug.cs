using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalSurgeryDrug
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalSurgeryDrugId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryDrugId { get; set; }

        [ForeignKey("CardiologicalSurgery")]
        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }
        public CardiologicalSurgery CardiologicalSurgery { get; set; }

        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DrugId { get; set; }

        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DrugFrequencyId { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Duration { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}