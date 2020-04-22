using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalEchoCGWall
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalEchoCGWallId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int CardiologicalEchoCGWallId { get; set; }

        [ForeignKey("CardiologicalEchoCG")]        
        [Display(Name = "CardiologicalEchoCGId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGId { get; set; }
        public CardiologicalEchoCG CardiologicalEchoCG { get; set; }

        [UIHint("EchoCGZone")]
        [Display(Name = "EchoCGZoneId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? EchoCGZoneId { get; set; }

        [UIHint("Contractility")]
        [Display(Name = "ContractilityId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? ContractilityId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}