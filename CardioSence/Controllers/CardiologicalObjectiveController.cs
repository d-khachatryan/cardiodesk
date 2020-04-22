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
    [Authorize(Roles = "applcardiologicalobjectiverole,systemadministratorrole")]
    public class CardiologicalObjectiveController : Controller
    {
        // GET: CardiologicalObjective
        public ActionResult Index()
        {
            ViewBag.activeRec = "active";
            ViewBag.activeObs = "active";
            return View();
        }
        public ActionResult ReadCardiologicalObjectiveItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalObjectiveItem> items = db.CardiologicalObjectiveItems;
                DataSourceResult result = items.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Create()
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalObjectiveItem();
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
                    var item = new CardiologicalObjectiveItem();

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
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    IQueryable<CardiologicalObjectiveItem> item = db.CardiologicalObjectiveItems
                        //.Include(m => m.CardiologicalObjectiveDrugs)
                        .Where(p => p.CardiologicalObjectiveId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalObjective cardiologicalObjective)
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
                    if (cardiologicalObjective.CardiologicalObjectiveId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalObjectives.Add(cardiologicalObjective);

                        //հետո ավելացնում ենք ենթաաղյոսակների տողերը ամեն մի ենթաաղյուսակի համար, էս դեպքում 4 աղյուսակի համար
                        if (cardiologicalObjective.CardiologicalObjectiveDrugs != null)
                        {
                            foreach (var item in cardiologicalObjective.CardiologicalObjectiveDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalObjective = cardiologicalObjective;
                                    db.CardiologicalObjectiveDrugs.Add(item);
                                }
                            }
                        }

                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalObjective mCardiologicalObjective = db.CardiologicalObjectives.Find(cardiologicalObjective.CardiologicalObjectiveId);

                        mCardiologicalObjective.ResidentId = cardiologicalObjective.ResidentId;
                        mCardiologicalObjective.CardiologicalObjectiveDate = cardiologicalObjective.CardiologicalObjectiveDate;
                        mCardiologicalObjective.Temperature = cardiologicalObjective.Temperature;
                        mCardiologicalObjective.Pulse = cardiologicalObjective.Pulse;
                        mCardiologicalObjective.RNIBP = cardiologicalObjective.RNIBP;
                        mCardiologicalObjective.LNIBP = cardiologicalObjective.LNIBP;
                        mCardiologicalObjective.LungId = cardiologicalObjective.LungId;
                        mCardiologicalObjective.HeartSoundTypeId = cardiologicalObjective.HeartSoundTypeId;
                        mCardiologicalObjective.HeartMurmurTypeId = cardiologicalObjective.HeartMurmurTypeId;
                        mCardiologicalObjective.RCBId = cardiologicalObjective.RCBId;
                        mCardiologicalObjective.LCBId = cardiologicalObjective.LCBId;
                        mCardiologicalObjective.AbdominalStatusId = cardiologicalObjective.AbdominalStatusId;
                        mCardiologicalObjective.LiverId = cardiologicalObjective.LiverId;
                        mCardiologicalObjective.RRAId = cardiologicalObjective.RRAId;
                        mCardiologicalObjective.LRAId = cardiologicalObjective.LRAId;
                        mCardiologicalObjective.RADPId = cardiologicalObjective.RADPId;
                        mCardiologicalObjective.LADPId = cardiologicalObjective.LADPId;
                        mCardiologicalObjective.PeripherialStatusId = cardiologicalObjective.PeripherialStatusId;
                        mCardiologicalObjective.PhysicianId = cardiologicalObjective.PhysicianId;

                        db.Entry(mCardiologicalObjective).State = EntityState.Modified;

                        //ենթաաղյուսակների լրացում
                        if (cardiologicalObjective.CardiologicalObjectiveDrugs != null)
                        {
                            foreach (var item in cardiologicalObjective.CardiologicalObjectiveDrugs)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalObjective = mCardiologicalObjective;
                                    db.CardiologicalObjectiveDrugs.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalObjectiveDrugs.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalObjectiveDrug rCardiologicalObjectiveDrug = db.CardiologicalObjectiveDrugs.Find(item.CardiologicalObjectiveDrugId);
                                    db.CardiologicalObjectiveDrugs.Remove(rCardiologicalObjectiveDrug);
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
                return View("Error", new HandleErrorInfo(ex, "CardiologicalObjective", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalObjective([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalObjective()
                        {
                            CardiologicalObjectiveId = Convert.ToInt32(id),
                        };
                        db.CardiologicalObjectives.Attach(item);
                        db.CardiologicalObjectives.Remove(item);

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
            var lLungs = new List<SelectListItem>();
            lLungs = db.Lungs.Select(x => new SelectListItem { Text = x.LungName, Value = x.LungId.ToString() }).ToList();
            ViewBag.vbLungs = lLungs;

            var lHeartSoundTypes = new List<SelectListItem>();
            lHeartSoundTypes = db.HeartSoundTypes.Select(x => new SelectListItem { Text = x.HeartSoundTypeName, Value = x.HeartSoundTypeId.ToString() }).ToList();
            ViewBag.vbHeartSoundTypes = lHeartSoundTypes;

            var lHeartMurmurTypes = new List<SelectListItem>();
            lHeartMurmurTypes = db.HeartMurmurTypes.Select(x => new SelectListItem { Text = x.HeartMurmurTypeName, Value = x.HeartMurmurTypeId.ToString() }).ToList();
            ViewBag.vbHeartMurmurTypes = lHeartMurmurTypes;

            var lCaroticBruits = new List<SelectListItem>();
            lCaroticBruits = db.CaroticBruits.Select(x => new SelectListItem { Text = x.CaroticBruitName, Value = x.CaroticBruitId.ToString() }).ToList();
            ViewBag.vbCaroticBruits = lCaroticBruits;

            var lAbdominalStatuses = new List<SelectListItem>();
            lAbdominalStatuses = db.AbdominalStatuses.Select(x => new SelectListItem { Text = x.AbdominalStatusName, Value = x.AbdominalStatusId.ToString() }).ToList();
            ViewBag.vbAbdominalStatuses = lAbdominalStatuses;

            var lLivers = new List<SelectListItem>();
            lLivers = db.Livers.Select(x => new SelectListItem { Text = x.LiverName, Value = x.LiverId.ToString() }).ToList();
            ViewBag.vbLivers = lLivers;

            var lArteriaStatuses = new List<SelectListItem>();
            lArteriaStatuses = db.ArteriaStatuses.Select(x => new SelectListItem { Text = x.ArteriaStatusName, Value = x.ArteriaStatusId.ToString() }).ToList();
            ViewBag.vbArteriaStatuses = lArteriaStatuses;

            var lPeripherialStatuses = new List<SelectListItem>();
            lPeripherialStatuses = db.PeripherialStatuses.Select(x => new SelectListItem { Text = x.PeripherialStatusName, Value = x.PeripherialStatusId.ToString() }).ToList();
            ViewBag.vbPeripherialStatuses = lPeripherialStatuses;

            var lPhysicianss = new List<SelectListItem>();
            lPhysicianss = db.Physicians.Select(x => new SelectListItem { Text = x.PhysicianName, Value = x.PhysicianId.ToString() }).ToList();
            ViewBag.vbPhysicians = lPhysicianss;

            var lDrugs = new List<SelectListItem>();
            lDrugs = db.Drugs.Select(x => new SelectListItem { Text = x.DrugName, Value = x.DrugId.ToString() }).ToList();
            ViewBag.vbDrugs = lDrugs;

            var lDrugFrequencies = new List<SelectListItem>();
            lDrugFrequencies = db.DrugFrequencies.Select(x => new SelectListItem { Text = x.DrugFrequencyName, Value = x.DrugFrequencyId.ToString() }).ToList();
            ViewBag.vbDrugFrequencies = lDrugFrequencies;
        }
    }
}