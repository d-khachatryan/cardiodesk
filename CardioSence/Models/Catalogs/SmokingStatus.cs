﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class SmokingStatus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int SmokingStatusId { get; set; }
        [Display(Name = "Name")]
        public string SmokingStatusName { get; set; }

    }
}