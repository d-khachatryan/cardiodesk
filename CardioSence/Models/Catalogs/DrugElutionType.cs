using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class DrugElutionType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DrugElutionTypeId { get; set; }
        [Display(Name = "Name")]
        public string DrugElutionTypeName { get; set; }
    }
}