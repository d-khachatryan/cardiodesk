using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class OtherDisease
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int OtherDiseaseId { get; set; }
        [Display(Name = "Name")]
        public string OtherDiseaseName { get; set; }

    }
}