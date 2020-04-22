using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class RheumatizmDuration
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int RheumatizmDurationId { get; set; }
        [Display(Name = "Name")]
        public string RheumatizmDurationName { get; set; }

    }
}