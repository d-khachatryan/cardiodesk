using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    public class CardiologicalCPB
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalCPBId", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int CardiologicalCPBId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        //[Display(Name = "CPBDate", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public DateTime? CPBDate { get; set; }

        [DataType(DataType.Time)]
        //[Display(Name = "CPBTime", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public DateTime? CPBTime { get; set; }

        //[Display(Name = "SampleTypeId", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? SampleTypeId { get; set; }

        //[Display(Name = "MAP", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? MAP { get; set; }

        //[Display(Name = "RectalTemperature", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? RectalTemperature { get; set; }

        //[Display(Name = "ACT", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? ACT { get; set; }

        //[Display(Name = "FiO2", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? FiO2 { get; set; }

        //[Display(Name = "pH", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? pH { get; set; }

        //[Display(Name = "pO2", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? pO2 { get; set; }

        //[Display(Name = "pCO2", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? pCO2 { get; set; }

        //[Display(Name = "SO2", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? SO2 { get; set; }

        //[Display(Name = "Ht", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? Ht { get; set; }

        //[Display(Name = "Hb", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Hb { get; set; }

        //[Display(Name = "Na", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? Na { get; set; }

        //[Display(Name = "K", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? K { get; set; }

        //[Display(Name = "Cl", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Cl { get; set; }

        //[Display(Name = "Ca", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Ca { get; set; }

        //[Display(Name = "Mg", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Mg { get; set; }

        //[Display(Name = "BebTypeId", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? BebTypeId { get; set; }

        //[Display(Name = "BEB", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public int? BEB { get; set; }

        //[Display(Name = "HCO3", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? HCO3 { get; set; }

        //[Display(Name = "BUN", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? BUN { get; set; }

        //[Display(Name = "Lactosa", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Lactosa { get; set; }

        //[Display(Name = "Glucosa", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? Glucosa { get; set; }

        //[Display(Name = "IonGap", ResourceType = typeof(Resources.rsCardiologicalCPB))]
        public double? IonGap { get; set; }

    }
}