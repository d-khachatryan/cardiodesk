using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class Segment
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int SegmentId { get; set; }
        [Display(Name = "Name")]
        public string SegmentName { get; set; }
    }
}