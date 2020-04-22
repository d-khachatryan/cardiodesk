using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CardioSence.Resources;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalcpbrole,systemadministratorrole")]
    public class CardiologicalCPBController : Controller
    {
        // GET: CardiologicalCPB
        public ActionResult Index()
        {
            ViewBag.activeInv = "active";
            ViewBag.activeCPB = "active";
            return View();
        }

        public ActionResult ReadCardiologicalCPBItem([DataSourceRequest]DataSourceRequest request)
        {

            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCPBItem> items = db.CardiologicalCPBItems;
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
                    var item = new CardiologicalCPBItem();
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
                    var item = new CardiologicalCPBItem();

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
                    IQueryable<CardiologicalCPBItem> item = db.CardiologicalCPBItems
                        .Where(p => p.CardiologicalCPBId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalCPB cardiologicalCPB)
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
                    if (cardiologicalCPB.CardiologicalCPBId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalCPBS.Add(cardiologicalCPB);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalCPB mCardiologicalCPB = db.CardiologicalCPBS.Find(cardiologicalCPB.CardiologicalCPBId);
                        mCardiologicalCPB.ResidentId = cardiologicalCPB.ResidentId;
                        mCardiologicalCPB.CPBDate = cardiologicalCPB.CPBDate;
                        mCardiologicalCPB.CPBTime = cardiologicalCPB.CPBTime;
                        mCardiologicalCPB.SampleTypeId = cardiologicalCPB.SampleTypeId;
                        mCardiologicalCPB.MAP = cardiologicalCPB.MAP;
                        mCardiologicalCPB.RectalTemperature = cardiologicalCPB.RectalTemperature;
                        mCardiologicalCPB.ACT = cardiologicalCPB.ACT;
                        mCardiologicalCPB.FiO2 = cardiologicalCPB.FiO2;
                        mCardiologicalCPB.pH = cardiologicalCPB.pH;
                        mCardiologicalCPB.pO2 = cardiologicalCPB.pO2;
                        mCardiologicalCPB.pCO2 = cardiologicalCPB.pCO2;
                        mCardiologicalCPB.SO2 = cardiologicalCPB.SO2;
                        mCardiologicalCPB.Ht = cardiologicalCPB.Ht;
                        mCardiologicalCPB.Hb = cardiologicalCPB.Hb;
                        mCardiologicalCPB.Na = cardiologicalCPB.Na;
                        mCardiologicalCPB.K = cardiologicalCPB.K;
                        mCardiologicalCPB.Cl = cardiologicalCPB.Cl;
                        mCardiologicalCPB.Ca = cardiologicalCPB.Ca;
                        mCardiologicalCPB.Mg = cardiologicalCPB.Mg;
                        mCardiologicalCPB.BebTypeId = cardiologicalCPB.BebTypeId;
                        mCardiologicalCPB.BEB = cardiologicalCPB.BEB;
                        mCardiologicalCPB.HCO3 = cardiologicalCPB.HCO3;
                        mCardiologicalCPB.BUN = cardiologicalCPB.BUN;
                        mCardiologicalCPB.Lactosa = cardiologicalCPB.Lactosa;
                        mCardiologicalCPB.Glucosa = cardiologicalCPB.Glucosa;
                        mCardiologicalCPB.IonGap = cardiologicalCPB.IonGap;


                        db.Entry(mCardiologicalCPB).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalCPB", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalCPB([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalCPB()
                        {
                            CardiologicalCPBId = Convert.ToInt32(id),
                        };
                        db.CardiologicalCPBS.Attach(item);
                        db.CardiologicalCPBS.Remove(item);

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
            var lSampleTypes = new List<SelectListItem>();
            lSampleTypes = db.SampleTypes.Select(x => new SelectListItem { Text = x.SampleTypeName, Value = x.SampleTypeId.ToString() }).ToList();
            ViewBag.vbSampleTypes = lSampleTypes;

            var lBebTypes = new List<SelectListItem>();
            lBebTypes = db.BebTypes.Select(x => new SelectListItem { Text = x.BebTypeName, Value = x.BebTypeId.ToString() }).ToList();
            ViewBag.vbBebTypes = lBebTypes;

        }
    }
}