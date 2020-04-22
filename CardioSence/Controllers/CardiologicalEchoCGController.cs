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
    [Authorize(Roles = "applcardiologicalechocgrole,systemadministratorrole")]
    public class CardiologicalEchoCGController : Controller
    {
        // GET: CardiologicalEchoCG
        public ActionResult Index()
        {
            ViewBag.activeExm = "active";
            ViewBag.activeEchoCrd = "active";
            return View();
        }
        public ActionResult ReadCardiologicalEchoCGItem([DataSourceRequest]DataSourceRequest request)
        {
                using (var db = new StoreContext())
                {
                    IQueryable<CardiologicalEchoCGItem> items = db.CardiologicalEchoCGItems;
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
                    var item = new CardiologicalEchoCGItem();
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
                    var item = new CardiologicalEchoCGItem();

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
                    IQueryable<CardiologicalEchoCGItem> item = db.CardiologicalEchoCGItems
                     //   .Include(m => m.CardiologicalEchoCGVelocitys)
                     //   .Include(m => m.CardiologicalEchoCGWalls)
                        .Where(p => p.CardiologicalEchoCGId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalEchoCG cardiologicalEchoCG)
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
                    if (cardiologicalEchoCG.CardiologicalEchoCGId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalEchoCGS.Add(cardiologicalEchoCG);

                        //հետո ավելացնում ենք ենթաաղյոսակների տողերը ամեն մի ենթաաղյուսակի համար, էս դեպքում 4 աղյուսակի համար
                        if (cardiologicalEchoCG.CardiologicalEchoCGVelocitys != null)
                        {
                            foreach (var item in cardiologicalEchoCG.CardiologicalEchoCGVelocitys)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalEchoCG = cardiologicalEchoCG;
                                    db.CardiologicalEchoCGVelocitys.Add(item);
                                }
                            }
                        }

                        if (cardiologicalEchoCG.CardiologicalEchoCGWalls != null)
                        {
                            foreach (var item in cardiologicalEchoCG.CardiologicalEchoCGWalls)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalEchoCG = cardiologicalEchoCG;
                                    db.CardiologicalEchoCGWalls.Add(item);
                                }
                            }
                        }

                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalEchoCG mCardiologicalEchoCG = db.CardiologicalEchoCGS.Find(cardiologicalEchoCG.CardiologicalEchoCGId);

                        mCardiologicalEchoCG.CardiologicalEchoCGDate = cardiologicalEchoCG.CardiologicalEchoCGDate;
                        mCardiologicalEchoCG.ResidentId = cardiologicalEchoCG.ResidentId;
                        mCardiologicalEchoCG.AOD = cardiologicalEchoCG.AOD;
                        mCardiologicalEchoCG.LAD = cardiologicalEchoCG.LAD;
                        mCardiologicalEchoCG.RVDD = cardiologicalEchoCG.RVDD;
                        mCardiologicalEchoCG.LVSD = cardiologicalEchoCG.LVSD;
                        mCardiologicalEchoCG.LVDD = cardiologicalEchoCG.LVDD;
                        mCardiologicalEchoCG.LVPW = cardiologicalEchoCG.LVPW;
                        mCardiologicalEchoCG.LVSV = cardiologicalEchoCG.LVSV;
                        mCardiologicalEchoCG.LVDV = cardiologicalEchoCG.LVDV;
                        mCardiologicalEchoCG.IVSW = cardiologicalEchoCG.IVSW;
                        mCardiologicalEchoCG.SV = cardiologicalEchoCG.SV;
                        mCardiologicalEchoCG.EF = cardiologicalEchoCG.EF;
                        mCardiologicalEchoCG.PAACTET = cardiologicalEchoCG.PAACTET;
                        mCardiologicalEchoCG.MenaPAP = cardiologicalEchoCG.MenaPAP;
                        mCardiologicalEchoCG.PeakPAP = cardiologicalEchoCG.PeakPAP;
                        mCardiologicalEchoCG.PericardialAnteriorSeparation = cardiologicalEchoCG.PericardialAnteriorSeparation;
                        mCardiologicalEchoCG.Comment = cardiologicalEchoCG.Comment;
                        //mCardiologicalEchoCG.CardiologicalEchoCGMoviePath = cardiologicalEchoCG.CardiologicalEchoCGMoviePath;


                        db.Entry(mCardiologicalEchoCG).State = EntityState.Modified;

                        //ենթաաղյուսակների լրացում
                        if (cardiologicalEchoCG.CardiologicalEchoCGVelocitys != null)
                        {
                            foreach (var item in cardiologicalEchoCG.CardiologicalEchoCGVelocitys)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalEchoCG = mCardiologicalEchoCG;
                                    db.CardiologicalEchoCGVelocitys.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalEchoCGVelocitys.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalEchoCGVelocity rCardiologicalEchoCGVelocity = db.CardiologicalEchoCGVelocitys.Find(item.CardiologicalEchoCGVelocityId);
                                    db.CardiologicalEchoCGVelocitys.Remove(rCardiologicalEchoCGVelocity);
                                }
                            }
                        }

                        if (cardiologicalEchoCG.CardiologicalEchoCGWalls != null)
                        {
                            foreach (var item in cardiologicalEchoCG.CardiologicalEchoCGWalls)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalEchoCG = mCardiologicalEchoCG;
                                    db.CardiologicalEchoCGWalls.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalEchoCGWalls.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalEchoCGWall rCardiologicalEchoCGWall = db.CardiologicalEchoCGWalls.Find(item.CardiologicalEchoCGWallId);
                                    db.CardiologicalEchoCGWalls.Remove(rCardiologicalEchoCGWall);
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
                return View("Error", new HandleErrorInfo(ex, "CardiologicalEchoCG", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalEchoCG([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalEchoCG()
                        {
                            CardiologicalEchoCGId = Convert.ToInt32(id),
                        };
                        db.CardiologicalEchoCGS.Attach(item);
                        db.CardiologicalEchoCGS.Remove(item);

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
            var lValves = new List<SelectListItem>();
            lValves = db.Valves.Select(x => new SelectListItem { Text = x.ValveName, Value = x.ValveId.ToString() }).ToList();
            ViewBag.vbValves = lValves;

            var lStenosises = new List<SelectListItem>();
            lStenosises = db.Stenosises.Select(x => new SelectListItem { Text = x.StenosisName, Value = x.StenosisId.ToString() }).ToList();
            ViewBag.vbStenosises = lStenosises;

            var lInsufficiencyes = new List<SelectListItem>();
            lInsufficiencyes = db.Insufficiencyes.Select(x => new SelectListItem { Text = x.InsufficiencyName, Value = x.InsufficiencyId.ToString() }).ToList();
            ViewBag.vbInsufficiencyes = lInsufficiencyes;

            var lEchoCGZones = new List<SelectListItem>();
            lEchoCGZones = db.EchoCGZones.Select(x => new SelectListItem { Text = x.EchoCGZoneName, Value = x.EchoCGZoneId.ToString() }).ToList();
            ViewBag.vbEchoCGZones = lEchoCGZones;

            var lContractilityes = new List<SelectListItem>();
            lContractilityes = db.Contractilityes.Select(x => new SelectListItem { Text = x.ContractilityName, Value = x.ContractilityId.ToString() }).ToList();
            ViewBag.vbContractilityes = lContractilityes;
        }
    }
}