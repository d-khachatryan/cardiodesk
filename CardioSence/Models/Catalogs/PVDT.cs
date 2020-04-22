using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class PVDT
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int PVDTId { get; set; }
        [Display(Name = "Name")]
        public string PVDTName { get; set; }

    }
}