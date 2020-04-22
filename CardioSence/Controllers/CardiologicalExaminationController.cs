using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardioSence.Resources;
using System.Data.Entity;
using System.Net;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalexaminationrole,systemadministratorrole")]
    public class CardiologicalExaminationController : Controller
    {
        // GET: CardiologicalExamination
        public ActionResult Index()
        {
            ViewBag.activeExm = "active";
            ViewBag.activeLab = "active";
            return View();
        }
        public ActionResult ReadCardiologicalExaminationItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalExaminationItem> items = db.CardiologicalExaminationItems;
                DataSourceResult result = items.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Create()
        {
            ViewBag.activeExm = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalExaminationItem();
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
                    var item = new CardiologicalExaminationItem();

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
            ViewBag.activeExm = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    IQueryable<CardiologicalExaminationItem> item = db.CardiologicalExaminationItems
                        .Where(p => p.CardiologicalExaminationId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalExamination cardiologicalExamination)
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
                    if (cardiologicalExamination.CardiologicalExaminationId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalExaminations.Add(cardiologicalExamination);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalExamination mCardiologicalExamination = db.CardiologicalExaminations.Find(cardiologicalExamination.CardiologicalExaminationId);

                        mCardiologicalExamination.ResidentId = cardiologicalExamination.ResidentId;
                        mCardiologicalExamination.CardiologicalExaminationDate = cardiologicalExamination.CardiologicalExaminationDate;
                        mCardiologicalExamination.BloodGroupId = cardiologicalExamination.BloodGroupId;
                        mCardiologicalExamination.RhFactorId = cardiologicalExamination.RhFactorId;
                        mCardiologicalExamination.T3 = cardiologicalExamination.T3;
                        mCardiologicalExamination.T4 = cardiologicalExamination.T4;
                        mCardiologicalExamination.TTH = cardiologicalExamination.TTH;
                        mCardiologicalExamination.CRP = cardiologicalExamination.CRP;
                        mCardiologicalExamination.RF = cardiologicalExamination.RF;
                        mCardiologicalExamination.ASLO = cardiologicalExamination.ASLO;
                        mCardiologicalExamination.HIVStatusId = cardiologicalExamination.HIVStatusId;
                        mCardiologicalExamination.HBSStatusId = cardiologicalExamination.HBSStatusId;
                        mCardiologicalExamination.HCVStatusId = cardiologicalExamination.HCVStatusId;
                        mCardiologicalExamination.TPHAStatusId = cardiologicalExamination.TPHAStatusId;
                        mCardiologicalExamination.BRUStatusId = cardiologicalExamination.BRUStatusId;
                        mCardiologicalExamination.Hb = cardiologicalExamination.Hb;
                        mCardiologicalExamination.RBC = cardiologicalExamination.RBC;
                        mCardiologicalExamination.FI = cardiologicalExamination.FI;
                        mCardiologicalExamination.MeanHbRBC = cardiologicalExamination.MeanHbRBC;
                        mCardiologicalExamination.HCT = cardiologicalExamination.HCT;
                        mCardiologicalExamination.Platelete = cardiologicalExamination.Platelete;
                        mCardiologicalExamination.Leukocyte = cardiologicalExamination.Leukocyte;
                        mCardiologicalExamination.Myelocyte = cardiologicalExamination.Myelocyte;
                        mCardiologicalExamination.Metamyelocyte = cardiologicalExamination.Metamyelocyte;
                        mCardiologicalExamination.StabLeukocyte = cardiologicalExamination.StabLeukocyte;
                        mCardiologicalExamination.SegmentedLeukocyte = cardiologicalExamination.SegmentedLeukocyte;
                        mCardiologicalExamination.Eosinophil = cardiologicalExamination.Eosinophil;
                        mCardiologicalExamination.Basophil = cardiologicalExamination.Basophil;
                        mCardiologicalExamination.Lymphocyte = cardiologicalExamination.Lymphocyte;
                        mCardiologicalExamination.Monocyte = cardiologicalExamination.Monocyte;
                        mCardiologicalExamination.ESR = cardiologicalExamination.ESR;
                        mCardiologicalExamination.ProteinTotal = cardiologicalExamination.ProteinTotal;
                        mCardiologicalExamination.albumin = cardiologicalExamination.albumin;
                        mCardiologicalExamination.Urea = cardiologicalExamination.Urea;
                        mCardiologicalExamination.Creatinine = cardiologicalExamination.Creatinine;
                        mCardiologicalExamination.UricAcid = cardiologicalExamination.UricAcid;
                        mCardiologicalExamination.Glucose = cardiologicalExamination.Glucose;
                        mCardiologicalExamination.BilirubinTotal = cardiologicalExamination.BilirubinTotal;
                        mCardiologicalExamination.BilirubinDirect = cardiologicalExamination.BilirubinDirect;
                        mCardiologicalExamination.ALT = cardiologicalExamination.ALT;
                        mCardiologicalExamination.AST = cardiologicalExamination.AST;
                        mCardiologicalExamination.Potassium = cardiologicalExamination.Potassium;
                        mCardiologicalExamination.Sodium = cardiologicalExamination.Sodium;
                        mCardiologicalExamination.Calcium = cardiologicalExamination.Calcium;
                        mCardiologicalExamination.AAmilaza = cardiologicalExamination.AAmilaza;
                        mCardiologicalExamination.CK = cardiologicalExamination.CK;
                        mCardiologicalExamination.CKMB = cardiologicalExamination.CKMB;
                        mCardiologicalExamination.TroponinStatusId = cardiologicalExamination.TroponinStatusId;
                        mCardiologicalExamination.Cholesterol = cardiologicalExamination.Cholesterol;
                        mCardiologicalExamination.Triglyceride = cardiologicalExamination.Triglyceride;
                        mCardiologicalExamination.HDL = cardiologicalExamination.HDL;
                        mCardiologicalExamination.LDL = cardiologicalExamination.LDL;
                        mCardiologicalExamination.PT = cardiologicalExamination.PT;
                        mCardiologicalExamination.INR = cardiologicalExamination.INR;
                        mCardiologicalExamination.PI = cardiologicalExamination.PI;
                        mCardiologicalExamination.APTT = cardiologicalExamination.APTT;
                        mCardiologicalExamination.Fibrinogen = cardiologicalExamination.Fibrinogen;
                        mCardiologicalExamination.UrineProtein = cardiologicalExamination.UrineProtein;
                        mCardiologicalExamination.UrineLeucocyte = cardiologicalExamination.UrineLeucocyte;
                        mCardiologicalExamination.UrineErithrocyte = cardiologicalExamination.UrineErithrocyte;
                        mCardiologicalExamination.UrineDensity = cardiologicalExamination.UrineDensity;
                        mCardiologicalExamination.UrineCylinderStatusId = cardiologicalExamination.UrineCylinderStatusId;
                        mCardiologicalExamination.UrineMicroorganismStatusId = cardiologicalExamination.UrineMicroorganismStatusId;


                        db.Entry(mCardiologicalExamination).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalExamination", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalExamination([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalExamination()
                        {
                            CardiologicalExaminationId = Convert.ToInt32(id),
                        };
                        db.CardiologicalExaminations.Attach(item);
                        db.CardiologicalExaminations.Remove(item);

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

        public ActionResult Details(int? id)
        {
            using (var db = new StoreContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                CardiologicalExaminationItem cardiologicalExaminationItem = db.CardiologicalExaminationItems.Find(id);
                if (cardiologicalExaminationItem == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View("Details", cardiologicalExaminationItem);
                }
            }
        }

        private void OrganizeViewBugs(StoreContext db)
        {
            var lBloodGroups = new List<SelectListItem>();
            lBloodGroups = db.BloodGroups.Select(x => new SelectListItem { Text = x.BloodGroupName, Value = x.BloodGroupId.ToString() }).ToList();
            ViewBag.vbBloodGroups = lBloodGroups;

            var lRhFactors = new List<SelectListItem>();
            lRhFactors = db.RhFactors.Select(x => new SelectListItem { Text = x.RhFactorName, Value = x.RhFactorId.ToString() }).ToList();
            ViewBag.vbRhFactors = lRhFactors;

            var lHIVStatuses = new List<SelectListItem>();
            lHIVStatuses = db.HIVStatuses.Select(x => new SelectListItem { Text = x.HIVStatusName, Value = x.HIVStatusId.ToString() }).ToList();
            ViewBag.vbHIVStatuses = lHIVStatuses;

            var lHBSStatuses = new List<SelectListItem>();
            lHBSStatuses = db.HBSStatuses.Select(x => new SelectListItem { Text = x.HBSStatusName, Value = x.HBSStatusId.ToString() }).ToList();
            ViewBag.vbHBSStatuses = lHBSStatuses;

            var lHCVStatuses = new List<SelectListItem>();
            lHCVStatuses = db.HCVStatuses.Select(x => new SelectListItem { Text = x.HCVStatusName, Value = x.HCVStatusId.ToString() }).ToList();
            ViewBag.vbHCVStatuses = lHCVStatuses;

            var lTPHAStatuses = new List<SelectListItem>();
            lTPHAStatuses = db.TPHAStatuses.Select(x => new SelectListItem { Text = x.TPHAStatusName, Value = x.TPHAStatusId.ToString() }).ToList();
            ViewBag.vbTPHAStatuses = lTPHAStatuses;

            var lBRUStatuses = new List<SelectListItem>();
            lBRUStatuses = db.BRUStatuses.Select(x => new SelectListItem { Text = x.BRUStatusName, Value = x.BRUStatusId.ToString() }).ToList();
            ViewBag.vbBRUStatuses = lBRUStatuses;

            var lTroponinStatuses = new List<SelectListItem>();
            lTroponinStatuses = db.TroponinStatuses.Select(x => new SelectListItem { Text = x.TroponinStatusName, Value = x.TroponinStatusId.ToString() }).ToList();
            ViewBag.vbTroponinStatuses = lTroponinStatuses;

            var lUrineCylinderStatuses = new List<SelectListItem>();
            lUrineCylinderStatuses = db.UrineCylinderStatuses.Select(x => new SelectListItem { Text = x.UrineCylinderStatusName, Value = x.UrineCylinderStatusId.ToString() }).ToList();
            ViewBag.vbUrineCylinderStatuses = lUrineCylinderStatuses;

            var lUrineMicroorganismStatuses = new List<SelectListItem>();
            lUrineMicroorganismStatuses = db.UrineMicroorganismStatuses.Select(x => new SelectListItem { Text = x.UrineMicroorganismStatusName, Value = x.UrineMicroorganismStatusId.ToString() }).ToList();
            ViewBag.vbUrineMicroorganismStatuses = lUrineMicroorganismStatuses;
        }
    }
}