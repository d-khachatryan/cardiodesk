using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class GastrointestinalDisease
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int GastrointestinalDiseaseId { get; set; }
        [Display(Name = "Name")]
        public string GastrointestinalDiseaseName { get; set; }

    }
}