using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class TreadmilResult
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int TreadmilResultId { get; set; }
        [Display(Name = "Name")]
        public string TreadmilResultName { get; set; }
    }
}