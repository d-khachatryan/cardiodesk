
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class ArteriaStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ArteriaStatusId { get; set; }
        [Display(Name = "Name")]
        public string ArteriaStatusName { get; set; }
    }
}