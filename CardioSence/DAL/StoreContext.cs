using CardioSence.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CardioSence.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("DefaultConnection")
        {
        }
        public DbSet<AbdominalStatus> AbdominalStatuses { get; set; }
        public DbSet<AlcoholUsage> AlcoholUsages{ get; set; }
        public DbSet<ArteriaStatus> ArteriaStatuses { get; set; }
        public DbSet<BBB> BBBS { get; set; }
        public DbSet<BebType> BebTypes { get; set; }
        public DbSet<BicarbonateType> BicarbonateTypes { get; set; }
        public DbSet<BloodCholesterol> BloodCholesterols { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<BloodProduct> BloodProducts { get; set; }
        public DbSet<BRUStatus> BRUStatuses { get; set; }
        public DbSet<Bypass> Bypasses { get; set; }
        public DbSet<Cadiomyopathy> Cadiomyopathies { get; set; }
        public DbSet<CardiologicalCase> CardiologicalCases { get; set; }
        public DbSet<CardiologicalCaseComplian> CardiologicalCaseComplians { get; set; }
        public DbSet<CardiologicalCaseDisease> CardiologicalCaseDiseases { get; set; }
        public DbSet<CardiologicalCaseDrug> CardiologicalCaseDrugs { get; set; }
        public DbSet<CardiologicalCaseInvasion> CardiologicalCaseInvasions { get; set; }
        public DbSet<CardiologicalPCI> CardiologicalPCIS { get; set; }
        public DbSet<CardiologicalPCISegment> CardiologicalPCISegments { get; set; }
        public DbSet<CardiologicalSurgery> CardiologicalSurgeryes { get; set; }
        public DbSet<CardiologicalSurgeryComplication> CardiologicalSurgeryComplications { get; set; }
        public DbSet<CardiologicalSurgeryDrug> CardiologicalSurgeryDrugs { get; set; }
        public DbSet<CardiologicalSurgeryProcedure> CardiologicalSurgeryProcedures { get; set; }
        public DbSet<CardiologicalSurgeryValve> CardiologicalSurgeryValves { get; set; }
        public DbSet<CardiologicalDuplexScan> CardiologicalDuplexScans { get; set; }        
        public DbSet<CardiologicalCatheterization> CardiologicalCatheterizations { get; set; }
        public DbSet<CardiologicalCatheterizationSegment> CardiologicalCatheterizationSegments { get; set; }
        public DbSet<CardiologicalTreadmil> CardiologicalTreadmils { get; set; }
        public DbSet<CardioplegiaType> CardioplegiaTypes { get; set; }
        public DbSet<CardiologicalECG> CardiologicalECGS { get; set; }
        public DbSet<CardiologicalEchoCG> CardiologicalEchoCGS { get; set; }
        public DbSet<CardiologicalEchoCGVelocity> CardiologicalEchoCGVelocitys { get; set; }
        public DbSet<CardiologicalEchoCGWall> CardiologicalEchoCGWalls { get; set; }
        public DbSet<CardiologicalExamination> CardiologicalExaminations { get; set; }
        public DbSet<CardiologicalObjective> CardiologicalObjectives { get; set; }
        public DbSet<CardiologicalObjectiveDrug> CardiologicalObjectiveDrugs { get; set; }
        public DbSet<CardiologicalCPB> CardiologicalCPBS { get; set; }
        public DbSet<CaroticBruit> CaroticBruits { get; set; }
        public DbSet<CATD> CATDS { get; set; }
        public DbSet<CCS> CCSS { get; set; }
        public DbSet<CHD> CHDS { get; set; }
        public DbSet<ClimaxStatus> ClimaxStatusis { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Complian> Complians { get; set; }
        public DbSet<Complication> Complications { get; set; }
        public DbSet<ConductionDisturbance> ConductionDisturbances { get; set; }
        public DbSet<Contractility> Contractilityes { get; set; }
        public DbSet<COPD> COPDS { get; set; }
        public DbSet<Country> Countres { get; set; }
        public DbSet<DeathCause> DeathCausis { get; set; }
        public DbSet<DeathOrganization> DeathOrganizations { get; set; }
        public DbSet<DentalDisease> DentalDiseases { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<DiseaseStatus> DiseaseStatuses { get; set; }
        public DbSet<DominanceType> DominanceTypes { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugElutionType> DrugElutionTypes { get; set; }
        public DbSet<DrugFrequency> DrugFrequencies{ get; set; }
        public DbSet<DuplexStenosis> DuplexStenoses { get; set; }
        public DbSet<ECGZone> ECGZones { get; set; }
        public DbSet<EchoCGZone> EchoCGZones { get; set; }
        public DbSet<GastrointestinalDisease> GastrointestinalDiseasis { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<HBCriteria> HBCriterias { get; set; }
        public DbSet<HBSStatus> HBSStatuses { get; set; }
        public DbSet<HCVStatus> HCVStatuses { get; set; }
        public DbSet<HeartMurmurType> HeartMurmurTypes { get; set; }
        public DbSet<HeartSoundType> HeartSoundTypes { get; set; }
        public DbSet<HIT> HITS { get; set; }
        public DbSet<HIVStatus> HIVStatuses { get; set; }
        public DbSet<HVD> HVDS { get; set; }
        public DbSet<HypertensionDuration> HypertensionDurations { get; set; }
        public DbSet<ImmunologicalStatus> ImmunologicalStatusis { get; set; }
        public DbSet<Implant> Implants { get; set; }
        public DbSet<ImplantSize> ImplantSizes { get; set; }
        public DbSet<InfectiousEndocarditis> InfectiousEndocarditisis { get; set; }
        public DbSet<InotropicSupport> InotropicSupports { get; set; }
        public DbSet<Insufficiency> Insufficiencyes { get; set; }
        public DbSet<Invasion> Invasions { get; set; }
        public DbSet<Laun> Launs { get; set; }
        public DbSet<LesionType> LesionTypes { get; set; }
        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<Liver> Livers { get; set; }
        public DbSet<Lung> Lungs { get; set; }
        public DbSet<MedicalProcedure> MedicalProcedures { get; set; }
        public DbSet<MortalityType> MortalityTypes { get; set; }
        public DbSet<MovementStatus> MovementStatuses { get; set; }
        public DbSet<NYHA> NYHAS { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OtherDisease> OtherDiseases { get; set; }
        public DbSet<PeripherialStatus> PeripherialStatuses { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Prothesis> Prothesises { get; set; }
        public DbSet<PulmonaryDisease> PulmonaryDiseases { get; set; }
        public DbSet<PVDT> PVDTS { get; set; }
        public DbSet<ReferralOrganization> ReferralOrganizations { get; set; }
        public DbSet<ReferralPhysician> ReferralPhysicians { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RelativeStatus> RelativeStatuses { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<RheumatizmDuration> RheumatizmDurations { get; set; }
        public DbSet<RhFactor> RhFactors { get; set; }
        public DbSet<RhythmType> RhythmTypes { get; set; }
        public DbSet<SampleType> SampleTypes { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<ShockType> ShockTypes { get; set; }
        public DbSet<SmokingStatus> SmokingStatuses { get; set; }
        public DbSet<SmokingType> SmokingTypes { get; set; }
        public DbSet<Stenosis> Stenosises { get; set; }
        public DbSet<Stent> Stents { get; set; }
        public DbSet<StentType> StentTypes { get; set; }
        public DbSet<StrokeType> StrokeTypes { get; set; }
        public DbSet<TIMI> TIMIS { get; set; }
        public DbSet<TPHAStatus> TPHAStatuses { get; set; }
        public DbSet<TreadmilProtocol> TreadmilProtocols { get; set; }
        public DbSet<TreadmilResult> TreadmilResults { get; set; }
        public DbSet<TreatmentType> TreatmentTypes { get; set; }
        public DbSet<TroponinStatus> TroponinStatuses { get; set; }
        public DbSet<UrineCylinderStatus> UrineCylinderStatuses { get; set; }
        public DbSet<UrineMicroorganismStatus> UrineMicroorganismStatuses { get; set; }
        public DbSet<UrogenitalicDisease> UrogenitalicDiseases { get; set; }
        public DbSet<Valve> Valves { get; set; }
        public DbSet<ValveSurgeryType> ValveSurgeryTypes { get; set; }
        public DbSet<ValveType> ValveTypes { get; set; }
        public DbSet<VH> VHS { get; set; }

        // ------------ Views --------------------------
        public DbSet<ResidentItem> ResidentItems { get; set; }
        public DbSet<ResidentInfo> ResidentInfos { get; set; }
        public DbSet<CardiologicalCaseItem> CardiologicalCaseItems { get; set; }
        public DbSet<CardiologicalCaseComplianItem> CardiologicalCaseComplianItems { get; set; }
        public DbSet<CardiologicalCaseDiseaseItem> CardiologicalCaseDiseaseItems { get; set; }
        public DbSet<CardiologicalCaseDrugItem> CardiologicalCaseDrugItems { get; set; }
        public DbSet<CardiologicalCaseInvasionItem> CardiologicalCaseInvasionItems { get; set; }
        public DbSet<CardiologicalCatheterizationItem> CardiologicalCatheterizationItems { get; set; }
        public DbSet<CardiologicalCatheterizationSegmentItem> CardiologicalCatheterizationSegmentItems { get; set; }
        public DbSet<CardiologicalDuplexScanItem> CardiologicalDuplexScanItems { get; set; }
        public DbSet<CardiologicalECGItem> CardiologicalECGItems { get; set; }
        public DbSet<CardiologicalEchoCGItem> CardiologicalEchoCGItems { get; set; }
        public DbSet<CardiologicalEchoCGVelocityItem> CardiologicalEchoCGVelocityItems { get; set; }
        public DbSet<CardiologicalEchoCGWallItem> CardiologicalEchoCGWallItems { get; set; }
        public DbSet<CardiologicalExaminationItem> CardiologicalExaminationItems { get; set; }
        public DbSet<CardiologicalObjectiveItem> CardiologicalObjectiveItems { get; set; }
        public DbSet<CardiologicalObjectiveDrugItem> CardiologicalObjectiveDrugItems { get; set; }
        public DbSet<CardiologicalPCIItem> CardiologicalPCIItems { get; set; }
        public DbSet<CardiologicalPCISegmentItem> CardiologicalPCISegmentItems { get; set; }
        public DbSet<CardiologicalTreadmilItem> CardiologicalTreadmilItems { get; set; }
        public DbSet<CardiologicalSurgeryItem> CardiologicalSurgeryItems { get; set; }
        public DbSet<CardiologicalSurgeryComplicationItem> CardiologicalSurgeryComplicationItems { get; set; }
        public DbSet<CardiologicalSurgeryDrugItem> CardiologicalSurgeryDrugItems { get; set; }
        public DbSet<CardiologicalSurgeryProcedureItem> CardiologicalSurgeryProcedureItems { get; set; }
        public DbSet<CardiologicalSurgeryValveItem> CardiologicalSurgeryValveItems { get; set; }
        public DbSet<CardiologicalCPBItem> CardiologicalCPBItems { get; set; }
        public DbSet<UserRoleItem> UserRoleItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}