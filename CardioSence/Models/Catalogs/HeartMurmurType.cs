using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class HeartMurmurType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int HeartMurmurTypeId { get; set; }
        [Display(Name = "Name")]
        public string HeartMurmurTypeName { get; set; }
    }
}