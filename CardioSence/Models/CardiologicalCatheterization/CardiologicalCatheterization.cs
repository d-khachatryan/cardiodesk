using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalCatheterization
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalCatheterizationId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int CardiologicalCatheterizationId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalCatheterizationDate", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public DateTime? CardiologicalCatheterizationDate { get; set; }

        //[Display(Name = "DominanceTypeId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? DominanceTypeId { get; set; }

        //[Display(Name = "LM", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? LM { get; set; }

        //[Display(Name = "LMStenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LMStenosis { get; set; }

        //[Display(Name = "LAD1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? LAD1 { get; set; }

        //[Display(Name = "LAD1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LAD1Stenosis { get; set; }

        //[Display(Name = "LAD2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? LAD2 { get; set; }

        //[Display(Name = "LAD2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LAD2Stenosis { get; set; }

        //[Display(Name = "LAD3", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? LAD3 { get; set; }

        //[Display(Name = "LAD3Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LAD3Stenosis { get; set; }

        //[Display(Name = "Diag1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Diag1 { get; set; }

        //[Display(Name = "Diag1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? Diag1Stenosis { get; set; }

        //[Display(Name = "Diag2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Diag2 { get; set; }

        //[Display(Name = "Diag2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? Diag2Stenosis { get; set; }

        //[Display(Name = "Cx1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Cx1 { get; set; }

        //[Display(Name = "Cx1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? Cx1Stenosis { get; set; }

        //[Display(Name = "Cx2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Cx2 { get; set; }

        //[Display(Name = "Cx2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? Cx2Stenosis { get; set; }

        //[Display(Name = "Cx3", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Cx3 { get; set; }

        //[Display(Name = "Cx3Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? Cx3Stenosis { get; set; }

        //[Display(Name = "Rm", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? Rm { get; set; }

        //[Display(Name = "RmStenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? RmStenosis { get; set; }

        //[Display(Name = "OM1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? OM1 { get; set; }

        //[Display(Name = "OM1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? OM1Stenosis { get; set; }

        //[Display(Name = "OM2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? OM2 { get; set; }

        //[Display(Name = "OM2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? OM2Stenosis { get; set; }

        //[Display(Name = "OM3", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? OM3 { get; set; }

        //[Display(Name = "OM3Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? OM3Stenosis { get; set; }

        //[Display(Name = "OM4", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? OM4 { get; set; }

        //[Display(Name = "OM4Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? OM4Stenosis { get; set; }

        //[Display(Name = "RCA1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? RCA1 { get; set; }

        //[Display(Name = "RCA1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? RCA1Stenosis { get; set; }

        //[Display(Name = "RCA2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? RCA2 { get; set; }

        //[Display(Name = "RCA2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? RCA2Stenosis { get; set; }

        //[Display(Name = "RCA3", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? RCA3 { get; set; }

        //[Display(Name = "RCA3Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? RCA3Stenosis { get; set; }

        //[Display(Name = "PDA", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? PDA { get; set; }

        //[Display(Name = "PDAStenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? PDAStenosis { get; set; }

        //[Display(Name = "PL1", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? PL1 { get; set; }

        //[Display(Name = "PL1Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? PL1Stenosis { get; set; }

        //[Display(Name = "PL2", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? PL2 { get; set; }

        //[Display(Name = "PL2Stenosis", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? PL2Stenosis { get; set; }

        //[Display(Name = "LVGraphy", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public bool? LVGraphy { get; set; }

        //[Display(Name = "LVEDP", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LVEDP { get; set; }

        //[Display(Name = "LVEDV", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LVEDV { get; set; }

        //[Display(Name = "LVESV", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LVESV { get; set; }

        //[Display(Name = "LVEF", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? LVEF { get; set; }

        //[Display(Name = "PhysicianId", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public int? PhysicianId { get; set; }

        //[Display(Name = "CatheterizationMovieURL", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public string CatheterizationMovieURL { get; set; }

        //[Display(Name = "CatheterizationImageURL", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public string CatheterizationImageURL { get; set; }

        //[Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalCatheterization))]
        public string Comment { get; set; }

        //Ենթաաղյուսակների բաժին
        public virtual ICollection<CardiologicalCatheterizationSegment> CardiologicalCatheterizationSegments { get; set; }
    }
}