using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CardioSence.Models
{
    public class PeripherialStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int PeripherialStatusId { get; set; }
        [Display(Name = "Name")]
        public string PeripherialStatusName { get; set; }
    }
}