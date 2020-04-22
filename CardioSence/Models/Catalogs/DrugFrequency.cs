using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class DrugFrequency
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DrugFrequencyId { get; set; }
        [Display(Name = "Name")]
        public string DrugFrequencyName { get; set; }

    }
}