using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCaseDisease
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CardiologicalCaseDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseDiseaseId { get; set; }

        [ForeignKey("CardiologicalCase")]
        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }
        public CardiologicalCase CardiologicalCase { get; set; }

        [UIHint("Disease")]
        [Display(Name = "DiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DiseaseId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DiseaseDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public DateTime? DiseaseDate { get; set; }

        [UIHint("Organization")]
        [Display(Name = "OrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? OrganizationId { get; set; }

        [NotMapped]
        public int? RecordStatus { get; set; }
    }
}