using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCaseComplian
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalCaseComplianId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseComplianId { get; set; }

        [ForeignKey("CardiologicalCase")]
        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }
        public CardiologicalCase CardiologicalCase { get; set; }

        [UIHint("Complian")]
        [Display(Name = "ComplianId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ComplianId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }

    }
}