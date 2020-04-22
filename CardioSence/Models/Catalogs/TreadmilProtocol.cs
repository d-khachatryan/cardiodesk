using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class TreadmilProtocol
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int TreadmilProtocolId { get; set; }
        [Display(Name = "Name")]
        public string TreadmilProtocolName { get; set; }
    }
}