using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalSurgeryComplication")]
    public class CardiologicalSurgeryComplicationItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalSurgeryComplicationId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryComplicationId { get; set; }

        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardiologicalSurgeryId { get; set; }

        [Display(Name = "ComplicationId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ComplicationId { get; set; }

        [Display(Name = "ComplicationName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string ComplicationName { get; set; }
    }
}