
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class BloodProduct
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int BloodProductId { get; set; }
        [Display(Name = "Name")]
        public string BloodProductName { get; set; }
    }
}