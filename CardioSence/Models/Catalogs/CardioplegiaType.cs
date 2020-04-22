

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardioplegiaType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int CardioplegiaTypeId { get; set; }
        [Display(Name = "Name")]
        public string CardioplegiaTypeName { get; set; }
    }
}