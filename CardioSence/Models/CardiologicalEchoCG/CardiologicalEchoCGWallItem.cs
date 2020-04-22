using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalEchoCGWall")]
    public class CardiologicalEchoCGWallItem
    {
        [Key]
        [Display(Name = "CardiologicalEchoCGWallId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGWallId { get; set; }

        [Display(Name = "CardiologicalEchoCGId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? CardiologicalEchoCGId { get; set; }

        [Display(Name = "EchoCGZoneId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? EchoCGZoneId { get; set; }

        [Display(Name = "EchoCGZoneName", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string EchoCGZoneName { get; set; }

        [Display(Name = "ContractilityId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? ContractilityId { get; set; }

        [Display(Name = "ContractilityName", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string ContractilityName { get; set; }
    }
}