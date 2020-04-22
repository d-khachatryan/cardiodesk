using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class InfectiousEndocarditis
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int InfectiousEndocarditisId { get; set; }
        [Display(Name = "Name")]
        public string InfectiousEndocarditisName { get; set; }

    }
}