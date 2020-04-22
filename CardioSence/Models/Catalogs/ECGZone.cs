using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class ECGZone
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ECGZoneId { get; set; }
        [Display(Name = "Name")]
        public string ECGZoneName { get; set; }
    }
}