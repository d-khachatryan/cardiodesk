using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class Profession
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ProfessionId { get; set; }
        [Display(Name = "Name")]
        public string ProfessionName { get; set; }

    }
}