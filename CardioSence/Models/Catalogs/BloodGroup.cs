using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class BloodGroup
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int BloodGroupId { get; set; }
        [Display(Name = "Name")]
        public string BloodGroupName { get; set; }
    }
}