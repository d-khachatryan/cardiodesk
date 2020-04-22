using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCaseDrug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalCaseDrugId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseDrugId { get; set; }

        [ForeignKey("CardiologicalCase")]
        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }
        public CardiologicalCase CardiologicalCase { get; set; }

        [UIHint("Drug")]
        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DrugId { get; set; }

        [UIHint("DrugFrequency")]
        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DrugFrequencyId { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? Duration { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}