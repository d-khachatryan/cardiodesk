using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class ConductionDisturbance
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ConductionDisturbanceId { get; set; }
        [Display(Name = "Name")]
        public string ConductionDisturbanceName { get; set; }
    }
}