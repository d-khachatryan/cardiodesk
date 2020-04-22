using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CardioSence.Models
{
    [Table("vwCardiologicalCaseComplian")]
    public class CardiologicalCaseComplianItem
    {
        [Key]
        [Display(Name = "CardiologicalCaseComplianId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseComplianId { get; set; }

        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }

        [Display(Name = "ComplianId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ComplianId { get; set; }

        [Display(Name = "ComplianName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string ComplianName { get; set; }
    }
}