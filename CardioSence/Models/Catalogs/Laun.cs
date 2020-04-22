using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class Laun
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int LaunId { get; set; }
        [Display(Name = "Name")]
        public string LaunName { get; set; }
    }
}