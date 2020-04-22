using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class Cadiomyopathy
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int CadiomyopathyId { get; set; }
        [Display(Name = "Name")]
        public string CadiomyopathyName { get; set; }

    }
}