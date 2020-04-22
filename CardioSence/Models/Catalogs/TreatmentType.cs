using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class TreatmentType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int TreatmentTypeId { get; set; }
        [Display(Name = "Name")]
        public string TreatmentTypeName { get; set; }

    }
}