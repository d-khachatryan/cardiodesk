using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class AlcoholUsage
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int AlcoholUsageId { get; set; }
        [Display(Name = "Name")]
        public string AlcoholUsageName { get; set; }
    }
}