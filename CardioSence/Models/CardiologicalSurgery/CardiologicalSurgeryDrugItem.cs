using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalSurgeryDrug")]
    public class CardiologicalSurgeryDrugItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalSurgeryDrugId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryDrugId { get; set; }

        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }

        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DrugId { get; set; }

        [Display(Name = "DrugName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string DrugName { get; set; }

        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DrugFrequencyId { get; set; }

        [Display(Name = "DrugFrequencyName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string DrugFrequencyName { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Duration { get; set; }
    }
}