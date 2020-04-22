using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class EchoCGZone
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int? EchoCGZoneId { get; set; }
        [Display(Name = "Name")]
        public string EchoCGZoneName { get; set; }
    }
}