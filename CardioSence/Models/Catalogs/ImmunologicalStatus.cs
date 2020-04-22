using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class ImmunologicalStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ImmunologicalStatusId { get; set; }
        [Display(Name = "Name")]
        public string ImmunologicalStatusName { get; set; }

    }
}