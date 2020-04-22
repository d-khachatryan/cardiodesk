using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalEchoCG
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalEchoCGId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int CardiologicalEchoCGId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalEchoCGDate", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public DateTime? CardiologicalEchoCGDate { get; set; }

        //[Display(Name = "AOD", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? AOD { get; set; }

        //[Display(Name = "LAD", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LAD { get; set; }

        //[Display(Name = "RVDD", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? RVDD { get; set; }

        //[Display(Name = "LVSD", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LVSD { get; set; }

        //[Display(Name = "LVDD", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LVDD { get; set; }

        //[Display(Name = "LVPW", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LVPW { get; set; }

        //[Display(Name = "LVSV", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LVSV { get; set; }

        //[Display(Name = "LVDV", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? LVDV { get; set; }

        //[Display(Name = "IVSW", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? IVSW { get; set; }

        //[Display(Name = "SV", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? SV { get; set; }

        //[Display(Name = "EF", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public int? EF { get; set; }

        //[Display(Name = "PAACTET", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? PAACTET { get; set; }

        //[Display(Name = "MenaPAP", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? MenaPAP { get; set; }

        //[Display(Name = "PeakPAP", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? PeakPAP { get; set; }

        //[Display(Name = "PericardialAnteriorSeparation", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public double? PericardialAnteriorSeparation { get; set; }

        //[Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string Comment { get; set; }

        //[Display(Name = "CardiologicalEchoCGMoviePath", ResourceType = typeof(Resources.rsCardiologicalEchoCG))]
        public string CardiologicalEchoCGMoviePath { get; set; }

        //Ենթաաղյուսակների բաժին
        public virtual ICollection<CardiologicalEchoCGVelocity> CardiologicalEchoCGVelocitys { get; set; }
        public virtual ICollection<CardiologicalEchoCGWall> CardiologicalEchoCGWalls { get; set; }

    }
}