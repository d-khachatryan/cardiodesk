using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    [Table("vwCardiologicalCaseDrug")]
    public class CardiologicalCaseDrugItem
    {
        [Key]
        [Display(Name = "CardiologicalCaseDrugId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseDrugId { get; set; }

        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }

        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DrugId { get; set; }

        [Display(Name = "DrugName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DrugName { get; set; }


        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DrugFrequencyId { get; set; }


        [Display(Name = "DrugFrequencyName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DrugFrequencyName { get; set; }


        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? Duration { get; set; }
    }
}