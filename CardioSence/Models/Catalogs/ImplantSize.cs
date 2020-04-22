using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class ImplantSize
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ImplantSizeId { get; set; }
        [Display(Name = "Name")]
        public string ImplantSizeName { get; set; }
    }
}