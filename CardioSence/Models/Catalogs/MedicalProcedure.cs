﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class MedicalProcedure
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int MedicalProcedureId { get; set; }
        [Display(Name = "Name")]
        public string MedicalProcedureName { get; set; }
    }
}