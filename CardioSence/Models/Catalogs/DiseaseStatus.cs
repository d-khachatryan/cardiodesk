using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class DiseaseStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DiseaseStatusId { get; set; }
        [Display(Name = "Name")]
        public string DiseaseStatusName { get; set; }

    }
}