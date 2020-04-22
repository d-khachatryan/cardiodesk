using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardioSence.Models
{
    [Table("vwCardiologicalSurgery")]
    public class CardiologicalSurgeryItem
    {
        //[Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "CardiologicalSurgeryId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int CardiologicalSurgeryId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.General), ErrorMessageResourceName = "PatientRequired")]
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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CardiologicalSurgeryDate", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public DateTime? CardiologicalSurgeryDate { get; set; }

        [Display(Name = "DiseaseStatusId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DiseaseStatusId { get; set; }

        [Display(Name = "DiseaseStatusName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string DiseaseStatusName { get; set; }

        [Display(Name = "CPB", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public bool? CPB { get; set; }

        [Display(Name = "EuroSCORE", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? EuroSCORE { get; set; }

        [Display(Name = "CABGX", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CABGX { get; set; }

        [Display(Name = "BypassB1Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassB1Id { get; set; }

        [Display(Name = "B1BypassName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B1BypassName { get; set; }

        [Display(Name = "SegmentB1Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentB1Id { get; set; }

        [Display(Name = "B1SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B1SegmentName { get; set; }

        [Display(Name = "BypassB2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassB2Id { get; set; }

        [Display(Name = "B2BypassName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B2BypassName { get; set; }

        [Display(Name = "SegmentB2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentB2Id { get; set; }

        [Display(Name = "B2SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B2SegmentName { get; set; }

        [Display(Name = "BypassB3Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassB3Id { get; set; }

        [Display(Name = "B3BypasstName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B3BypasstName { get; set; }

        [Display(Name = "SegmentB3Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentB3Id { get; set; }

        [Display(Name = "B3SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string B3SegmentName { get; set; }

        [Display(Name = "BypassC1Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassC1Id { get; set; }

        [Display(Name = "C1BypasstName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C1BypasstName { get; set; }

        [Display(Name = "SegmentC1Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentC1Id { get; set; }

        [Display(Name = "C1SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C1SegmentName { get; set; }

        [Display(Name = "SegmentD1Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentD1Id { get; set; }

        [Display(Name = "D1SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string D1SegmentName { get; set; }

        [Display(Name = "BypassC2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassC2Id { get; set; }

        [Display(Name = "C2BypasstName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C2BypasstName { get; set; }

        [Display(Name = "SegmentC2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentC2Id { get; set; }

        [Display(Name = "C2SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C2SegmentName { get; set; }

        [Display(Name = "SegmentD2Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentD2Id { get; set; }

        [Display(Name = "D2SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string D2SegmentName { get; set; }

        [Display(Name = "BypassC3Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassC3Id { get; set; }

        [Display(Name = "C3BypasstName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C3BypasstName { get; set; }

        [Display(Name = "SegmentC3Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentC3Id { get; set; }

        [Display(Name = "C3SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string C3SegmentName { get; set; }

        [Display(Name = "SegmentD3Id", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? SegmentD3Id { get; set; }

        [Display(Name = "D3SegmentName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string D3SegmentName { get; set; }

        [Display(Name = "LFL", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? LFL { get; set; }

        [Display(Name = "HFL", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? HFL { get; set; }

        [Display(Name = "NaCl", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? NaCl { get; set; }

        [Display(Name = "GEL", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? GEL { get; set; }

        [Display(Name = "Mannitol", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Mannitol { get; set; }

        [Display(Name = "BicarbonateTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BicarbonateTypeId { get; set; }

        [Display(Name = "BicarbonateTypeName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string BicarbonateTypeName { get; set; }

        [Display(Name = "NaHCO3", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? NaHCO3 { get; set; }

        [Display(Name = "Heparin1", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? Heparin1 { get; set; }

        [Display(Name = "CaCl2", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? CaCl2 { get; set; }

        [Display(Name = "RBCCPB", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? RBCCPB { get; set; }

        [Display(Name = "FFPCPB", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? FFPCPB { get; set; }

        [Display(Name = "LiquidId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? LiquidId { get; set; }

        [Display(Name = "Other1", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Other1 { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "PrimaryVolume", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? PrimaryVolume { get; private set; }

        [Display(Name = "Na", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Na { get; set; }

        [Display(Name = "Gelofusin", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Gelofusin { get; set; }

        [Display(Name = "Man", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Man { get; set; }

        [Display(Name = "NaHCO", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? NaHCO { get; set; }

        [Display(Name = "Heparin2", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? Heparin2 { get; set; }

        [Display(Name = "CaCl", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? CaCl { get; set; }

        [Display(Name = "R", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? R { get; set; }

        [Display(Name = "F", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? F { get; set; }

        [Display(Name = "Other2", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Other2 { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "TotalVolume", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? TotalVolume { get; private set; }

        [Display(Name = "ResidualVolume", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? ResidualVolume { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "InPatientVolume", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? InPatientVolume { get; private set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        [Display(Name = "SkinIncisionStartTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public DateTime? SkinIncisionStartTime { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        [Display(Name = "SkinIncisionCloseTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public DateTime? SkinIncisionCloseTime { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "TotalOperationTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? TotalOperationTime { get; private set; }

        [Display(Name = "CrossClampTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CrossClampTime { get; set; }

        [Display(Name = "BypassTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BypassTime { get; set; }

        [Display(Name = "CardioplegiaTypeId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CardioplegiaTypeId { get; set; }

        [Display(Name = "CardioplegiaTypeName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string CardioplegiaTypeName { get; set; }

        [Display(Name = "AnesthesiaTime", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? AnesthesiaTime { get; set; }

        [Display(Name = "RBCId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? RBCId { get; set; }

        [Display(Name = "RBCBloodProductName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string RBCBloodProductName { get; set; }

        [Display(Name = "FFPId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? FFPId { get; set; }

        [Display(Name = "FFPBloodProductName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string FFPBloodProductName { get; set; }

        [Display(Name = "PLTId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? PLTId { get; set; }

        [Display(Name = "PLTBloodProductName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string PLTBloodProductName { get; set; }

        [Display(Name = "InotropicSupportId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? InotropicSupportId { get; set; }

        [Display(Name = "InotropicSupportName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string InotropicSupportName { get; set; }

        [Display(Name = "BloodLossVolume", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? BloodLossVolume { get; set; }

        [Display(Name = "SkinTemperature", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? SkinTemperature { get; set; }

        [Display(Name = "ExtubatedPOD", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ExtubatedPOD { get; set; }

        [Display(Name = "InitialHoursVentilated", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? InitialHoursVentilated { get; set; }

        [Display(Name = "ReIntubation", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public bool? ReIntubation { get; set; }

        [Display(Name = "AdditionalHoursVentilated", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? AdditionalHoursVentilated { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "TotalHoursVentilated", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? TotalHoursVentilated { get; private set; }

        [Display(Name = "Hb", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Hb { get; set; }

        [Display(Name = "Hct", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Hct { get; set; }

        [Display(Name = "Platelet", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Platelet { get; set; }

        [Display(Name = "Creatinine", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Creatinine { get; set; }

        [Display(Name = "APTT", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? APTT { get; set; }

        [Display(Name = "Sodium", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Sodium { get; set; }

        [Display(Name = "Potassium", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? Potassium { get; set; }

        [Display(Name = "PH", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public double? PH { get; set; }

        [Display(Name = "PaO2", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? PaO2 { get; set; }

        [Display(Name = "PaCO2", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? PaCO2 { get; set; }

        [Display(Name = "ICULength", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? ICULength { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DischargeDate", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public DateTime? DischargeDate { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "CSDLength", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? CSDLength { get; set; }

        [Display(Name = "Mortality", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public bool? Mortality { get; private set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        [Display(Name = "DeathDate", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public DateTime? DeathDate { get; set; }

        [Display(Name = "DeathCauseId", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public int? DeathCauseId { get; set; }

        [Display(Name = "DeathCauseName", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string DeathCauseName { get; set; }

        [Display(Name = "Comment", ResourceType = typeof(Resources.rsCardiologicalSurgery))]
        public string Comment { get; set; }
    }
}