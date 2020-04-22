using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class ReferralPhysician
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ReferralPhysicianId { get; set; }
        [Display(Name = "Name")]
        public string ReferralPhysicianName { get; set; }

    }
}