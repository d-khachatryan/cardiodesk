using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class CaroticBruit
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int CaroticBruitId { get; set; }
        [Display(Name = "Name")]
        public string CaroticBruitName { get; set; }

    }
}