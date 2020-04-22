using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CardioSence.Models
{
    public class TPHAStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int TPHAStatusId { get; set; }
        [Display(Name = "Name")]
        public string TPHAStatusName { get; set; }
    }
}