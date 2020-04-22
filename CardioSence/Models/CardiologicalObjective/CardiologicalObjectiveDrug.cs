using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class CardiologicalObjectiveDrug
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalObjectiveDrugId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int CardiologicalObjectiveDrugId { get;set;}

        [ForeignKey("CardiologicalObjective")]
        [Display(Name = "CardiologicalObjectiveId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? CardiologicalObjectiveId { get; set; }
        public CardiologicalObjective CardiologicalObjective { get; set; }

        [UIHint("Drug")]
        [Display(Name = "DrugId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? DrugId { get; set; }

        [UIHint("DrugFrequency")]
        [Display(Name = "DrugFrequencyId", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? DrugFrequencyId { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalObjective))]
        public int? Duration { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }

    }
}