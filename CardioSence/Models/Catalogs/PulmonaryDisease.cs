using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
	public class PulmonaryDisease
	{

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int PulmonaryDiseaseId { get; set; }
        [Display(Name = "Name")]
        public string PulmonaryDiseaseName { get; set; }

    }
}