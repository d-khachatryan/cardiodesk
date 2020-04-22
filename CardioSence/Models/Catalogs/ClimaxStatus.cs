using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class ClimaxStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ClimaxStatusId { get; set; }
        [Display(Name = "Name")]
        public string ClimaxStatusName { get; set; }
    }
}