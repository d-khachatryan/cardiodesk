using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using CardioSence.Resources;


namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalcaserole,systemadministratorrole")]
    public class CardiologicalCaseController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.activeRec = "active";
            ViewBag.activeHis = "active";
            return View();
        }

        public ActionResult ReadCardiologicalCasesItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalCaseItem> items = db.CardiologicalCaseItems;
                DataSourceResult result = items.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult CreateOutPatientCase()
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalOutPatientCase();
                    item.OutPatient = true;
                    return View("OutPatientInputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        public ActionResult CreateInHospitalCase()
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalInHospitalCase();
                    item.InHospital = true;
                    return View("InHospitalInputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        // Նոր ավելացված ֆունկցիա
        public ActionResult CreateWithResidentOutPatient(int? id)
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    Resident resident = db.Residents.Find(id);
                    var item = new CardiologicalOutPatientCase();

                    item.ResidentId = resident.ResidentId;
                    item.PatientId = resident.PatientId;
                    item.ResidentFirstName = resident.ResidentFirstName;
                    item.ResidentLastName = resident.ResidentLastName;
                    item.ResidentPatronymicName = resident.ResidentPatronymicName;
                    item.BirthDate = resident.BirthDate;

                    return View("OutPatientInputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        public ActionResult CreateWithResidentInHospital(int? id)
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    Resident resident = db.Residents.Find(id);
                    var item = new CardiologicalInHospitalCase();

                    item.ResidentId = resident.ResidentId;
                    item.PatientId = resident.PatientId;
                    item.ResidentFirstName = resident.ResidentFirstName;
                    item.ResidentLastName = resident.ResidentLastName;
                    item.ResidentPatronymicName = resident.ResidentPatronymicName;
                    item.BirthDate = resident.BirthDate;

                    return View("InHospitalInputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        public ActionResult Update(int? id)
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);

                    IQueryable<CardiologicalCaseItem> cardiologicalCaseItems = db.CardiologicalCaseItems.Where(p => p.CardiologicalCaseId == id);

                    if (cardiologicalCaseItems.Count() > 0)
                    {
                        CardiologicalCaseItem cardiologicalCaseItem = cardiologicalCaseItems.FirstOrDefault();

                        if (cardiologicalCaseItem.OutPatient == true)
                        {
                            var cardiologicalOutPatientCase = new CardiologicalOutPatientCase();
                            cardiologicalOutPatientCase.CardiologicalCaseId = cardiologicalCaseItem.CardiologicalCaseId;
                            cardiologicalOutPatientCase.ResidentId = cardiologicalCaseItem.ResidentId;
                            cardiologicalOutPatientCase.PatientId = cardiologicalCaseItem.PatientId;
                            cardiologicalOutPatientCase.ResidentFirstName = cardiologicalCaseItem.ResidentFirstName;
                            cardiologicalOutPatientCase.ResidentLastName = cardiologicalCaseItem.ResidentLastName;
                            cardiologicalOutPatientCase.ResidentPatronymicName = cardiologicalCaseItem.ResidentPatronymicName;
                            cardiologicalOutPatientCase.BirthDate = cardiologicalCaseItem.BirthDate;
                            cardiologicalOutPatientCase.OutPatient = cardiologicalCaseItem.OutPatient;
                            cardiologicalOutPatientCase.ConsultationDate = cardiologicalCaseItem.ConsultationDate;
                            cardiologicalOutPatientCase.CAD = cardiologicalCaseItem.CAD;
                            //cardiologicalOutPatientCase.CCSStatus = cardiologicalCaseItem.CCSStatus;
                            cardiologicalOutPatientCase.CCSId = cardiologicalCaseItem.CCSId;
                            //cardiologicalOutPatientCase.HBCriteriaStatus = cardiologicalCaseItem.HBCriteriaStatus;
                            cardiologicalOutPatientCase.HBCriteriaId = cardiologicalCaseItem.HBCriteriaId;
                            //cardiologicalOutPatientCase.HITStatus = cardiologicalCaseItem.HITStatus;
                            cardiologicalOutPatientCase.HITId = cardiologicalCaseItem.HITId;
                            cardiologicalOutPatientCase.NYHAId = cardiologicalCaseItem.NYHAId;
                            //cardiologicalOutPatientCase.ShockTypeStatus = cardiologicalCaseItem.ShockTypeStatus;
                            cardiologicalOutPatientCase.ShockTypeId = cardiologicalCaseItem.ShockTypeId;
                            //cardiologicalOutPatientCase.CATDStatus = cardiologicalCaseItem.CATDStatus;
                            cardiologicalOutPatientCase.CATDId = cardiologicalCaseItem.CATDId;
                            //cardiologicalOutPatientCase.CHDStatus = cardiologicalCaseItem.CHDStatus;
                            cardiologicalOutPatientCase.CHDId = cardiologicalCaseItem.CHDId;
                            //cardiologicalOutPatientCase.HVDStatus = cardiologicalCaseItem.HVDStatus;
                            cardiologicalOutPatientCase.HVDId = cardiologicalCaseItem.HVDId;
                            //cardiologicalOutPatientCase.CadiomyopathyStatus = cardiologicalCaseItem.CadiomyopathyStatus;
                            cardiologicalOutPatientCase.CadiomyopathyId = cardiologicalCaseItem.CadiomyopathyId;
                            cardiologicalOutPatientCase.MainDiagnose = cardiologicalCaseItem.MainDiagnose;
                            cardiologicalOutPatientCase.OtherDiseaseId = cardiologicalCaseItem.OtherDiseaseId;
                            cardiologicalOutPatientCase.TreatmentTypeId = cardiologicalCaseItem.TreatmentTypeId;
                            cardiologicalOutPatientCase.ReferralOrganizationId = cardiologicalCaseItem.ReferralOrganizationId;
                            cardiologicalOutPatientCase.DeathStatus = cardiologicalCaseItem.DeathStatus;
                            cardiologicalOutPatientCase.DeathDate = cardiologicalCaseItem.DeathDate;
                            cardiologicalOutPatientCase.MortalityTypeId = cardiologicalCaseItem.MortalityTypeId;
                            cardiologicalOutPatientCase.DeathCauseId = cardiologicalCaseItem.DeathCauseId;
                            cardiologicalOutPatientCase.DeathOrganizationId = cardiologicalCaseItem.DeathOrganizationId;
                            cardiologicalOutPatientCase.Weight = cardiologicalCaseItem.Weight;
                            cardiologicalOutPatientCase.Height = cardiologicalCaseItem.Height;
                            cardiologicalOutPatientCase.BSA = cardiologicalCaseItem.BSA;
                            cardiologicalOutPatientCase.BMI = cardiologicalCaseItem.BMI;
                            cardiologicalOutPatientCase.SmokingStatusId = cardiologicalCaseItem.SmokingStatusId;
                            cardiologicalOutPatientCase.MovementStatusId = cardiologicalCaseItem.MovementStatusId;
                            cardiologicalOutPatientCase.AlcoholUsageId = cardiologicalCaseItem.AlcoholUsageId;
                            //cardiologicalOutPatientCase.ImmunologicalStatus = cardiologicalCaseItem.ImmunologicalStatus;
                            cardiologicalOutPatientCase.ImmunologicalStatusId = cardiologicalCaseItem.ImmunologicalStatusId;
                            cardiologicalOutPatientCase.CardiologicalInheritance = cardiologicalCaseItem.CardiologicalInheritance;
                            cardiologicalOutPatientCase.ClimaxStatusId = cardiologicalCaseItem.ClimaxStatusId;
                            cardiologicalOutPatientCase.DiabetesMellitusStatus = cardiologicalCaseItem.DiabetesMellitusStatus;
                            cardiologicalOutPatientCase.Glucose = cardiologicalCaseItem.Glucose;
                            cardiologicalOutPatientCase.StroceCount = cardiologicalCaseItem.StroceCount;
                            cardiologicalOutPatientCase.StrokeStatus = cardiologicalCaseItem.StrokeStatus;
                            cardiologicalOutPatientCase.StrokeTypeId = cardiologicalCaseItem.StrokeTypeId;
                            //cardiologicalOutPatientCase.PulmonaryDiseaseStatus = cardiologicalCaseItem.PulmonaryDiseaseStatus;
                            cardiologicalOutPatientCase.PulmonaryDiseaseId = cardiologicalCaseItem.PulmonaryDiseaseId;
                            cardiologicalOutPatientCase.COPDId = cardiologicalCaseItem.COPDId;
                            //cardiologicalOutPatientCase.PVDTStatus = cardiologicalCaseItem.PVDTStatus;
                            cardiologicalOutPatientCase.PVDTId = cardiologicalCaseItem.PVDTId;
                            //cardiologicalOutPatientCase.RheumatismStatus = cardiologicalCaseItem.RheumatismStatus;
                            cardiologicalOutPatientCase.RheumatizmDurationId = cardiologicalCaseItem.RheumatizmDurationId;
                            //cardiologicalOutPatientCase.InfectiousEndocarditisStatus = cardiologicalCaseItem.InfectiousEndocarditisStatus;
                            cardiologicalOutPatientCase.InfectiousEndocarditisId = cardiologicalCaseItem.InfectiousEndocarditisId;
                            cardiologicalOutPatientCase.BloodCholesterolId = cardiologicalCaseItem.BloodCholesterolId;
                            //cardiologicalOutPatientCase.HypertensionStatus = cardiologicalCaseItem.HypertensionStatus;
                            cardiologicalOutPatientCase.HypertensionDurationId = cardiologicalCaseItem.HypertensionDurationId;
                            //cardiologicalOutPatientCase.UrogenitalicDiseaseStatus = cardiologicalCaseItem.UrogenitalicDiseaseStatus;
                            cardiologicalOutPatientCase.UrogenitalicDiseaseId = cardiologicalCaseItem.UrogenitalicDiseaseId;
                            //cardiologicalOutPatientCase.GastrointestinalDiseaseStatus = cardiologicalCaseItem.GastrointestinalDiseaseStatus;
                            cardiologicalOutPatientCase.GastrointestinalDiseaseId = cardiologicalCaseItem.GastrointestinalDiseaseId;
                            cardiologicalOutPatientCase.ImmunosuppressiveTherapyStatus = cardiologicalCaseItem.ImmunosuppressiveTherapyStatus;
                            cardiologicalOutPatientCase.ResuscitationStatus = cardiologicalCaseItem.ResuscitationStatus;
                            cardiologicalOutPatientCase.DentalDiseaseId = cardiologicalCaseItem.DentalDiseaseId;
                            cardiologicalOutPatientCase.DiseaseStatusId = cardiologicalCaseItem.DiseaseStatusId;
                            cardiologicalOutPatientCase.SmokingTypeId = cardiologicalCaseItem.SmokingTypeId;
                            return View("OutPatientInputForm", cardiologicalOutPatientCase);

                        }
                        else
                        {
                            var cardiologicalInHospitalCase = new CardiologicalInHospitalCase();
                            cardiologicalInHospitalCase.CardiologicalCaseId = cardiologicalCaseItem.CardiologicalCaseId;
                            cardiologicalInHospitalCase.ResidentId = cardiologicalCaseItem.ResidentId;
                            cardiologicalInHospitalCase.PatientId = cardiologicalCaseItem.PatientId;
                            cardiologicalInHospitalCase.ResidentFirstName = cardiologicalCaseItem.ResidentFirstName;
                            cardiologicalInHospitalCase.ResidentLastName = cardiologicalCaseItem.ResidentLastName;
                            cardiologicalInHospitalCase.ResidentPatronymicName = cardiologicalCaseItem.ResidentPatronymicName;
                            cardiologicalInHospitalCase.BirthDate = cardiologicalCaseItem.BirthDate;
                            cardiologicalInHospitalCase.InHospital = cardiologicalCaseItem.InHospital;
                            cardiologicalInHospitalCase.StartDate  = cardiologicalCaseItem.StartDate;
                            cardiologicalInHospitalCase.DischargeDate  = cardiologicalCaseItem.DischargeDate;
                            cardiologicalInHospitalCase.CAD = cardiologicalCaseItem.CAD;
                            //cardiologicalInHospitalCase.CCSStatus = cardiologicalCaseItem.CCSStatus;
                            cardiologicalInHospitalCase.CCSId = cardiologicalCaseItem.CCSId;
                            //cardiologicalInHospitalCase.HBCriteriaStatus = cardiologicalCaseItem.HBCriteriaStatus;
                            cardiologicalInHospitalCase.HBCriteriaId = cardiologicalCaseItem.HBCriteriaId;
                            //cardiologicalInHospitalCase.HITStatus = cardiologicalCaseItem.HITStatus;
                            cardiologicalInHospitalCase.HITId = cardiologicalCaseItem.HITId;
                            cardiologicalInHospitalCase.NYHAId = cardiologicalCaseItem.NYHAId;
                            //cardiologicalInHospitalCase.ShockTypeStatus = cardiologicalCaseItem.ShockTypeStatus;
                            cardiologicalInHospitalCase.ShockTypeId = cardiologicalCaseItem.ShockTypeId;
                            //cardiologicalInHospitalCase.CATDStatus = cardiologicalCaseItem.CATDStatus;
                            cardiologicalInHospitalCase.CATDId = cardiologicalCaseItem.CATDId;
                            //cardiologicalInHospitalCase.CHDStatus = cardiologicalCaseItem.CHDStatus;
                            cardiologicalInHospitalCase.CHDId = cardiologicalCaseItem.CHDId;
                            //cardiologicalInHospitalCase.HVDStatus = cardiologicalCaseItem.HVDStatus;
                            cardiologicalInHospitalCase.HVDId = cardiologicalCaseItem.HVDId;
                            //cardiologicalInHospitalCase.CadiomyopathyStatus = cardiologicalCaseItem.CadiomyopathyStatus;
                            cardiologicalInHospitalCase.CadiomyopathyId = cardiologicalCaseItem.CadiomyopathyId;
                            cardiologicalInHospitalCase.MainDiagnose = cardiologicalCaseItem.MainDiagnose;
                            cardiologicalInHospitalCase.OtherDiseaseId = cardiologicalCaseItem.OtherDiseaseId;
                            cardiologicalInHospitalCase.TreatmentTypeId = cardiologicalCaseItem.TreatmentTypeId;
                            cardiologicalInHospitalCase.ReferralOrganizationId = cardiologicalCaseItem.ReferralOrganizationId;
                            cardiologicalInHospitalCase.DeathStatus = cardiologicalCaseItem.DeathStatus;
                            cardiologicalInHospitalCase.DeathDate = cardiologicalCaseItem.DeathDate;
                            cardiologicalInHospitalCase.MortalityTypeId = cardiologicalCaseItem.MortalityTypeId;
                            cardiologicalInHospitalCase.DeathCauseId = cardiologicalCaseItem.DeathCauseId;
                            cardiologicalInHospitalCase.DeathOrganizationId = cardiologicalCaseItem.DeathOrganizationId;
                            cardiologicalInHospitalCase.Weight = cardiologicalCaseItem.Weight;
                            cardiologicalInHospitalCase.Height = cardiologicalCaseItem.Height;
                            cardiologicalInHospitalCase.BSA = cardiologicalCaseItem.BSA;
                            cardiologicalInHospitalCase.BMI = cardiologicalCaseItem.BMI;
                            cardiologicalInHospitalCase.SmokingStatusId = cardiologicalCaseItem.SmokingStatusId;
                            cardiologicalInHospitalCase.MovementStatusId = cardiologicalCaseItem.MovementStatusId;
                            cardiologicalInHospitalCase.AlcoholUsageId = cardiologicalCaseItem.AlcoholUsageId;
                            //cardiologicalInHospitalCase.ImmunologicalStatus = cardiologicalCaseItem.ImmunologicalStatus;
                            cardiologicalInHospitalCase.ImmunologicalStatusId = cardiologicalCaseItem.ImmunologicalStatusId;
                            cardiologicalInHospitalCase.CardiologicalInheritance = cardiologicalCaseItem.CardiologicalInheritance;
                            cardiologicalInHospitalCase.ClimaxStatusId = cardiologicalCaseItem.ClimaxStatusId;
                            cardiologicalInHospitalCase.DiabetesMellitusStatus = cardiologicalCaseItem.DiabetesMellitusStatus;
                            cardiologicalInHospitalCase.Glucose = cardiologicalCaseItem.Glucose;
                            cardiologicalInHospitalCase.StroceCount = cardiologicalCaseItem.StroceCount;
                            cardiologicalInHospitalCase.StrokeStatus = cardiologicalCaseItem.StrokeStatus;
                            cardiologicalInHospitalCase.StrokeTypeId = cardiologicalCaseItem.StrokeTypeId;
                            //cardiologicalInHospitalCase.PulmonaryDiseaseStatus = cardiologicalCaseItem.PulmonaryDiseaseStatus;
                            cardiologicalInHospitalCase.PulmonaryDiseaseId = cardiologicalCaseItem.PulmonaryDiseaseId;
                            cardiologicalInHospitalCase.COPDId = cardiologicalCaseItem.COPDId;
                            //cardiologicalInHospitalCase.PVDTStatus = cardiologicalCaseItem.PVDTStatus;
                            cardiologicalInHospitalCase.PVDTId = cardiologicalCaseItem.PVDTId;
                            //cardiologicalInHospitalCase.RheumatismStatus = cardiologicalCaseItem.RheumatismStatus;
                            cardiologicalInHospitalCase.RheumatizmDurationId = cardiologicalCaseItem.RheumatizmDurationId;
                            //cardiologicalInHospitalCase.InfectiousEndocarditisStatus = cardiologicalCaseItem.InfectiousEndocarditisStatus;
                            cardiologicalInHospitalCase.InfectiousEndocarditisId = cardiologicalCaseItem.InfectiousEndocarditisId;
                            cardiologicalInHospitalCase.BloodCholesterolId = cardiologicalCaseItem.BloodCholesterolId;
                            //cardiologicalInHospitalCase.HypertensionStatus = cardiologicalCaseItem.HypertensionStatus;
                            cardiologicalInHospitalCase.HypertensionDurationId = cardiologicalCaseItem.HypertensionDurationId;
                            //cardiologicalInHospitalCase.UrogenitalicDiseaseStatus = cardiologicalCaseItem.UrogenitalicDiseaseStatus;
                            cardiologicalInHospitalCase.UrogenitalicDiseaseId = cardiologicalCaseItem.UrogenitalicDiseaseId;
                            //cardiologicalInHospitalCase.GastrointestinalDiseaseStatus = cardiologicalCaseItem.GastrointestinalDiseaseStatus;
                            cardiologicalInHospitalCase.GastrointestinalDiseaseId = cardiologicalCaseItem.GastrointestinalDiseaseId;
                            cardiologicalInHospitalCase.ImmunosuppressiveTherapyStatus = cardiologicalCaseItem.ImmunosuppressiveTherapyStatus;
                            cardiologicalInHospitalCase.ResuscitationStatus = cardiologicalCaseItem.ResuscitationStatus;
                            cardiologicalInHospitalCase.DentalDiseaseId = cardiologicalCaseItem.DentalDiseaseId;
                            cardiologicalInHospitalCase.DiseaseStatusId = cardiologicalCaseItem.DiseaseStatusId;
                            cardiologicalInHospitalCase.SmokingTypeId = cardiologicalCaseItem.SmokingTypeId;
                            return View("InHospitalInputForm", cardiologicalInHospitalCase);

                        }
                    }
                    else
                    {
                        return RedirectToAction("Index", "Error", new { msg = "No record" });
                    }


                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult SaveOutPatientCase(CardiologicalOutPatientCase cardiologicalOutPatientCase)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return this.Json(new { statuscode = -1, message = General.msgInvalidModel }, JsonRequestBehavior.AllowGet);
                }

                using (var db = new StoreContext())
                {
                    // եթե 2-րդ մակարդակի աղյուսակի տողը նոր գրառումա ավելացնում ենք
                    if (cardiologicalOutPatientCase.CardiologicalCaseId == 0)
                    {
                        ////////////////////////////////////////////////////////////
                        var cardiologicalCase = new CardiologicalCase();
                        cardiologicalCase.CardiologicalCaseId = cardiologicalOutPatientCase.CardiologicalCaseId;
                        cardiologicalCase.ResidentId = cardiologicalOutPatientCase.ResidentId;
                        cardiologicalCase.InHospital = false;
                        cardiologicalCase.StartDate = null;
                        cardiologicalCase.DischargeDate = null;
                        cardiologicalCase.OutPatient = cardiologicalOutPatientCase.OutPatient;
                        cardiologicalCase.ConsultationDate = cardiologicalOutPatientCase.ConsultationDate;
                        cardiologicalCase.CAD = cardiologicalOutPatientCase.CAD;
                        //cardiologicalCase.CCSStatus = cardiologicalOutPatientCase.CCSStatus;
                        cardiologicalCase.CCSId = cardiologicalOutPatientCase.CCSId;
                        //cardiologicalCase.HBCriteriaStatus = cardiologicalOutPatientCase.HBCriteriaStatus;
                        cardiologicalCase.HBCriteriaId = cardiologicalOutPatientCase.HBCriteriaId;
                        //cardiologicalCase.HITStatus = cardiologicalOutPatientCase.HITStatus;
                        cardiologicalCase.HITId = cardiologicalOutPatientCase.HITId;
                        cardiologicalCase.NYHAId = cardiologicalOutPatientCase.NYHAId;
                        //cardiologicalCase.ShockTypeStatus = cardiologicalOutPatientCase.ShockTypeStatus;
                        cardiologicalCase.ShockTypeId = cardiologicalOutPatientCase.ShockTypeId;
                        //cardiologicalCase.CATDStatus = cardiologicalOutPatientCase.CATDStatus;
                        cardiologicalCase.CATDId = cardiologicalOutPatientCase.CATDId;
                        //cardiologicalCase.CHDStatus = cardiologicalOutPatientCase.CHDStatus;
                        cardiologicalCase.CHDId = cardiologicalOutPatientCase.CHDId;
                        //cardiologicalCase.HVDStatus = cardiologicalOutPatientCase.HVDStatus;
                        cardiologicalCase.HVDId = cardiologicalOutPatientCase.HVDId;
                        //cardiologicalCase.CadiomyopathyStatus = cardiologicalOutPatientCase.CadiomyopathyStatus;
                        cardiologicalCase.CadiomyopathyId = cardiologicalOutPatientCase.CadiomyopathyId;
                        cardiologicalCase.MainDiagnose = cardiologicalOutPatientCase.MainDiagnose;
                        cardiologicalCase.OtherDiseaseId = cardiologicalOutPatientCase.OtherDiseaseId;
                        cardiologicalCase.TreatmentTypeId = cardiologicalOutPatientCase.TreatmentTypeId;
                        cardiologicalCase.ReferralOrganizationId = cardiologicalOutPatientCase.ReferralOrganizationId;
                        cardiologicalCase.DeathStatus = cardiologicalOutPatientCase.DeathStatus;
                        cardiologicalCase.DeathDate = cardiologicalOutPatientCase.DeathDate;
                        cardiologicalCase.MortalityTypeId = cardiologicalOutPatientCase.MortalityTypeId;
                        cardiologicalCase.DeathCauseId = cardiologicalOutPatientCase.DeathCauseId;
                        cardiologicalCase.DeathOrganizationId = cardiologicalOutPatientCase.DeathOrganizationId;
                        cardiologicalCase.Weight = cardiologicalOutPatientCase.Weight;
                        cardiologicalCase.Height = cardiologicalOutPatientCase.Height;
                        cardiologicalCase.BSA = cardiologicalOutPatientCase.BSA;
                        cardiologicalCase.BMI = cardiologicalOutPatientCase.BMI;
                        cardiologicalCase.SmokingStatusId = cardiologicalOutPatientCase.SmokingStatusId;
                        cardiologicalCase.MovementStatusId = cardiologicalOutPatientCase.MovementStatusId;
                        cardiologicalCase.AlcoholUsageId = cardiologicalOutPatientCase.AlcoholUsageId;
                        //cardiologicalCase.ImmunologicalStatus = cardiologicalOutPatientCase.ImmunologicalStatus;
                        cardiologicalCase.ImmunologicalStatusId = cardiologicalOutPatientCase.ImmunologicalStatusId;
                        cardiologicalCase.CardiologicalInheritance = cardiologicalOutPatientCase.CardiologicalInheritance;
                        cardiologicalCase.ClimaxStatusId = cardiologicalOutPatientCase.ClimaxStatusId;
                        cardiologicalCase.DiabetesMellitusStatus = cardiologicalOutPatientCase.DiabetesMellitusStatus;
                        cardiologicalCase.Glucose = cardiologicalOutPatientCase.Glucose;
                        cardiologicalCase.StroceCount = cardiologicalOutPatientCase.StroceCount;
                        cardiologicalCase.StrokeStatus = cardiologicalOutPatientCase.StrokeStatus;
                        cardiologicalCase.StrokeTypeId = cardiologicalOutPatientCase.StrokeTypeId;
                        //cardiologicalCase.PulmonaryDiseaseStatus = cardiologicalOutPatientCase.PulmonaryDiseaseStatus;
                        cardiologicalCase.PulmonaryDiseaseId = cardiologicalOutPatientCase.PulmonaryDiseaseId;
                        cardiologicalCase.COPDId = cardiologicalOutPatientCase.COPDId;
                        //cardiologicalCase.PVDTStatus = cardiologicalOutPatientCase.PVDTStatus;
                        cardiologicalCase.PVDTId = cardiologicalOutPatientCase.PVDTId;
                        //cardiologicalCase.RheumatismStatus = cardiologicalOutPatientCase.RheumatismStatus;
                        cardiologicalCase.RheumatizmDurationId = cardiologicalOutPatientCase.RheumatizmDurationId;
                        //cardiologicalCase.InfectiousEndocarditisStatus = cardiologicalOutPatientCase.InfectiousEndocarditisStatus;
                        cardiologicalCase.InfectiousEndocarditisId = cardiologicalOutPatientCase.InfectiousEndocarditisId;
                        cardiologicalCase.BloodCholesterolId = cardiologicalOutPatientCase.BloodCholesterolId;
                        //cardiologicalCase.HypertensionStatus = cardiologicalOutPatientCase.HypertensionStatus;
                        cardiologicalCase.HypertensionDurationId = cardiologicalOutPatientCase.HypertensionDurationId;
                        //cardiologicalCase.UrogenitalicDiseaseStatus = cardiologicalOutPatientCase.UrogenitalicDiseaseStatus;
                        cardiologicalCase.UrogenitalicDiseaseId = cardiologicalOutPatientCase.UrogenitalicDiseaseId;
                        //cardiologicalCase.GastrointestinalDiseaseStatus = cardiologicalOutPatientCase.GastrointestinalDiseaseStatus;
                        cardiologicalCase.GastrointestinalDiseaseId = cardiologicalOutPatientCase.GastrointestinalDiseaseId;
                        cardiologicalCase.ImmunosuppressiveTherapyStatus = cardiologicalOutPatientCase.ImmunosuppressiveTherapyStatus;
                        cardiologicalCase.ResuscitationStatus = cardiologicalOutPatientCase.ResuscitationStatus;
                        cardiologicalCase.DentalDiseaseId = cardiologicalOutPatientCase.DentalDiseaseId;
                        cardiologicalCase.DiseaseStatusId = cardiologicalOutPatientCase.DiseaseStatusId;
                        cardiologicalCase.SmokingTypeId = cardiologicalOutPatientCase.SmokingTypeId;

                        db.CardiologicalCases.Add(cardiologicalCase);

                        if (cardiologicalOutPatientCase.CardiologicalCaseComplians != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseComplians)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseComplian = new CardiologicalCaseComplian();
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Add(cardiologicalCaseComplian);
                                }
                            }
                        }
                        if (cardiologicalOutPatientCase.CardiologicalCaseDiseases != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseDiseases)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDisease = new CardiologicalCaseDisease();
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Add(cardiologicalCaseDisease);
                                }
                            }
                        }
                        if (cardiologicalOutPatientCase.CardiologicalCaseDrugs != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDrug = new CardiologicalCaseDrug();
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Add(cardiologicalCaseDrug);
                                }
                            }
                        }
                        if (cardiologicalOutPatientCase.CardiologicalCaseInvasions != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseInvasions)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseInvasion = new CardiologicalCaseInvasion();
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Add(cardiologicalCaseInvasion);
                                }
                            }
                        }
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalCase cardiologicalCase = db.CardiologicalCases.Find(cardiologicalOutPatientCase.CardiologicalCaseId);
                        cardiologicalCase.ResidentId = cardiologicalOutPatientCase.ResidentId;                        
                        cardiologicalCase.InHospital = false;
                        cardiologicalCase.StartDate  = null;
                        cardiologicalCase.DischargeDate  = null;
                        cardiologicalCase.OutPatient = cardiologicalOutPatientCase.OutPatient;
                        cardiologicalCase.ConsultationDate = cardiologicalOutPatientCase.ConsultationDate;
                        cardiologicalCase.CAD = cardiologicalOutPatientCase.CAD;
                        //cardiologicalCase.CCSStatus = cardiologicalOutPatientCase.CCSStatus;
                        cardiologicalCase.CCSId = cardiologicalOutPatientCase.CCSId;
                        //cardiologicalCase.HBCriteriaStatus = cardiologicalOutPatientCase.HBCriteriaStatus;
                        cardiologicalCase.HBCriteriaId = cardiologicalOutPatientCase.HBCriteriaId;
                        //cardiologicalCase.HITStatus = cardiologicalOutPatientCase.HITStatus;
                        cardiologicalCase.HITId = cardiologicalOutPatientCase.HITId;
                        cardiologicalCase.NYHAId = cardiologicalOutPatientCase.NYHAId;
                        //cardiologicalCase.ShockTypeStatus = cardiologicalOutPatientCase.ShockTypeStatus;
                        cardiologicalCase.ShockTypeId = cardiologicalOutPatientCase.ShockTypeId;
                        //cardiologicalCase.CATDStatus = cardiologicalOutPatientCase.CATDStatus;
                        cardiologicalCase.CATDId = cardiologicalOutPatientCase.CATDId;
                        //cardiologicalCase.CHDStatus = cardiologicalOutPatientCase.CHDStatus;
                        cardiologicalCase.CHDId = cardiologicalOutPatientCase.CHDId;
                        //cardiologicalCase.HVDStatus = cardiologicalOutPatientCase.HVDStatus;
                        cardiologicalCase.HVDId = cardiologicalOutPatientCase.HVDId;
                        //cardiologicalCase.CadiomyopathyStatus = cardiologicalOutPatientCase.CadiomyopathyStatus;
                        cardiologicalCase.CadiomyopathyId = cardiologicalOutPatientCase.CadiomyopathyId;
                        cardiologicalCase.MainDiagnose = cardiologicalOutPatientCase.MainDiagnose;
                        cardiologicalCase.OtherDiseaseId = cardiologicalOutPatientCase.OtherDiseaseId;
                        cardiologicalCase.TreatmentTypeId = cardiologicalOutPatientCase.TreatmentTypeId;
                        cardiologicalCase.ReferralOrganizationId = cardiologicalOutPatientCase.ReferralOrganizationId;
                        cardiologicalCase.DeathStatus = cardiologicalOutPatientCase.DeathStatus;
                        cardiologicalCase.DeathDate = cardiologicalOutPatientCase.DeathDate;
                        cardiologicalCase.MortalityTypeId = cardiologicalOutPatientCase.MortalityTypeId;
                        cardiologicalCase.DeathCauseId = cardiologicalOutPatientCase.DeathCauseId;
                        cardiologicalCase.DeathOrganizationId = cardiologicalOutPatientCase.DeathOrganizationId;
                        cardiologicalCase.Weight = cardiologicalOutPatientCase.Weight;
                        cardiologicalCase.Height = cardiologicalOutPatientCase.Height;
                        cardiologicalCase.BSA = cardiologicalOutPatientCase.BSA;
                        cardiologicalCase.BMI = cardiologicalOutPatientCase.BMI;
                        cardiologicalCase.SmokingStatusId = cardiologicalOutPatientCase.SmokingStatusId;
                        cardiologicalCase.MovementStatusId = cardiologicalOutPatientCase.MovementStatusId;
                        cardiologicalCase.AlcoholUsageId = cardiologicalOutPatientCase.AlcoholUsageId;
                        //cardiologicalCase.ImmunologicalStatus = cardiologicalOutPatientCase.ImmunologicalStatus;
                        cardiologicalCase.ImmunologicalStatusId = cardiologicalOutPatientCase.ImmunologicalStatusId;
                        cardiologicalCase.CardiologicalInheritance = cardiologicalOutPatientCase.CardiologicalInheritance;
                        cardiologicalCase.ClimaxStatusId = cardiologicalOutPatientCase.ClimaxStatusId;
                        cardiologicalCase.DiabetesMellitusStatus = cardiologicalOutPatientCase.DiabetesMellitusStatus;
                        cardiologicalCase.Glucose = cardiologicalOutPatientCase.Glucose;
                        cardiologicalCase.StroceCount = cardiologicalOutPatientCase.StroceCount;
                        cardiologicalCase.StrokeStatus = cardiologicalOutPatientCase.StrokeStatus;
                        cardiologicalCase.StrokeTypeId = cardiologicalOutPatientCase.StrokeTypeId;
                        //cardiologicalCase.PulmonaryDiseaseStatus = cardiologicalOutPatientCase.PulmonaryDiseaseStatus;
                        cardiologicalCase.PulmonaryDiseaseId = cardiologicalOutPatientCase.PulmonaryDiseaseId;
                        cardiologicalCase.COPDId = cardiologicalOutPatientCase.COPDId;
                        //cardiologicalCase.PVDTStatus = cardiologicalOutPatientCase.PVDTStatus;
                        cardiologicalCase.PVDTId = cardiologicalOutPatientCase.PVDTId;
                        //cardiologicalCase.RheumatismStatus = cardiologicalOutPatientCase.RheumatismStatus;
                        cardiologicalCase.RheumatizmDurationId = cardiologicalOutPatientCase.RheumatizmDurationId;
                        //cardiologicalCase.InfectiousEndocarditisStatus = cardiologicalOutPatientCase.InfectiousEndocarditisStatus;
                        cardiologicalCase.InfectiousEndocarditisId = cardiologicalOutPatientCase.InfectiousEndocarditisId;
                        cardiologicalCase.BloodCholesterolId = cardiologicalOutPatientCase.BloodCholesterolId;
                        //cardiologicalCase.HypertensionStatus = cardiologicalOutPatientCase.HypertensionStatus;
                        cardiologicalCase.HypertensionDurationId = cardiologicalOutPatientCase.HypertensionDurationId;
                        //cardiologicalCase.UrogenitalicDiseaseStatus = cardiologicalOutPatientCase.UrogenitalicDiseaseStatus;
                        cardiologicalCase.UrogenitalicDiseaseId = cardiologicalOutPatientCase.UrogenitalicDiseaseId;
                        //cardiologicalCase.GastrointestinalDiseaseStatus = cardiologicalOutPatientCase.GastrointestinalDiseaseStatus;
                        cardiologicalCase.GastrointestinalDiseaseId = cardiologicalOutPatientCase.GastrointestinalDiseaseId;
                        cardiologicalCase.ImmunosuppressiveTherapyStatus = cardiologicalOutPatientCase.ImmunosuppressiveTherapyStatus;
                        cardiologicalCase.ResuscitationStatus = cardiologicalOutPatientCase.ResuscitationStatus;
                        cardiologicalCase.DentalDiseaseId = cardiologicalOutPatientCase.DentalDiseaseId;
                        cardiologicalCase.DiseaseStatusId = cardiologicalOutPatientCase.DiseaseStatusId;
                        cardiologicalCase.SmokingTypeId = cardiologicalOutPatientCase.SmokingTypeId;

                        db.Entry(cardiologicalCase).State = EntityState.Modified;
                        
                        ////ենթաաղյուսակների լրացում
                        if (cardiologicalOutPatientCase.CardiologicalCaseComplians != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseComplians)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseComplian = new CardiologicalCaseComplian();
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Add(cardiologicalCaseComplian);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseComplian cardiologicalCaseComplian = db.CardiologicalCaseComplians.Find(item.CardiologicalCaseComplianId);
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Attach(cardiologicalCaseComplian);
                                    db.Entry(cardiologicalCaseComplian).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseComplian cardiologicalCaseComplian = db.CardiologicalCaseComplians.Find(item.CardiologicalCaseComplianId);
                                    db.CardiologicalCaseComplians.Remove(cardiologicalCaseComplian);
                                }
                            }
                        }

                        if (cardiologicalOutPatientCase.CardiologicalCaseDiseases != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseDiseases)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDisease = new CardiologicalCaseDisease();
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Add(cardiologicalCaseDisease);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseDisease cardiologicalCaseDisease = db.CardiologicalCaseDiseases.Find(item.CardiologicalCaseDiseaseId);
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Attach(cardiologicalCaseDisease);
                                    db.Entry(cardiologicalCaseDisease).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseDisease cardiologicalCaseDisease = db.CardiologicalCaseDiseases.Find(item.CardiologicalCaseDiseaseId);
                                    db.CardiologicalCaseDiseases.Remove(cardiologicalCaseDisease);
                                }
                            }
                        }

                        if (cardiologicalOutPatientCase.CardiologicalCaseDrugs != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDrug = new CardiologicalCaseDrug();
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Add(cardiologicalCaseDrug);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseDrug cardiologicalCaseDrug = db.CardiologicalCaseDrugs.Find(item.CardiologicalCaseDrugId);
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Attach(cardiologicalCaseDrug);
                                    db.Entry(cardiologicalCaseDrug).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseDrug cardiologicalCaseDrug = db.CardiologicalCaseDrugs.Find(item.CardiologicalCaseDrugId);
                                    db.CardiologicalCaseDrugs.Remove(cardiologicalCaseDrug);
                                }
                            }
                        }

                        if (cardiologicalOutPatientCase.CardiologicalCaseInvasions != null)
                        {
                            foreach (var item in cardiologicalOutPatientCase.CardiologicalCaseInvasions)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseInvasion = new CardiologicalCaseInvasion();
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Add(cardiologicalCaseInvasion);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseInvasion cardiologicalCaseInvasion = db.CardiologicalCaseInvasions.Find(item.CardiologicalCaseInvasionId);
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Attach(cardiologicalCaseInvasion);
                                    db.Entry(cardiologicalCaseInvasion).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseInvasion cardiologicalCaseInvasion = db.CardiologicalCaseInvasions.Find(item.CardiologicalCaseInvasionId);
                                    db.CardiologicalCaseInvasions.Remove(cardiologicalCaseInvasion);
                                }
                            }
                        }

                    }

                    db.SaveChanges();
                    return Json(new { success = true, responseText = string.Empty }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message }, JsonRequestBehavior.AllowGet);
                //return View("Error", new HandleErrorInfo(ex, "CardiologicalCase", "SaveOutPatientCase"));
            }
        }

        [HttpPost]
        public ActionResult SaveInHospitalCase(CardiologicalInHospitalCase cardiologicalInHospitalCase)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return this.Json(new { statuscode = -1, message = General.msgInvalidModel }, JsonRequestBehavior.AllowGet);
                }

                using (var db = new StoreContext())
                {
                    // եթե 2-րդ մակարդակի աղյուսակի տողը նոր գրառումա ավելացնում ենք
                    if (cardiologicalInHospitalCase.CardiologicalCaseId == 0)
                    {
                        ////////////////////////////////////////////////////////////
                        var cardiologicalCase = new CardiologicalCase();
                        cardiologicalCase.CardiologicalCaseId = cardiologicalInHospitalCase.CardiologicalCaseId;
                        cardiologicalCase.ResidentId = cardiologicalInHospitalCase.ResidentId;
                        cardiologicalCase.OutPatient = false;                        
                        cardiologicalCase.ConsultationDate = null;
                        cardiologicalCase.InHospital = cardiologicalInHospitalCase.InHospital;
                        cardiologicalCase.StartDate  = cardiologicalInHospitalCase.StartDate;
                        cardiologicalCase.DischargeDate  = cardiologicalInHospitalCase.DischargeDate;
                        cardiologicalCase.CAD = cardiologicalInHospitalCase.CAD;
                        //cardiologicalCase.CCSStatus = cardiologicalInHospitalCase.CCSStatus;
                        cardiologicalCase.CCSId = cardiologicalInHospitalCase.CCSId;
                        //cardiologicalCase.HBCriteriaStatus = cardiologicalInHospitalCase.HBCriteriaStatus;
                        cardiologicalCase.HBCriteriaId = cardiologicalInHospitalCase.HBCriteriaId;
                        //cardiologicalCase.HITStatus = cardiologicalInHospitalCase.HITStatus;
                        cardiologicalCase.HITId = cardiologicalInHospitalCase.HITId;
                        cardiologicalCase.NYHAId = cardiologicalInHospitalCase.NYHAId;
                        //cardiologicalCase.ShockTypeStatus = cardiologicalInHospitalCase.ShockTypeStatus;
                        cardiologicalCase.ShockTypeId = cardiologicalInHospitalCase.ShockTypeId;
                        //cardiologicalCase.CATDStatus = cardiologicalInHospitalCase.CATDStatus;
                        cardiologicalCase.CATDId = cardiologicalInHospitalCase.CATDId;
                        //cardiologicalCase.CHDStatus = cardiologicalInHospitalCase.CHDStatus;
                        cardiologicalCase.CHDId = cardiologicalInHospitalCase.CHDId;
                        //cardiologicalCase.HVDStatus = cardiologicalInHospitalCase.HVDStatus;
                        cardiologicalCase.HVDId = cardiologicalInHospitalCase.HVDId;
                        //cardiologicalCase.CadiomyopathyStatus = cardiologicalInHospitalCase.CadiomyopathyStatus;
                        cardiologicalCase.CadiomyopathyId = cardiologicalInHospitalCase.CadiomyopathyId;
                        cardiologicalCase.MainDiagnose = cardiologicalInHospitalCase.MainDiagnose;
                        cardiologicalCase.OtherDiseaseId = cardiologicalInHospitalCase.OtherDiseaseId;
                        cardiologicalCase.TreatmentTypeId = cardiologicalInHospitalCase.TreatmentTypeId;
                        cardiologicalCase.ReferralOrganizationId = cardiologicalInHospitalCase.ReferralOrganizationId;
                        cardiologicalCase.DeathStatus = cardiologicalInHospitalCase.DeathStatus;
                        cardiologicalCase.DeathDate = cardiologicalInHospitalCase.DeathDate;
                        cardiologicalCase.MortalityTypeId = cardiologicalInHospitalCase.MortalityTypeId;
                        cardiologicalCase.DeathCauseId = cardiologicalInHospitalCase.DeathCauseId;
                        cardiologicalCase.DeathOrganizationId = cardiologicalInHospitalCase.DeathOrganizationId;
                        cardiologicalCase.Weight = cardiologicalInHospitalCase.Weight;
                        cardiologicalCase.Height = cardiologicalInHospitalCase.Height;
                        cardiologicalCase.BSA = cardiologicalInHospitalCase.BSA;
                        cardiologicalCase.BMI = cardiologicalInHospitalCase.BMI;
                        cardiologicalCase.SmokingStatusId = cardiologicalInHospitalCase.SmokingStatusId;
                        cardiologicalCase.MovementStatusId = cardiologicalInHospitalCase.MovementStatusId;
                        cardiologicalCase.AlcoholUsageId = cardiologicalInHospitalCase.AlcoholUsageId;
                        //cardiologicalCase.ImmunologicalStatus = cardiologicalInHospitalCase.ImmunologicalStatus;
                        cardiologicalCase.ImmunologicalStatusId = cardiologicalInHospitalCase.ImmunologicalStatusId;
                        cardiologicalCase.CardiologicalInheritance = cardiologicalInHospitalCase.CardiologicalInheritance;
                        cardiologicalCase.ClimaxStatusId = cardiologicalInHospitalCase.ClimaxStatusId;
                        cardiologicalCase.DiabetesMellitusStatus = cardiologicalInHospitalCase.DiabetesMellitusStatus;
                        cardiologicalCase.Glucose = cardiologicalInHospitalCase.Glucose;
                        cardiologicalCase.StroceCount = cardiologicalInHospitalCase.StroceCount;
                        cardiologicalCase.StrokeStatus = cardiologicalInHospitalCase.StrokeStatus;
                        cardiologicalCase.StrokeTypeId = cardiologicalInHospitalCase.StrokeTypeId;
                        //cardiologicalCase.PulmonaryDiseaseStatus = cardiologicalInHospitalCase.PulmonaryDiseaseStatus;
                        cardiologicalCase.PulmonaryDiseaseId = cardiologicalInHospitalCase.PulmonaryDiseaseId;
                        cardiologicalCase.COPDId = cardiologicalInHospitalCase.COPDId;
                        //cardiologicalCase.PVDTStatus = cardiologicalInHospitalCase.PVDTStatus;
                        cardiologicalCase.PVDTId = cardiologicalInHospitalCase.PVDTId;
                        //cardiologicalCase.RheumatismStatus = cardiologicalInHospitalCase.RheumatismStatus;
                        cardiologicalCase.RheumatizmDurationId = cardiologicalInHospitalCase.RheumatizmDurationId;
                        //cardiologicalCase.InfectiousEndocarditisStatus = cardiologicalInHospitalCase.InfectiousEndocarditisStatus;
                        cardiologicalCase.InfectiousEndocarditisId = cardiologicalInHospitalCase.InfectiousEndocarditisId;
                        cardiologicalCase.BloodCholesterolId = cardiologicalInHospitalCase.BloodCholesterolId;
                        //cardiologicalCase.HypertensionStatus = cardiologicalInHospitalCase.HypertensionStatus;
                        cardiologicalCase.HypertensionDurationId = cardiologicalInHospitalCase.HypertensionDurationId;
                        //cardiologicalCase.UrogenitalicDiseaseStatus = cardiologicalInHospitalCase.UrogenitalicDiseaseStatus;
                        cardiologicalCase.UrogenitalicDiseaseId = cardiologicalInHospitalCase.UrogenitalicDiseaseId;
                        //cardiologicalCase.GastrointestinalDiseaseStatus = cardiologicalInHospitalCase.GastrointestinalDiseaseStatus;
                        cardiologicalCase.GastrointestinalDiseaseId = cardiologicalInHospitalCase.GastrointestinalDiseaseId;
                        cardiologicalCase.ImmunosuppressiveTherapyStatus = cardiologicalInHospitalCase.ImmunosuppressiveTherapyStatus;
                        cardiologicalCase.ResuscitationStatus = cardiologicalInHospitalCase.ResuscitationStatus;
                        cardiologicalCase.DentalDiseaseId = cardiologicalInHospitalCase.DentalDiseaseId;
                        cardiologicalCase.DiseaseStatusId = cardiologicalInHospitalCase.DiseaseStatusId;
                        cardiologicalCase.SmokingTypeId = cardiologicalInHospitalCase.SmokingTypeId;

                        db.CardiologicalCases.Add(cardiologicalCase);

                        if (cardiologicalInHospitalCase.CardiologicalCaseComplians != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseComplians)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseComplian = new CardiologicalCaseComplian();
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Add(cardiologicalCaseComplian);
                                }
                            }
                        }
                        if (cardiologicalInHospitalCase.CardiologicalCaseDiseases != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseDiseases)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDisease = new CardiologicalCaseDisease();
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Add(cardiologicalCaseDisease);
                                }
                            }
                        }
                        if (cardiologicalInHospitalCase.CardiologicalCaseDrugs != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDrug = new CardiologicalCaseDrug();
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Add(cardiologicalCaseDrug);
                                }
                            }
                        }
                        if (cardiologicalInHospitalCase.CardiologicalCaseInvasions != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseInvasions)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseInvasion = new CardiologicalCaseInvasion();
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Add(cardiologicalCaseInvasion);
                                }
                            }
                        }
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalCase cardiologicalCase = db.CardiologicalCases.Find(cardiologicalInHospitalCase.CardiologicalCaseId);
                        cardiologicalCase.ResidentId = cardiologicalInHospitalCase.ResidentId;
                        cardiologicalCase.OutPatient = false;
                        cardiologicalCase.ConsultationDate = null;
                        cardiologicalCase.InHospital = cardiologicalInHospitalCase.InHospital;
                        cardiologicalCase.StartDate = cardiologicalInHospitalCase.StartDate;
                        cardiologicalCase.DischargeDate = cardiologicalInHospitalCase.DischargeDate;
                        cardiologicalCase.CAD = cardiologicalInHospitalCase.CAD;
                        //cardiologicalCase.CCSStatus = cardiologicalInHospitalCase.CCSStatus;
                        cardiologicalCase.CCSId = cardiologicalInHospitalCase.CCSId;
                        //cardiologicalCase.HBCriteriaStatus = cardiologicalInHospitalCase.HBCriteriaStatus;
                        cardiologicalCase.HBCriteriaId = cardiologicalInHospitalCase.HBCriteriaId;
                        //cardiologicalCase.HITStatus = cardiologicalInHospitalCase.HITStatus;
                        cardiologicalCase.HITId = cardiologicalInHospitalCase.HITId;
                        cardiologicalCase.NYHAId = cardiologicalInHospitalCase.NYHAId;
                        //cardiologicalCase.ShockTypeStatus = cardiologicalInHospitalCase.ShockTypeStatus;
                        cardiologicalCase.ShockTypeId = cardiologicalInHospitalCase.ShockTypeId;
                        //cardiologicalCase.CATDStatus = cardiologicalInHospitalCase.CATDStatus;
                        cardiologicalCase.CATDId = cardiologicalInHospitalCase.CATDId;
                        //cardiologicalCase.CHDStatus = cardiologicalInHospitalCase.CHDStatus;
                        cardiologicalCase.CHDId = cardiologicalInHospitalCase.CHDId;
                        //cardiologicalCase.HVDStatus = cardiologicalInHospitalCase.HVDStatus;
                        cardiologicalCase.HVDId = cardiologicalInHospitalCase.HVDId;
                        //cardiologicalCase.CadiomyopathyStatus = cardiologicalInHospitalCase.CadiomyopathyStatus;
                        cardiologicalCase.CadiomyopathyId = cardiologicalInHospitalCase.CadiomyopathyId;
                        cardiologicalCase.MainDiagnose = cardiologicalInHospitalCase.MainDiagnose;
                        cardiologicalCase.OtherDiseaseId = cardiologicalInHospitalCase.OtherDiseaseId;
                        cardiologicalCase.TreatmentTypeId = cardiologicalInHospitalCase.TreatmentTypeId;
                        cardiologicalCase.ReferralOrganizationId = cardiologicalInHospitalCase.ReferralOrganizationId;
                        cardiologicalCase.DeathStatus = cardiologicalInHospitalCase.DeathStatus;
                        cardiologicalCase.DeathDate = cardiologicalInHospitalCase.DeathDate;
                        cardiologicalCase.MortalityTypeId = cardiologicalInHospitalCase.MortalityTypeId;
                        cardiologicalCase.DeathCauseId = cardiologicalInHospitalCase.DeathCauseId;
                        cardiologicalCase.DeathOrganizationId = cardiologicalInHospitalCase.DeathOrganizationId;
                        cardiologicalCase.Weight = cardiologicalInHospitalCase.Weight;
                        cardiologicalCase.Height = cardiologicalInHospitalCase.Height;
                        cardiologicalCase.BSA = cardiologicalInHospitalCase.BSA;
                        cardiologicalCase.BMI = cardiologicalInHospitalCase.BMI;
                        cardiologicalCase.SmokingStatusId = cardiologicalInHospitalCase.SmokingStatusId;
                        cardiologicalCase.MovementStatusId = cardiologicalInHospitalCase.MovementStatusId;
                        cardiologicalCase.AlcoholUsageId = cardiologicalInHospitalCase.AlcoholUsageId;
                        //cardiologicalCase.ImmunologicalStatus = cardiologicalInHospitalCase.ImmunologicalStatus;
                        cardiologicalCase.ImmunologicalStatusId = cardiologicalInHospitalCase.ImmunologicalStatusId;
                        cardiologicalCase.CardiologicalInheritance = cardiologicalInHospitalCase.CardiologicalInheritance;
                        cardiologicalCase.ClimaxStatusId = cardiologicalInHospitalCase.ClimaxStatusId;
                        cardiologicalCase.DiabetesMellitusStatus = cardiologicalInHospitalCase.DiabetesMellitusStatus;
                        cardiologicalCase.Glucose = cardiologicalInHospitalCase.Glucose;
                        cardiologicalCase.StroceCount = cardiologicalInHospitalCase.StroceCount;
                        cardiologicalCase.StrokeStatus = cardiologicalInHospitalCase.StrokeStatus;
                        cardiologicalCase.StrokeTypeId = cardiologicalInHospitalCase.StrokeTypeId;
                        //cardiologicalCase.PulmonaryDiseaseStatus = cardiologicalInHospitalCase.PulmonaryDiseaseStatus;
                        cardiologicalCase.PulmonaryDiseaseId = cardiologicalInHospitalCase.PulmonaryDiseaseId;
                        cardiologicalCase.COPDId = cardiologicalInHospitalCase.COPDId;
                        //cardiologicalCase.PVDTStatus = cardiologicalInHospitalCase.PVDTStatus;
                        cardiologicalCase.PVDTId = cardiologicalInHospitalCase.PVDTId;
                        //cardiologicalCase.RheumatismStatus = cardiologicalInHospitalCase.RheumatismStatus;
                        cardiologicalCase.RheumatizmDurationId = cardiologicalInHospitalCase.RheumatizmDurationId;
                        //cardiologicalCase.InfectiousEndocarditisStatus = cardiologicalInHospitalCase.InfectiousEndocarditisStatus;
                        cardiologicalCase.InfectiousEndocarditisId = cardiologicalInHospitalCase.InfectiousEndocarditisId;
                        cardiologicalCase.BloodCholesterolId = cardiologicalInHospitalCase.BloodCholesterolId;
                        //cardiologicalCase.HypertensionStatus = cardiologicalInHospitalCase.HypertensionStatus;
                        cardiologicalCase.HypertensionDurationId = cardiologicalInHospitalCase.HypertensionDurationId;
                        //cardiologicalCase.UrogenitalicDiseaseStatus = cardiologicalInHospitalCase.UrogenitalicDiseaseStatus;
                        cardiologicalCase.UrogenitalicDiseaseId = cardiologicalInHospitalCase.UrogenitalicDiseaseId;
                        //cardiologicalCase.GastrointestinalDiseaseStatus = cardiologicalInHospitalCase.GastrointestinalDiseaseStatus;
                        cardiologicalCase.GastrointestinalDiseaseId = cardiologicalInHospitalCase.GastrointestinalDiseaseId;
                        cardiologicalCase.ImmunosuppressiveTherapyStatus = cardiologicalInHospitalCase.ImmunosuppressiveTherapyStatus;
                        cardiologicalCase.ResuscitationStatus = cardiologicalInHospitalCase.ResuscitationStatus;
                        cardiologicalCase.DentalDiseaseId = cardiologicalInHospitalCase.DentalDiseaseId;
                        cardiologicalCase.DiseaseStatusId = cardiologicalInHospitalCase.DiseaseStatusId;
                        cardiologicalCase.SmokingTypeId = cardiologicalInHospitalCase.SmokingTypeId;

                        db.Entry(cardiologicalCase).State = EntityState.Modified;

                        ////ենթաաղյուսակների լրացում
                        if (cardiologicalInHospitalCase.CardiologicalCaseComplians != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseComplians)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseComplian = new CardiologicalCaseComplian();
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Add(cardiologicalCaseComplian);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseComplian cardiologicalCaseComplian = db.CardiologicalCaseComplians.Find(item.CardiologicalCaseComplianId);
                                    cardiologicalCaseComplian.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseComplian.CardiologicalCaseComplianId = item.CardiologicalCaseComplianId;
                                    cardiologicalCaseComplian.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseComplian.ComplianId = item.ComplianId;
                                    db.CardiologicalCaseComplians.Attach(cardiologicalCaseComplian);
                                    db.Entry(cardiologicalCaseComplian).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseComplian cardiologicalCaseComplian = db.CardiologicalCaseComplians.Find(item.CardiologicalCaseComplianId);
                                    db.CardiologicalCaseComplians.Remove(cardiologicalCaseComplian);
                                }
                            }
                        }

                        if (cardiologicalInHospitalCase.CardiologicalCaseDiseases != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseDiseases)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDisease = new CardiologicalCaseDisease();
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Add(cardiologicalCaseDisease);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseDisease cardiologicalCaseDisease = db.CardiologicalCaseDiseases.Find(item.CardiologicalCaseDiseaseId);
                                    cardiologicalCaseDisease.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDisease.CardiologicalCaseDiseaseId = item.CardiologicalCaseDiseaseId;
                                    cardiologicalCaseDisease.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDisease.DiseaseDate = item.DiseaseDate;
                                    cardiologicalCaseDisease.DiseaseId = item.DiseaseId;
                                    cardiologicalCaseDisease.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseDiseases.Attach(cardiologicalCaseDisease);
                                    db.Entry(cardiologicalCaseDisease).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseDisease cardiologicalCaseDisease = db.CardiologicalCaseDiseases.Find(item.CardiologicalCaseDiseaseId);
                                    db.CardiologicalCaseDiseases.Remove(cardiologicalCaseDisease);
                                }
                            }
                        }

                        if (cardiologicalInHospitalCase.CardiologicalCaseDrugs != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseDrug = new CardiologicalCaseDrug();
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Add(cardiologicalCaseDrug);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseDrug cardiologicalCaseDrug = db.CardiologicalCaseDrugs.Find(item.CardiologicalCaseDrugId);
                                    cardiologicalCaseDrug.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseDrug.CardiologicalCaseDrugId = item.CardiologicalCaseDrugId;
                                    cardiologicalCaseDrug.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseDrug.DrugFrequencyId = item.DrugFrequencyId;
                                    cardiologicalCaseDrug.DrugId = item.DrugId;
                                    cardiologicalCaseDrug.Duration = item.Duration;
                                    db.CardiologicalCaseDrugs.Attach(cardiologicalCaseDrug);
                                    db.Entry(cardiologicalCaseDrug).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseDrug cardiologicalCaseDrug = db.CardiologicalCaseDrugs.Find(item.CardiologicalCaseDrugId);
                                    db.CardiologicalCaseDrugs.Remove(cardiologicalCaseDrug);
                                }
                            }
                        }

                        if (cardiologicalInHospitalCase.CardiologicalCaseInvasions != null)
                        {
                            foreach (var item in cardiologicalInHospitalCase.CardiologicalCaseInvasions)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    var cardiologicalCaseInvasion = new CardiologicalCaseInvasion();
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Add(cardiologicalCaseInvasion);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    CardiologicalCaseInvasion cardiologicalCaseInvasion = db.CardiologicalCaseInvasions.Find(item.CardiologicalCaseInvasionId);
                                    cardiologicalCaseInvasion.CardiologicalCase = cardiologicalCase;
                                    cardiologicalCaseInvasion.CardiologicalCaseId = item.CardiologicalCaseId;
                                    cardiologicalCaseInvasion.CardiologicalCaseInvasionId = item.CardiologicalCaseInvasionId;
                                    cardiologicalCaseInvasion.InvasionDate = item.InvasionDate;
                                    cardiologicalCaseInvasion.InvasionId = item.InvasionId;
                                    cardiologicalCaseInvasion.OrganizationId = item.OrganizationId;
                                    db.CardiologicalCaseInvasions.Attach(cardiologicalCaseInvasion);
                                    db.Entry(cardiologicalCaseInvasion).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCaseInvasion cardiologicalCaseInvasion = db.CardiologicalCaseInvasions.Find(item.CardiologicalCaseInvasionId);
                                    db.CardiologicalCaseInvasions.Remove(cardiologicalCaseInvasion);
                                }
                            }
                        }

                    }

                    db.SaveChanges();
                    return Json(new { success = true, responseText = string.Empty }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                //return View("Error", new HandleErrorInfo(ex, "CardiologicalCase", "SaveOutPatientCase"));
                return Json(new { success = false, responseText = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult DeleteCardiologicalCase([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalCase()
                        {
                            CardiologicalCaseId = Convert.ToInt32(id),
                        };
                        db.CardiologicalCases.Attach(item);
                        db.CardiologicalCases.Remove(item);

                        db.SaveChanges();
                    }
                }
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        private void OrganizeViewBugs(StoreContext db)
        {
            var lCCSS = new List<SelectListItem>();
            lCCSS = db.CCSS.Select(x => new SelectListItem { Text = x.CCSName, Value = x.CCSId.ToString() }).ToList();
            ViewBag.vbCCSS = lCCSS;

            var lHBCriterias = new List<SelectListItem>();
            lHBCriterias = db.HBCriterias.Select(x => new SelectListItem { Text = x.HBCriteriaName, Value = x.HBCriteriaId.ToString() }).ToList();
            ViewBag.vbHBCriterias = lHBCriterias;

            var lHITS = new List<SelectListItem>();
            lHITS = db.HITS.Select(x => new SelectListItem { Text = x.HITName, Value = x.HITId.ToString() }).ToList();
            ViewBag.vbHITS = lHITS;

            var lNYHAS = new List<SelectListItem>();
            lNYHAS = db.NYHAS.Select(x => new SelectListItem { Text = x.NYHAName, Value = x.NYHAId.ToString() }).ToList();
            ViewBag.vbNYHAS = lNYHAS;

            var lShockTypes = new List<SelectListItem>();
            lShockTypes = db.ShockTypes.Select(x => new SelectListItem { Text = x.ShockTypeName, Value = x.ShockTypeId.ToString() }).ToList();
            ViewBag.vbShockTypes = lShockTypes;

            var lCATDS = new List<SelectListItem>();
            lCATDS = db.CATDS.Select(x => new SelectListItem { Text = x.CATDName, Value = x.CATDId.ToString() }).ToList();
            ViewBag.vbCATDS = lCATDS;

            var lCHDS = new List<SelectListItem>();
            lCHDS = db.CHDS.Select(x => new SelectListItem { Text = x.CHDName, Value = x.CHDId.ToString() }).ToList();
            ViewBag.vbCHDS = lCHDS;

            var lHVDS = new List<SelectListItem>();
            lHVDS = db.HVDS.Select(x => new SelectListItem { Text = x.HVDName, Value = x.HVDId.ToString() }).ToList();
            ViewBag.vbHVDS = lHVDS;

            var lCadiomyopathies = new List<SelectListItem>();
            lCadiomyopathies = db.Cadiomyopathies.Select(x => new SelectListItem { Text = x.CadiomyopathyName, Value = x.CadiomyopathyId.ToString() }).ToList();
            ViewBag.vbCadiomyopathies = lCadiomyopathies;

            var lTreatmentTypes = new List<SelectListItem>();
            lTreatmentTypes = db.TreatmentTypes.Select(x => new SelectListItem { Text = x.TreatmentTypeName, Value = x.TreatmentTypeId.ToString() }).ToList();
            ViewBag.vbTreatmentTypes = lTreatmentTypes;

            var lReferralOrganizations = new List<SelectListItem>();
            lReferralOrganizations = db.ReferralOrganizations.Select(x => new SelectListItem { Text = x.ReferralOrganizationName, Value = x.ReferralOrganizationId.ToString() }).ToList();
            ViewBag.vbReferralOrganizations = lReferralOrganizations;

            var lMortalityTypes = new List<SelectListItem>();
            lMortalityTypes = db.MortalityTypes.Select(x => new SelectListItem { Text = x.MortalityTypeName, Value = x.MortalityTypeId.ToString() }).ToList();
            ViewBag.vbMortalityTypes = lMortalityTypes;

            var lDeathCausis = new List<SelectListItem>();
            lDeathCausis = db.DeathCausis.Select(x => new SelectListItem { Text = x.DeathCauseName, Value = x.DeathCauseId.ToString() }).ToList();
            ViewBag.vbDeathCausis = lDeathCausis;

            var lDeathOrganizations = new List<SelectListItem>();
            lDeathOrganizations = db.DeathOrganizations.Select(x => new SelectListItem { Text = x.DeathOrganizationName, Value = x.DeathOrganizationId.ToString() }).ToList();
            ViewBag.vbDeathOrganizations = lDeathOrganizations;

            var lSmokingStatuses = new List<SelectListItem>();
            lSmokingStatuses = db.SmokingStatuses.Select(x => new SelectListItem { Text = x.SmokingStatusName, Value = x.SmokingStatusId.ToString() }).ToList();
            ViewBag.vbSmokingStatuses = lSmokingStatuses;

            var lMovementStatuses = new List<SelectListItem>();
            lMovementStatuses = db.MovementStatuses.Select(x => new SelectListItem { Text = x.MovementStatusName, Value = x.MovementStatusId.ToString() }).ToList();
            ViewBag.vbMovementStatuses = lMovementStatuses;

            var lAlcoholUsages = new List<SelectListItem>();
            lAlcoholUsages = db.AlcoholUsages.Select(x => new SelectListItem { Text = x.AlcoholUsageName, Value = x.AlcoholUsageId.ToString() }).ToList();
            ViewBag.vbAlcoholUsages = lAlcoholUsages;

            var lImmunologicalStatusis = new List<SelectListItem>();
            lImmunologicalStatusis = db.ImmunologicalStatusis.Select(x => new SelectListItem { Text = x.ImmunologicalStatusName, Value = x.ImmunologicalStatusId.ToString() }).ToList();
            ViewBag.vbImmunologicalStatusis = lImmunologicalStatusis;

            var lClimaxStatusis = new List<SelectListItem>();
            lClimaxStatusis = db.ClimaxStatusis.Select(x => new SelectListItem { Text = x.ClimaxStatusName, Value = x.ClimaxStatusId.ToString() }).ToList();
            ViewBag.vbClimaxStatusis = lClimaxStatusis;

            var lCOPDS = new List<SelectListItem>();
            lCOPDS = db.COPDS.Select(x => new SelectListItem { Text = x.COPDName, Value = x.COPDId.ToString() }).ToList();
            ViewBag.vbCOPDS = lCOPDS;

            var lOtherDiseases = new List<SelectListItem>();
            lOtherDiseases = db.OtherDiseases.Select(x => new SelectListItem { Text = x.OtherDiseaseName, Value = x.OtherDiseaseId.ToString() }).ToList();
            ViewBag.vbOtherDiseases = lOtherDiseases;

            var lStrokeTypes = new List<SelectListItem>();
            lStrokeTypes = db.StrokeTypes.Select(x => new SelectListItem { Text = x.StrokeTypeName, Value = x.StrokeTypeId.ToString() }).ToList();
            ViewBag.vbStrokeTypes = lStrokeTypes;

            var lPulmonaryDiseases = new List<SelectListItem>();
            lPulmonaryDiseases = db.PulmonaryDiseases.Select(x => new SelectListItem { Text = x.PulmonaryDiseaseName, Value = x.PulmonaryDiseaseId.ToString() }).ToList();
            ViewBag.vbPulmonaryDiseases = lPulmonaryDiseases;

            var lPVDTS = new List<SelectListItem>();
            lPVDTS = db.PVDTS.Select(x => new SelectListItem { Text = x.PVDTName, Value = x.PVDTId.ToString() }).ToList();
            ViewBag.vbPVDTS = lPVDTS;

            var lRheumatizmDurations = new List<SelectListItem>();
            lRheumatizmDurations = db.RheumatizmDurations.Select(x => new SelectListItem { Text = x.RheumatizmDurationName, Value = x.RheumatizmDurationId.ToString() }).ToList();
            ViewBag.vbRheumatizmDurations = lRheumatizmDurations;

            var lInfectiousEndocarditisis = new List<SelectListItem>();
            lInfectiousEndocarditisis = db.InfectiousEndocarditisis.Select(x => new SelectListItem { Text = x.InfectiousEndocarditisName, Value = x.InfectiousEndocarditisId.ToString() }).ToList();
            ViewBag.vbInfectiousEndocarditisis = lInfectiousEndocarditisis;

            var lBloodCholesterols = new List<SelectListItem>();
            lBloodCholesterols = db.BloodCholesterols.Select(x => new SelectListItem { Text = x.BloodCholesterolName, Value = x.BloodCholesterolId.ToString() }).ToList();
            ViewBag.vbBloodCholesterols = lBloodCholesterols;

            var lHypertensionDurations = new List<SelectListItem>();
            lHypertensionDurations = db.HypertensionDurations.Select(x => new SelectListItem { Text = x.HypertensionDurationName, Value = x.HypertensionDurationId.ToString() }).ToList();
            ViewBag.vbHypertensionDurations = lHypertensionDurations;

            var lUrogenitalicDiseases = new List<SelectListItem>();
            lUrogenitalicDiseases = db.UrogenitalicDiseases.Select(x => new SelectListItem { Text = x.UrogenitalicDiseaseName, Value = x.UrogenitalicDiseaseId.ToString() }).ToList();
            ViewBag.vbUrogenitalicDiseases = lUrogenitalicDiseases;

            var lGastrointestinalDiseasis = new List<SelectListItem>();
            lGastrointestinalDiseasis = db.GastrointestinalDiseasis.Select(x => new SelectListItem { Text = x.GastrointestinalDiseaseName, Value = x.GastrointestinalDiseaseId.ToString() }).ToList();
            ViewBag.vbGastrointestinalDiseasis = lGastrointestinalDiseasis;

            var lDentalDiseases = new List<SelectListItem>();
            lDentalDiseases = db.DentalDiseases.Select(x => new SelectListItem { Text = x.DentalDiseaseName, Value = x.DentalDiseaseId.ToString() }).ToList();
            ViewBag.vbDentalDiseases = lDentalDiseases;

            var lDiseaseStatuses = new List<SelectListItem>();
            lDiseaseStatuses = db.DiseaseStatuses.Select(x => new SelectListItem { Text = x.DiseaseStatusName, Value = x.DiseaseStatusId.ToString() }).ToList();
            ViewBag.vbDiseaseStatuses = lDiseaseStatuses;

            var lSmokingTypes = new List<SelectListItem>();
            lSmokingTypes = db.SmokingTypes.Select(x => new SelectListItem { Text = x.SmokingTypeName, Value = x.SmokingTypeId.ToString() }).ToList();
            ViewBag.vbSmokingTypes = lSmokingTypes;

            var lOrganizations = new List<SelectListItem>();
            lOrganizations = db.Organizations.Select(x => new SelectListItem { Text = x.OrganizationName, Value = x.OrganizationId.ToString() }).ToList();
            ViewBag.vbOrganizations = lOrganizations;

            var lDiseases = new List<SelectListItem>();
            lDiseases = db.Diseases.Select(x => new SelectListItem { Text = x.DiseaseName, Value = x.DiseaseId.ToString() }).ToList();
            ViewBag.vbDiseases = lDiseases;

            var lInvasions = new List<SelectListItem>();
            lInvasions = db.Invasions.Select(x => new SelectListItem { Text = x.InvasionName, Value = x.InvasionId.ToString() }).ToList();
            ViewBag.vbInvasions = lInvasions;

            var lDrugs = new List<SelectListItem>();
            lDrugs = db.Drugs.Select(x => new SelectListItem { Text = x.DrugName, Value = x.DrugId.ToString() }).ToList();
            ViewBag.vbDrugs = lDrugs;

            var lDrugFrequencies = new List<SelectListItem>();
            lDrugFrequencies = db.DrugFrequencies.Select(x => new SelectListItem { Text = x.DrugFrequencyName, Value = x.DrugFrequencyId.ToString() }).ToList();
            ViewBag.vbDrugFrequencies = lDrugFrequencies;

            var lComplians = new List<SelectListItem>();
            lComplians = db.Complians.Select(x => new SelectListItem { Text = x.ComplianName, Value = x.ComplianId.ToString() }).ToList();
            ViewBag.vbComplians = lComplians;
        }
    }
}