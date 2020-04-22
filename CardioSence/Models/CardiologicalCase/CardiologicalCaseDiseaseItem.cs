using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CardioSence.Models
{
    [Table("vwCardiologicalCaseDisease")]
    public class CardiologicalCaseDiseaseItem
    {
        [Key]
        [Display(Name = "CardiologicalCaseDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseDiseaseId { get; set; }

        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }

        [Display(Name = "DiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DiseaseId { get; set; }

        [Display(Name = "DiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DiseaseName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DiseaseDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public DateTime? DiseaseDate { get; set; }

        [Display(Name = "OrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? OrganizationId { get; set; }

        [Display(Name = "OrganizationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string OrganizationName { get; set; }
    }
}