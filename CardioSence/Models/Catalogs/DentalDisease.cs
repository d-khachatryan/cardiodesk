using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class DentalDisease
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DentalDiseaseId { get; set; }
        [Display(Name = "Name")]
        public string DentalDiseaseName { get; set; }

    }
}