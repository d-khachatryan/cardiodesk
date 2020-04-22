using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CardioSence.Models
{
    public class LesionType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int LesionTypeId { get; set; }
        [Display(Name = "Name")]
        public string LesionTypeName { get; set; }
    }
}