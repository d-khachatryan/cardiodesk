using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using CardioSence.Resources;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalsurgeryrole,systemadministratorrole")]
    public class CardiologicalSurgeryController : Controller
    {
        // GET: CardiologicalSurgery
        public ActionResult Index()
        {
            ViewBag.activeInv = "active";
            ViewBag.activeSurg = "active";
            return View();
        }
        public ActionResult ReadCardiologicalSurgeryItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryItem> items = db.CardiologicalSurgeryItems;
                DataSourceResult result = items.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult Create()
        {
            ViewBag.activeInv = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalSurgeryItem();
                    return View("InputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        // Նոր ավելացված ֆունկցիա
        public ActionResult CreateWithResident(int? id)
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    Resident resident = db.Residents.Find(id);
                    var item = new CardiologicalSurgeryItem();

                    item.ResidentId = resident.ResidentId;
                    item.PatientId = resident.PatientId;
                    item.ResidentFirstName = resident.ResidentFirstName;
                    item.ResidentLastName = resident.ResidentLastName;
                    item.ResidentPatronymicName = resident.ResidentPatronymicName;
                    item.BirthDate = resident.BirthDate;

                    return View("InputForm", item);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        public ActionResult Update(int? id)
        {
            ViewBag.activeInv = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    IQueryable<CardiologicalSurgeryItem> item = db.CardiologicalSurgeryItems
                        //.Include(m => m.CardiologicalSurgeryComplications)
                        //.Include(m => m.CardiologicalSurgeryDrugs)
                        //.Include(m => m.CardiologicalSurgeryProcedures)
                        //.Include(m => m.CardiologicalSurgeryValves)
                        .Where(p => p.CardiologicalSurgeryId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalSurgery cardiologicalSurgery)
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
                    if (cardiologicalSurgery.CardiologicalSurgeryId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalSurgeryes.Add(cardiologicalSurgery);

                        //հետո ավելացնում ենք ենթաաղյոսակների տողերը ամեն մի ենթաաղյուսակի համար, էս դեպքում 4 աղյուսակի համար
                        if (cardiologicalSurgery.CardiologicalSurgeryComplications != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryComplications)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = cardiologicalSurgery;
                                    db.CardiologicalSurgeryComplications.Add(item);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryDrugs != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = cardiologicalSurgery;
                                    db.CardiologicalSurgeryDrugs.Add(item);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryProcedures != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryProcedures)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = cardiologicalSurgery;
                                    db.CardiologicalSurgeryProcedures.Add(item);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryValves != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryValves)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = cardiologicalSurgery;
                                    db.CardiologicalSurgeryValves.Add(item);
                                }
                            }
                        }

                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalSurgery mCardiologicalSurgery = db.CardiologicalSurgeryes.Find(cardiologicalSurgery.CardiologicalSurgeryId);

                        mCardiologicalSurgery.ResidentId = cardiologicalSurgery.ResidentId;
                        mCardiologicalSurgery.CardiologicalSurgeryDate = cardiologicalSurgery.CardiologicalSurgeryDate;
                        mCardiologicalSurgery.DiseaseStatusId = cardiologicalSurgery.DiseaseStatusId;
                        mCardiologicalSurgery.CPB = cardiologicalSurgery.CPB;
                        mCardiologicalSurgery.EuroSCORE = cardiologicalSurgery.EuroSCORE;
                        mCardiologicalSurgery.CABGX = cardiologicalSurgery.CABGX;
                        mCardiologicalSurgery.BypassB1Id = cardiologicalSurgery.BypassB1Id;
                        mCardiologicalSurgery.SegmentB1Id = cardiologicalSurgery.SegmentB1Id;
                        mCardiologicalSurgery.BypassB2Id = cardiologicalSurgery.BypassB2Id;
                        mCardiologicalSurgery.SegmentB2Id = cardiologicalSurgery.SegmentB2Id;
                        mCardiologicalSurgery.BypassB3Id = cardiologicalSurgery.BypassB3Id;
                        mCardiologicalSurgery.SegmentB3Id = cardiologicalSurgery.SegmentB3Id;
                        mCardiologicalSurgery.BypassC1Id = cardiologicalSurgery.BypassC1Id;
                        mCardiologicalSurgery.SegmentC1Id = cardiologicalSurgery.SegmentC1Id;
                        mCardiologicalSurgery.SegmentD1Id = cardiologicalSurgery.SegmentD1Id;
                        mCardiologicalSurgery.BypassC2Id = cardiologicalSurgery.BypassC2Id;
                        mCardiologicalSurgery.SegmentC2Id = cardiologicalSurgery.SegmentC2Id;
                        mCardiologicalSurgery.SegmentD2Id = cardiologicalSurgery.SegmentD2Id;
                        mCardiologicalSurgery.BypassC3Id = cardiologicalSurgery.BypassC3Id;
                        mCardiologicalSurgery.SegmentC3Id = cardiologicalSurgery.SegmentC3Id;
                        mCardiologicalSurgery.SegmentD3Id = cardiologicalSurgery.SegmentD3Id;
                        mCardiologicalSurgery.LFL = cardiologicalSurgery.LFL;
                        mCardiologicalSurgery.HFL = cardiologicalSurgery.HFL;
                        mCardiologicalSurgery.NaCl = cardiologicalSurgery.NaCl;
                        mCardiologicalSurgery.GEL = cardiologicalSurgery.GEL;
                        mCardiologicalSurgery.Mannitol = cardiologicalSurgery.Mannitol;
                        mCardiologicalSurgery.BicarbonateTypeId = cardiologicalSurgery.BicarbonateTypeId;
                        mCardiologicalSurgery.NaHCO3 = cardiologicalSurgery.NaHCO3;
                        mCardiologicalSurgery.Heparin1 = cardiologicalSurgery.Heparin1;
                        mCardiologicalSurgery.CaCl2 = cardiologicalSurgery.CaCl2;
                        mCardiologicalSurgery.RBCCPB = cardiologicalSurgery.RBCCPB;
                        mCardiologicalSurgery.FFPCPB = cardiologicalSurgery.FFPCPB;
                        mCardiologicalSurgery.LiquidId = cardiologicalSurgery.LiquidId;
                        mCardiologicalSurgery.Other1 = cardiologicalSurgery.Other1;
                        //mCardiologicalSurgery.PrimaryVolume = cardiologicalSurgery.PrimaryVolume;
                        mCardiologicalSurgery.Na = cardiologicalSurgery.Na;
                        mCardiologicalSurgery.Gelofusin = cardiologicalSurgery.Gelofusin;
                        mCardiologicalSurgery.Man = cardiologicalSurgery.Man;
                        mCardiologicalSurgery.NaHCO = cardiologicalSurgery.NaHCO;
                        mCardiologicalSurgery.Heparin2 = cardiologicalSurgery.Heparin2;
                        mCardiologicalSurgery.CaCl = cardiologicalSurgery.CaCl;
                        mCardiologicalSurgery.R = cardiologicalSurgery.R;
                        mCardiologicalSurgery.F = cardiologicalSurgery.F;
                        mCardiologicalSurgery.Other2 = cardiologicalSurgery.Other2;
                        //mCardiologicalSurgery.TotalVolume = cardiologicalSurgery.TotalVolume;
                        mCardiologicalSurgery.ResidualVolume = cardiologicalSurgery.ResidualVolume;
                        //mCardiologicalSurgery.InPatientVolume = cardiologicalSurgery.InPatientVolume;
                        mCardiologicalSurgery.SkinIncisionStartTime = cardiologicalSurgery.SkinIncisionStartTime;
                        mCardiologicalSurgery.SkinIncisionCloseTime = cardiologicalSurgery.SkinIncisionCloseTime;
                        //mCardiologicalSurgery.TotalOperationTime = cardiologicalSurgery.TotalOperationTime;
                        mCardiologicalSurgery.CrossClampTime = cardiologicalSurgery.CrossClampTime;
                        mCardiologicalSurgery.BypassTime = cardiologicalSurgery.BypassTime;
                        mCardiologicalSurgery.CardioplegiaTypeId = cardiologicalSurgery.CardioplegiaTypeId;
                        mCardiologicalSurgery.AnesthesiaTime = cardiologicalSurgery.AnesthesiaTime;
                        mCardiologicalSurgery.RBCId = cardiologicalSurgery.RBCId;
                        mCardiologicalSurgery.FFPId = cardiologicalSurgery.FFPId;
                        mCardiologicalSurgery.PLTId = cardiologicalSurgery.PLTId;
                        mCardiologicalSurgery.InotropicSupportId = cardiologicalSurgery.InotropicSupportId;
                        mCardiologicalSurgery.BloodLossVolume = cardiologicalSurgery.BloodLossVolume;
                        mCardiologicalSurgery.SkinTemperature = cardiologicalSurgery.SkinTemperature;
                        mCardiologicalSurgery.ExtubatedPOD = cardiologicalSurgery.ExtubatedPOD;
                        mCardiologicalSurgery.InitialHoursVentilated = cardiologicalSurgery.InitialHoursVentilated;
                        mCardiologicalSurgery.ReIntubation = cardiologicalSurgery.ReIntubation;
                        mCardiologicalSurgery.AdditionalHoursVentilated = cardiologicalSurgery.AdditionalHoursVentilated;
                        //mCardiologicalSurgery.TotalHoursVentilated = cardiologicalSurgery.TotalHoursVentilated;
                        mCardiologicalSurgery.Hb = cardiologicalSurgery.Hb;
                        mCardiologicalSurgery.Hct = cardiologicalSurgery.Hct;
                        mCardiologicalSurgery.Platelet = cardiologicalSurgery.Platelet;
                        mCardiologicalSurgery.Creatinine = cardiologicalSurgery.Creatinine;
                        mCardiologicalSurgery.APTT = cardiologicalSurgery.APTT;
                        mCardiologicalSurgery.Sodium = cardiologicalSurgery.Sodium;
                        mCardiologicalSurgery.Potassium = cardiologicalSurgery.Potassium;
                        mCardiologicalSurgery.PH = cardiologicalSurgery.PH;
                        mCardiologicalSurgery.PaO2 = cardiologicalSurgery.PaO2;
                        mCardiologicalSurgery.PaCO2 = cardiologicalSurgery.PaCO2;
                        mCardiologicalSurgery.ICULength = cardiologicalSurgery.ICULength;
                        mCardiologicalSurgery.DischargeDate = cardiologicalSurgery.DischargeDate;
                        mCardiologicalSurgery.CSDLength = cardiologicalSurgery.CSDLength;
                        //mCardiologicalSurgery.Mortality = cardiologicalSurgery.Mortality;
                        mCardiologicalSurgery.DeathDate = cardiologicalSurgery.DeathDate;
                        mCardiologicalSurgery.DeathCauseId = cardiologicalSurgery.DeathCauseId;
                        mCardiologicalSurgery.Comment = cardiologicalSurgery.Comment;


                        db.Entry(mCardiologicalSurgery).State = EntityState.Modified;

                        //ենթաաղյուսակների լրացում
                        if (cardiologicalSurgery.CardiologicalSurgeryComplications != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryComplications)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = mCardiologicalSurgery;
                                    db.CardiologicalSurgeryComplications.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalSurgeryComplications.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalSurgeryComplication rCardiologicalSurgeryComplication = db.CardiologicalSurgeryComplications.Find(item.CardiologicalSurgeryComplicationId);
                                    db.CardiologicalSurgeryComplications.Remove(rCardiologicalSurgeryComplication);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryDrugs != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = mCardiologicalSurgery;
                                    db.CardiologicalSurgeryDrugs.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalSurgeryDrugs.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalSurgeryDrug rCardiologicalSurgeryDrug = db.CardiologicalSurgeryDrugs.Find(item.CardiologicalSurgeryDrugId);
                                    db.CardiologicalSurgeryDrugs.Remove(rCardiologicalSurgeryDrug);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryProcedures != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryProcedures)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = mCardiologicalSurgery;
                                    db.CardiologicalSurgeryProcedures.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalSurgeryProcedures.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalSurgeryProcedure rCardiologicalSurgeryProcedure = db.CardiologicalSurgeryProcedures.Find(item.CardiologicalSurgeryProcedureId);
                                    db.CardiologicalSurgeryProcedures.Remove(rCardiologicalSurgeryProcedure);
                                }
                            }
                        }

                        if (cardiologicalSurgery.CardiologicalSurgeryValves != null)
                        {
                            foreach (var item in cardiologicalSurgery.CardiologicalSurgeryValves)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalSurgery = mCardiologicalSurgery;
                                    db.CardiologicalSurgeryValves.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalSurgeryValves.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalSurgeryValve rCardiologicalSurgeryValve = db.CardiologicalSurgeryValves.Find(item.CardiologicalSurgeryValveId);
                                    db.CardiologicalSurgeryValves.Remove(rCardiologicalSurgeryValve);
                                }
                            }
                        }

                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalSurgery", "Save"));
            }
        }


        public ActionResult DeleteCardiologicalSurgery([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalSurgery()
                        {
                            CardiologicalSurgeryId = Convert.ToInt32(id),
                        };
                        db.CardiologicalSurgeryes.Attach(item);
                        db.CardiologicalSurgeryes.Remove(item);

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
            var lDiseaseStatuses = new List<SelectListItem>();
            lDiseaseStatuses = db.DiseaseStatuses.Select(x => new SelectListItem { Text = x.DiseaseStatusName, Value = x.DiseaseStatusId.ToString() }).ToList();
            ViewBag.vbDiseaseStatuses = lDiseaseStatuses;

            var lBypasses = new List<SelectListItem>();
            lBypasses = db.Bypasses.Select(x => new SelectListItem { Text = x.BypassName, Value = x.BypassId.ToString() }).ToList();
            ViewBag.vbBypasses = lBypasses;

            var lSegments = new List<SelectListItem>();
            lSegments = db.Segments.Select(x => new SelectListItem { Text = x.SegmentName, Value = x.SegmentId.ToString() }).ToList();
            ViewBag.vbSegments = lSegments;

            var lBicarbonateTypes = new List<SelectListItem>();
            lBicarbonateTypes = db.BicarbonateTypes.Select(x => new SelectListItem { Text = x.BicarbonateTypeName, Value = x.BicarbonateTypeId.ToString() }).ToList();
            ViewBag.vbBicarbonateTypes = lBicarbonateTypes;

            var lLiquids = new List<SelectListItem>();
            lLiquids = db.Liquids.Select(x => new SelectListItem { Text = x.LiquidName, Value = x.LiquidId.ToString() }).ToList();
            ViewBag.vbLiquids = lLiquids;

            var lCardioplegiaTypes = new List<SelectListItem>();
            lCardioplegiaTypes = db.CardioplegiaTypes.Select(x => new SelectListItem { Text = x.CardioplegiaTypeName, Value = x.CardioplegiaTypeId.ToString() }).ToList();
            ViewBag.vbCardioplegiaTypes = lCardioplegiaTypes;

            var lBloodProducts = new List<SelectListItem>();
            lBloodProducts = db.BloodProducts.Select(x => new SelectListItem { Text = x.BloodProductName, Value = x.BloodProductId.ToString() }).ToList();
            ViewBag.vbBloodProducts = lBloodProducts;

            var lInotropicSupports = new List<SelectListItem>();
            lInotropicSupports = db.InotropicSupports.Select(x => new SelectListItem { Text = x.InotropicSupportName, Value = x.InotropicSupportId.ToString() }).ToList();
            ViewBag.vbInotropicSupports = lInotropicSupports;

            var lDeathCausis = new List<SelectListItem>();
            lDeathCausis = db.DeathCausis.Select(x => new SelectListItem { Text = x.DeathCauseName, Value = x.DeathCauseId.ToString() }).ToList();
            ViewBag.vbDeathCausis = lDeathCausis;

            var lComplications = new List<SelectListItem>();
            lComplications = db.Complications.Select(x => new SelectListItem { Text = x.ComplicationName, Value = x.ComplicationId.ToString() }).ToList();
            ViewBag.vbComplications = lComplications;

            var lDrugs = new List<SelectListItem>();
            lDrugs = db.Drugs.Select(x => new SelectListItem { Text = x.DrugName, Value = x.DrugId.ToString() }).ToList();
            ViewBag.vbDrugs = lDrugs;

            var lDrugFrequencies = new List<SelectListItem>();
            lDrugFrequencies = db.DrugFrequencies.Select(x => new SelectListItem { Text = x.DrugFrequencyName, Value = x.DrugFrequencyId.ToString() }).ToList();
            ViewBag.vbDrugFrequencies = lDrugFrequencies;

            var lMedicalProcedures = new List<SelectListItem>();
            lMedicalProcedures = db.MedicalProcedures.Select(x => new SelectListItem { Text = x.MedicalProcedureName, Value = x.MedicalProcedureId.ToString() }).ToList();
            ViewBag.vbMedicalProcedures = lMedicalProcedures;

            var lValveSurgeryTypes = new List<SelectListItem>();
            lValveSurgeryTypes = db.ValveSurgeryTypes.Select(x => new SelectListItem { Text = x.ValveSurgeryTypeName, Value = x.ValveSurgeryTypeId.ToString() }).ToList();
            ViewBag.vbValveSurgeryTypes = lValveSurgeryTypes;

            var lProthesises = new List<SelectListItem>();
            lProthesises = db.Prothesises.Select(x => new SelectListItem { Text = x.ProthesisName, Value = x.ProthesisId.ToString() }).ToList();
            ViewBag.vbProthesises = lProthesises;

            var lImplants = new List<SelectListItem>();
            lImplants = db.Implants.Select(x => new SelectListItem { Text = x.ImplantName, Value = x.ImplantId.ToString() }).ToList();
            ViewBag.vbImplants = lImplants;

            var lImplantSizes = new List<SelectListItem>();
            lImplantSizes = db.ImplantSizes.Select(x => new SelectListItem { Text = x.ImplantSizeName, Value = x.ImplantSizeId.ToString() }).ToList();
            ViewBag.vbImplantSizes = lImplantSizes;

            var lValveTypes = new List<SelectListItem>();
            lValveTypes = db.ValveTypes.Select(x => new SelectListItem { Text = x.ValveTypeName, Value = x.ValveTypeId.ToString() }).ToList();
            ViewBag.vbValveTypes = lValveTypes;

        }
    }
}