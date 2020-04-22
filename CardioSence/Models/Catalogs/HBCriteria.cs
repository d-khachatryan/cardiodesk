using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class HBCriteria
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HBCriteriaId { get; set; }
        [Display(Name = "Name")]
        public string HBCriteriaName { get; set; }

    }
}