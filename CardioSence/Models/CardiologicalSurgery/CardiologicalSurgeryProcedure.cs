using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalSurgeryProcedure
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalSurgeryProcedureId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryProcedureId { get; set; }

        [ForeignKey("CardiologicalSurgery")]
        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }
        public CardiologicalSurgery CardiologicalSurgery { get; set; }

        [Display(Name = "MedicalProcedureId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? MedicalProcedureId { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string Comment { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}