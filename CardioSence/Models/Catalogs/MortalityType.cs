using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class MortalityType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int MortalityTypeId { get; set; }
        [Display(Name = "Name")]
        public string MortalityTypeName { get; set; }

    }
}