using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
	public class RelativeStatus
	{
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int RelativeStatusId { get; set; }
        [Display(Name = "Name")]
        public string RelativeStatusName { get; set; }

    }
}