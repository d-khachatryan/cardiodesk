using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class HIVStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HIVStatusId { get; set; }
        [Display(Name = "Name")]
        public string HIVStatusName { get; set; }
    }
}