using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalObjectiveDrug")]
    public class CardiologicalObjectiveDrugItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalObjectiveDrugId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int CardiologicalObjectiveDrugId { get; set; }

        [Display(Name = "CardiologicalObjectiveId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? CardiologicalObjectiveId { get; set; }

        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? DrugId { get; set; }

        [Display(Name = "DrugName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string DrugName { get; set; }

        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? DrugFrequencyId { get; set; }

        [Display(Name = "DrugFrequencyName", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public string DrugFrequencyName { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? Duration { get; set; }
    }
}