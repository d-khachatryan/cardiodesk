using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class DeathCause
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DeathCauseId { get; set; }
        [Display(Name = "Name")]
        public string DeathCauseName { get; set; }

    }
}