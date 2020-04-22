using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    public class RhythmType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int RhythmTypeId { get; set; }
        [Display(Name = "Name")]
        public string RhythmTypeName { get; set; }
    }
}