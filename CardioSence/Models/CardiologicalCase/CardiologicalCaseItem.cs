using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardioSence.Models
{
    [Table("vwCardiologicalCase")]
    public class CardiologicalCaseItem
    {
        [Key]
        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseId { get; set; }

        [Display(Name = "ResidentId", ResourceType = typeof(Resources.rsResident))]
        public int? ResidentId { get; set; }

        // էս մասը լոկալիզացիան արդեն դրվածա
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.rsResident))]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "ResidentName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentName { get; set; }

        [Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentLastName { get; set; }

        [Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentFirstName { get; set; }

        [Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsResident))]
        public string ResidentPatronymicName { get; set; }

        [Display(Name = "PatientId", ResourceType = typeof(Resources.rsResident))]
        public int? PatientId { get; set; }
        // էս մասը լոկալիզացիան արդեն դրվածա

        [Display(Name = "OutPatient", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? OutPatient { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "ConsultationDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        [Required(ErrorMessage = "The field is required")]
        public DateTime? ConsultationDate { get; set; }

        [Display(Name = "InHospital", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? InHospital { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "StartDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        [Required(ErrorMessage = "The field is required")]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DischargeDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        [Required(ErrorMessage = "The field is required")]
        public DateTime? DischargeDate { get; set; }

        [Display(Name = "Duration", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? Duration { get; set; }

        [Display(Name = "CAD", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CAD { get; set; }

        [Display(Name = "CCSStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CCSStatus { get; set; }

        [Display(Name = "CCSId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CCSId { get; set; }

        [Display(Name = "CCSName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string CCSName { get; set; }

        [Display(Name = "HBCriteriaStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? HBCriteriaStatus { get; set; }

        [Display(Name = "HBCriteriaId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? HBCriteriaId { get; set; }

        [Display(Name = "HBCriteriaName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string HBCriteriaName { get; set; }

        [Display(Name = "HITStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? HITStatus { get; set; }

        [Display(Name = "HITId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? HITId { get; set; }

        [Display(Name = "HITName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string HITName { get; set; }

        [Display(Name = "NYHAId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? NYHAId { get; set; }

        [Display(Name = "NYHAName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string NYHAName { get; set; }

        [Display(Name = "ShockTypeStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? ShockTypeStatus { get; set; }

        [Display(Name = "ShockTypeId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ShockTypeId { get; set; }

        [Display(Name = "ShockTypeName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string ShockTypeName { get; set; }

        [Display(Name = "CATDStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CATDStatus { get; set; }

        [Display(Name = "CATDId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CATDId { get; set; }

        [Display(Name = "CATDName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string CATDName { get; set; }

        [Display(Name = "CHDStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CHDStatus { get; set; }

        [Display(Name = "CHDId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CHDId { get; set; }

        [Display(Name = "CHDName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string CHDName { get; set; }

        [Display(Name = "HVDStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? HVDStatus { get; set; }

        [Display(Name = "HVDId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? HVDId { get; set; }

        [Display(Name = "HVDName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string HVDName { get; set; }

        [Display(Name = "CadiomyopathyStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CadiomyopathyStatus { get; set; }

        [Display(Name = "CadiomyopathyId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CadiomyopathyId { get; set; }

        [Display(Name = "CadiomyopathyName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string CadiomyopathyName { get; set; }

        [Display(Name = "MainDiagnose", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string MainDiagnose { get; set; }

        [Display(Name = "OtherDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? OtherDiseaseId { get; set; }

        [Display(Name = "OtherDiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string OtherDiseaseName { get; set; }

        [Display(Name = "TreatmentTypeId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? TreatmentTypeId { get; set; }

        [Display(Name = "TreatmentTypeName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string TreatmentTypeName { get; set; }

        [Display(Name = "ReferralOrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ReferralOrganizationId { get; set; }

        [Display(Name = "ReferralOrganizationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string ReferralOrganizationName { get; set; }

        [Display(Name = "DeathStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? DeathStatus { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DeathDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public DateTime? DeathDate { get; set; }

        [Display(Name = "MortalityTypeId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? MortalityTypeId { get; set; }

        [Display(Name = "MortalityTypeName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string MortalityTypeName { get; set; }

        [Display(Name = "DeathCauseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DeathCauseId { get; set; }

        [Display(Name = "DeathCauseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DeathCauseName { get; set; }

        [Display(Name = "DeathOrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DeathOrganizationId { get; set; }

        [Display(Name = "DeathOrganizationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DeathOrganizationName { get; set; }

        [Display(Name = "Weight", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? Weight { get; set; }

        [Display(Name = "Height", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? Height { get; set; }

        [Display(Name = "BSA", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? BSA { get; set; }

        [Display(Name = "BMI", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? BMI { get; set; }

        [Display(Name = "SmokingStatusId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? SmokingStatusId { get; set; }

        [Display(Name = "SmokingStatusName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string SmokingStatusName { get; set; }

        [Display(Name = "MovementStatusId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? MovementStatusId { get; set; }

        [Display(Name = "MovementStatusName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string MovementStatusName{ get; set; }

        [Display(Name = "AlcoholUsageId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? AlcoholUsageId { get; set; }

        [Display(Name = "AlcoholUsageName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string AlcoholUsageName { get; set; }

        [Display(Name = "ImmunologicalStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? ImmunologicalStatus { get; set; }

        [Display(Name = "ImmunologicalStatusId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ImmunologicalStatusId { get; set; }

        [Display(Name = "ImmunologicalStatusName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string ImmunologicalStatusName { get; set; }

        [Display(Name = "CardiologicalInheritance", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? CardiologicalInheritance { get; set; }

        [Display(Name = "ClimaxStatusId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? ClimaxStatusId { get; set; }

        [Display(Name = "ClimaxStatusName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string ClimaxStatusName { get; set; }

        [Display(Name = "DiabetesMellitusStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? DiabetesMellitusStatus { get; set; }

        [Display(Name = "Glucose", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public double? Glucose { get; set; }

        [Display(Name = "StroceCount", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? StroceCount { get; set; }

        [Display(Name = "StrokeStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? StrokeStatus { get; set; }

        [Display(Name = "StrokeTypeId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? StrokeTypeId { get; set; }

        [Display(Name = "StrokeTypeName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string StrokeTypeName { get; set; }

        [Display(Name = "PulmonaryDiseaseStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? PulmonaryDiseaseStatus { get; set; }

        [Display(Name = "PulmonaryDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? PulmonaryDiseaseId { get; set; }

        [Display(Name = "PulmonaryDiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string PulmonaryDiseaseName { get; set; }

        [Display(Name = "COPDId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? COPDId { get; set; }

        [Display(Name = "COPDName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string COPDName { get; set; }

        [Display(Name = "PVDTStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? PVDTStatus { get; set; }

        [Display(Name = "PVDTId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? PVDTId { get; set; }

        [Display(Name = "PVDTName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string PVDTName { get; set; }

        [Display(Name = "RheumatismStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? RheumatismStatus { get; set; }

        [Display(Name = "RheumatizmDurationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? RheumatizmDurationId { get; set; }

        [Display(Name = "RheumatizmDurationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string RheumatizmDurationName { get; set; }

        [Display(Name = "InfectiousEndocarditisStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? InfectiousEndocarditisStatus { get; set; }

        [Display(Name = "InfectiousEndocarditisId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? InfectiousEndocarditisId { get; set; }

        [Display(Name = "InfectiousEndocarditisName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string InfectiousEndocarditisName { get; set; }

        [Display(Name = "BloodCholesterolId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? BloodCholesterolId { get; set; }

        [Display(Name = "BloodCholesterolName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string BloodCholesterolName { get; set; }

        [Display(Name = "HypertensionStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? HypertensionStatus { get; set; }

        [Display(Name = "HypertensionDurationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? HypertensionDurationId { get; set; }

        [Display(Name = "HypertensionDurationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string HypertensionDurationName { get; set; }

        [Display(Name = "UrogenitalicDiseaseStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? UrogenitalicDiseaseStatus { get; set; }

        [Display(Name = "UrogenitalicDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? UrogenitalicDiseaseId { get; set; }

        [Display(Name = "UrogenitalicDiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string UrogenitalicDiseaseName { get; set; }

        [Display(Name = "GastrointestinalDiseaseStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? GastrointestinalDiseaseStatus { get; set; }

        [Display(Name = "GastrointestinalDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? GastrointestinalDiseaseId { get; set; }

        [Display(Name = "GastrointestinalDiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string GastrointestinalDiseaseName { get; set; }

        [Display(Name = "ImmunosuppressiveTherapyStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? ImmunosuppressiveTherapyStatus { get; set; }

        [Display(Name = "ResuscitationStatus", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public bool? ResuscitationStatus { get; set; }

        [Display(Name = "DentalDiseaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DentalDiseaseId { get; set; }

        [Display(Name = "DentalDiseaseName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DentalDiseaseName { get; set; }

        [Display(Name = "DiseaseStatusId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? DiseaseStatusId { get; set; }

        [Display(Name = "DiseaseStatusName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string DiseaseStatusName { get; set; }

        [Display(Name = "SmokingTypeId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? SmokingTypeId { get; set; }

        [Display(Name = "SmokingTypeName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string SmokingTypeName { get; set; }
    }
}