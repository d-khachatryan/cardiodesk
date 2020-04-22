using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class DuplexStenosis
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DuplexStenosisId { get; set; }
        [Display(Name = "Name")]
        public string DuplexStenosisName { get; set; }
    }
}