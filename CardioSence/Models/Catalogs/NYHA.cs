using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class NYHA
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int NYHAId { get; set; }
        [Display(Name = "Name")]
        public string NYHAName { get; set; }

    }
}