using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class TroponinStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int TroponinStatusId { get; set; }
        [Display(Name = "Name")]
        public string TroponinStatusName { get; set; }
    }
}