using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class UrogenitalicDisease
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int UrogenitalicDiseaseId { get; set; }
        [Display(Name = "Name")]
        public string UrogenitalicDiseaseName { get; set; }

    }
}