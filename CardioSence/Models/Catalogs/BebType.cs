using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    public class BebType
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int BebTypeId { get; set; }

        [Display(Name = "Name")]
        public string BebTypeName { get; set; }
    }
}