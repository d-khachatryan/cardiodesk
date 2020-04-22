using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    [Table("vwResidentInfo")]
    public class ResidentInfo
    {
        [Key]
        public int ResidentId { get; set; }        

        [Display(Name = "Resident Name")]
        public string ResidentName { get; set; }
    }
}