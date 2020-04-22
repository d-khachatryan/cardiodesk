using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class SmokingType
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int SmokingTypeId { get; set; }
        [Display(Name = "Name")]
        public string SmokingTypeName { get; set; }

    }
}