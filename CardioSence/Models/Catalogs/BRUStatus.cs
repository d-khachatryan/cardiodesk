using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class BRUStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int BRUStatusId { get; set; }
        [Display(Name = "Name")]
        public string BRUStatusName { get; set; }
    }
}