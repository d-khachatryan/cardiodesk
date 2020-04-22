using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class HBSStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HBSStatusId { get; set; }
        [Display(Name = "Name")]
        public string HBSStatusName { get; set; }
    }
}