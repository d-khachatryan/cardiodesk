using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalDuplexScan")]
    public class CardiologicalDuplexScanItem
    {
        [Key]
        [Display(Name = "CardiologicalDuplexScanId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int CardiologicalDuplexScanId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        [Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.rsResident))]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "ResidentName", ResourceType = typeof(Resources.rsCardiologicalTreadmil))]
        public string ResidentName { get; set; }

        [Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentLastName { get; set; }

        [Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentFirstName { get; set; }

        [Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentPatronymicName { get; set; }

        [Display(Name = "PatientId", ResourceType = typeof(Resources.rsResident))]
        public int? PatientId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CardiologicalDuplexScanDate", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public DateTime? CardiologicalDuplexScanDate { get; set; }

        [Display(Name = "RCAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCAStenosisId { get; set; }

        [Display(Name = "RCAStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string RCAStenosisName { get; set; }

        [Display(Name = "RCAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCAStenosisDM { get; set; }

        [Display(Name = "RCAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCAStenosisPC { get; set; }

        [Display(Name = "LSAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LSAStenosisId { get; set; }

        [Display(Name = "LSAStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string LSAStenosisName { get; set; }

        [Display(Name = "LSAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LSAStenosisDM { get; set; }

        [Display(Name = "LSAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LSAStenosisPC { get; set; }

        [Display(Name = "RCCStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCCStenosisId { get; set; }

        [Display(Name = "RCCStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string RCCStenosisName { get; set; }

        [Display(Name = "RCCStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCCStenosisDM { get; set; }

        [Display(Name = "RCCStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCCStenosisPC { get; set; }

        [Display(Name = "LCCStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCCStenosisId { get; set; }

        [Display(Name = "LCCStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string LCCStenosisName { get; set; }

        [Display(Name = "LCCStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCCStenosisDM { get; set; }

        [Display(Name = "LCCStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCCStenosisPC { get; set; }

        [Display(Name = "RCIStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCIStenosisId { get; set; }

        [Display(Name = "RCIStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string RCIStenosisName { get; set; }

        [Display(Name = "RCIStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public bool? RCIStenosisDM { get; set; }

        [Display(Name = "RCIStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCIStenosisPC { get; set; }

        [Display(Name = "LCIStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCIStenosisId { get; set; }

        [Display(Name = "LCIStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string LCIStenosisName { get; set; }

        [Display(Name = "LCIStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCIStenosisDM { get; set; }

        [Display(Name = "LCIStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCIStenosisPC { get; set; }

        [Display(Name = "RCEStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RCEStenosisId { get; set; }

        [Display(Name = "RCEStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string RCEStenosisName { get; set; }

        [Display(Name = "RCEStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCEStenosisDM { get; set; }

        [Display(Name = "RCEStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RCEStenosisPC { get; set; }

        [Display(Name = "LCEStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LCEStenosisId { get; set; }

        [Display(Name = "LCEStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string LCEStenosisName { get; set; }

        [Display(Name = "LCEStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCEStenosisDM { get; set; }

        [Display(Name = "LCEStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LCEStenosisPC { get; set; }

        [Display(Name = "RVAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? RVAStenosisId { get; set; }

        [Display(Name = "RVAStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string RVAStenosisName { get; set; }

        [Display(Name = "RVAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RVAStenosisDM { get; set; }

        [Display(Name = "RVAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? RVAStenosisPC { get; set; }

        [Display(Name = "LVAStenosisId", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public int? LVAStenosisId { get; set; }

        [Display(Name = "LVAStenosisName", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public string LVAStenosisName { get; set; }

        [Display(Name = "LVAStenosisDM", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LVAStenosisDM { get; set; }

        [Display(Name = "LVAStenosisPC", ResourceType = typeof(Resources.rsCardiologicalDuplexScan))]
        public float? LVAStenosisPC { get; set; }
    }
}