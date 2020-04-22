using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class HeartSoundType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HeartSoundTypeId { get; set; }
        [Display(Name = "Name")]
        public string HeartSoundTypeName { get; set; }

    }
}