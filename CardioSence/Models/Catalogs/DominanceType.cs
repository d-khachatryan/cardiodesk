using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class DominanceType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DominanceTypeId { get; set; }
        [Display(Name = "Name")]
        public string DominanceTypeName { get; set; }
    }
}