using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class UrineCylinderStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int UrineCylinderStatusId { get; set; }
        [Display(Name = "Name")]
        public string UrineCylinderStatusName { get; set; }
    }
}