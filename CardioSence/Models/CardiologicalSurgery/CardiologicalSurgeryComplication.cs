using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalSurgeryComplication
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalSurgeryComplicationId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryComplicationId { get; set; }

        [ForeignKey("CardiologicalSurgery")]
        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }
        public CardiologicalSurgery CardiologicalSurgery { get; set; }

        [Display(Name = "ComplicationId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ComplicationId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}