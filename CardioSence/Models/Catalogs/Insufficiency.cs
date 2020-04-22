using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class Insufficiency
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int InsufficiencyId { get; set; }
        [Display(Name = "Name")]
        public string InsufficiencyName { get; set; }
    }
}