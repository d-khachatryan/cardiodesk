using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalDuplexScan
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalDuplexScanId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int CardiologicalDuplexScanId { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalDuplexScanDate", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public DateTime? CardiologicalDuplexScanDate { get; set; }

        //[Display(Name = "RCAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCAStenosisId { get; set; }

        //[Display(Name = "RCAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCAStenosisDM { get; set; }

        //[Display(Name = "RCAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCAStenosisPC { get; set; }

        //[Display(Name = "LSAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LSAStenosisId { get; set; }

        //[Display(Name = "LSAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LSAStenosisDM { get; set; }

        //[Display(Name = "LSAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LSAStenosisPC { get; set; }

        //[Display(Name = "RCCStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCCStenosisId { get; set; }

        //[Display(Name = "RCCStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCCStenosisDM { get; set; }

        //[Display(Name = "RCCStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCCStenosisPC { get; set; }

        //[Display(Name = "LCCStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCCStenosisId { get; set; }

        //[Display(Name = "LCCStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCCStenosisDM { get; set; }

        //[Display(Name = "LCCStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCCStenosisPC { get; set; }

        //[Display(Name = "RCIStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCIStenosisId { get; set; }

        //[Display(Name = "RCIStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCIStenosisDM { get; set; }

        //[Display(Name = "RCIStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCIStenosisPC { get; set; }

        //[Display(Name = "LCIStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCIStenosisId { get; set; }

        //[Display(Name = "LCIStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCIStenosisDM { get; set; }

        //[Display(Name = "LCIStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCIStenosisPC { get; set; }

        //[Display(Name = "RCEStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCEStenosisId { get; set; }

        //[Display(Name = "RCEStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCEStenosisDM { get; set; }

        //[Display(Name = "RCEStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RCEStenosisPC { get; set; }

        //[Display(Name = "LCEStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCEStenosisId { get; set; }

        //[Display(Name = "LCEStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCEStenosisDM { get; set; }

        //[Display(Name = "LCEStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LCEStenosisPC { get; set; }

        //[Display(Name = "RVAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RVAStenosisId { get; set; }

        //[Display(Name = "RVAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RVAStenosisDM { get; set; }

        //[Display(Name = "RVAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? RVAStenosisPC { get; set; }

        //[Display(Name = "LVAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LVAStenosisId { get; set; }

        //[Display(Name = "LVAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LVAStenosisDM { get; set; }

        //[Display(Name = "LVAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public double? LVAStenosisPC { get; set; }

    }
}