using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class BloodCholesterol
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int BloodCholesterolId { get; set; }
        [Display(Name = "Name")]
        public string BloodCholesterolName { get; set; }
    }
}