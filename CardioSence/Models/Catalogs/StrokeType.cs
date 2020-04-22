using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class StrokeType
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int StrokeTypeId { get; set; }
        [Display(Name = "Name")]
        public string StrokeTypeName { get; set; }

    }
}