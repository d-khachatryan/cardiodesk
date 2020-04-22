using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class UrineMicroorganismStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int UrineMicroorganismStatusId { get; set; }
        [Display(Name = "Name")]
        public string UrineMicroorganismStatusName { get; set; }
    }
}