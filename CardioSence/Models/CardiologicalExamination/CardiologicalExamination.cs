using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    public class CardiologicalExamination
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "CardiologicalExaminationId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int CardiologicalExaminationId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? ResidentId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "CardiologicalExaminationDate", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public DateTime? CardiologicalExaminationDate { get; set; }

        //[Display(Name = "BloodGroupId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? BloodGroupId { get; set; }

        //[Display(Name = "RhFactorId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? RhFactorId { get; set; }

        //[Display(Name = "T3", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? T3 { get; set; }

        //[Display(Name = "T4", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? T4 { get; set; }

        //[Display(Name = "TTH", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? TTH { get; set; }

        //[Display(Name = "CRP", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? CRP { get; set; }

        //[Display(Name = "RF", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? RF { get; set; }

        //[Display(Name = "ASLO", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? ASLO { get; set; }

        //[Display(Name = "HIVStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? HIVStatusId { get; set; }

        //[Display(Name = "HBSStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? HBSStatusId { get; set; }

        //[Display(Name = "HCVStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? HCVStatusId { get; set; }

        //[Display(Name = "TPHAStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? TPHAStatusId { get; set; }

        //[Display(Name = "BRUStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? BRUStatusId { get; set; }

        //[Display(Name = "Hb", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Hb { get; set; }

        //[Display(Name = "RBC", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? RBC { get; set; }

        //[Display(Name = "FI", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? FI { get; set; }

        //[Display(Name = "MeanHbRBC", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? MeanHbRBC { get; set; }

        //[Display(Name = "HCT", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? HCT { get; set; }

        //[Display(Name = "Platelete", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Platelete { get; set; }

        //[Display(Name = "Leukocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Leukocyte { get; set; }

        //[Display(Name = "Myelocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Myelocyte { get; set; }

        //[Display(Name = "Metamyelocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Metamyelocyte { get; set; }

        //[Display(Name = "StabLeukocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? StabLeukocyte { get; set; }

        //[Display(Name = "SegmentedLeukocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? SegmentedLeukocyte { get; set; }

        //[Display(Name = "Eosinophil", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Eosinophil { get; set; }

        //[Display(Name = "Basophil", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Basophil { get; set; }

        //[Display(Name = "Lymphocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Lymphocyte { get; set; }

        //[Display(Name = "Monocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Monocyte { get; set; }

        //[Display(Name = "ESR", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? ESR { get; set; }

        //[Display(Name = "ProteinTotal", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? ProteinTotal { get; set; }

        //[Display(Name = "albumin", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? albumin { get; set; }

        //[Display(Name = "Urea", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Urea { get; set; }

        //[Display(Name = "Creatinine", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Creatinine { get; set; }

        //[Display(Name = "UricAcid", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? UricAcid { get; set; }

        //[Display(Name = "Glucose", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Glucose { get; set; }

        //[Display(Name = "BilirubinTotal", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? BilirubinTotal { get; set; }

        //[Display(Name = "BilirubinDirect", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? BilirubinDirect { get; set; }

        //[Display(Name = "ALT", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? ALT { get; set; }

        //[Display(Name = "AST", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? AST { get; set; }

        //[Display(Name = "Potassium", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Potassium { get; set; }

        //[Display(Name = "Sodium", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Sodium { get; set; }

        //[Display(Name = "Calcium", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Calcium { get; set; }

        //[Display(Name = "AAmilaza", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? AAmilaza { get; set; }

        //[Display(Name = "CK", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? CK { get; set; }

        //[Display(Name = "CKMB", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? CKMB { get; set; }

        //[Display(Name = "TroponinStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? TroponinStatusId { get; set; }

        //[Display(Name = "Cholesterol", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Cholesterol { get; set; }

        //[Display(Name = "Triglyceride", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? Triglyceride { get; set; }

        //[Display(Name = "HDL", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? HDL { get; set; }

        //[Display(Name = "LDL", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? LDL { get; set; }

        //[Display(Name = "PT", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? PT { get; set; }

        //[Display(Name = "INR", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? INR { get; set; }

        //[Display(Name = "PI", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? PI { get; set; }

        //[Display(Name = "APTT", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public double? APTT { get; set; }

        //[Display(Name = "Fibrinogen", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? Fibrinogen { get; set; }

        //[Display(Name = "UrineProtein", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineProtein { get; set; }

        //[Display(Name = "UrineLeucocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineLeucocyte { get; set; }

        //[Display(Name = "UrineErithrocyte", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineErithrocyte { get; set; }

        //[Display(Name = "UrineDensity", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineDensity { get; set; }

        //[Display(Name = "UrineCylinderStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineCylinderStatusId { get; set; }

        //[Display(Name = "UrineMicroorganismStatusId", ResourceType = typeof(Resources.rsCardiologicalExamination))]
        public int? UrineMicroorganismStatusId { get; set; }
    }
}