using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CardioSence.Models
{
    public class HIT
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HITId { get; set; }
        [Display(Name = "Name")]
        public string HITName { get; set; }

    }
}