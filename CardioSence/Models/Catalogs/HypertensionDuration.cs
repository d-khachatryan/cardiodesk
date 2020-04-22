using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class HypertensionDuration
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HypertensionDurationId { get; set; }
        [Display(Name = "Name")]
        public string HypertensionDurationName { get; set; }

    }
}