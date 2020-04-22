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

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalduplexscanrole,systemadministratorrole")]
    public class CardiologicalDuplexScanController : Controller
    {
        // GET: CardiologicalDuplexScan
        public ActionResult Index()
        {
            ViewBag.activeExm = "active";
            ViewBag.activeDup = "active";
            return View();
        }

        public ActionResult ReadCardiologicalDuplexScanItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalDuplexScanItem> items = db.CardiologicalDuplexScanItems;
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
                    var item = new CardiologicalDuplexScanItem();
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
                    var item = new CardiologicalDuplexScanItem();

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
                    IQueryable<CardiologicalDuplexScanItem> item = db.CardiologicalDuplexScanItems
                        .Where(p => p.CardiologicalDuplexScanId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalDuplexScan cardiologicalDuplexScan)
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
                    if (cardiologicalDuplexScan.CardiologicalDuplexScanId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalDuplexScans.Add(cardiologicalDuplexScan);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalDuplexScan mCardiologicalDuplexScan = db.CardiologicalDuplexScans.Find(cardiologicalDuplexScan.CardiologicalDuplexScanId);

                        //mCardiologicalDuplexScan.CardiologicalDuplexScanId = cardiologicalDuplexScan.CardiologicalDuplexScanId;
                        mCardiologicalDuplexScan.ResidentId = cardiologicalDuplexScan.ResidentId;
                        mCardiologicalDuplexScan.CardiologicalDuplexScanDate = cardiologicalDuplexScan.CardiologicalDuplexScanDate;
                        mCardiologicalDuplexScan.RCAStenosisId = cardiologicalDuplexScan.RCAStenosisId;
                        mCardiologicalDuplexScan.RCAStenosisDM = cardiologicalDuplexScan.RCAStenosisDM;
                        mCardiologicalDuplexScan.RCAStenosisPC = cardiologicalDuplexScan.RCAStenosisPC;
                        mCardiologicalDuplexScan.LSAStenosisId = cardiologicalDuplexScan.LSAStenosisId;
                        mCardiologicalDuplexScan.LSAStenosisDM = cardiologicalDuplexScan.LSAStenosisDM;
                        mCardiologicalDuplexScan.LSAStenosisPC = cardiologicalDuplexScan.LSAStenosisPC;
                        mCardiologicalDuplexScan.RCCStenosisId = cardiologicalDuplexScan.RCCStenosisId;
                        mCardiologicalDuplexScan.RCCStenosisDM = cardiologicalDuplexScan.RCCStenosisDM;
                        mCardiologicalDuplexScan.RCCStenosisPC = cardiologicalDuplexScan.RCCStenosisPC;
                        mCardiologicalDuplexScan.LCCStenosisId = cardiologicalDuplexScan.LCCStenosisId;
                        mCardiologicalDuplexScan.LCCStenosisDM = cardiologicalDuplexScan.LCCStenosisDM;
                        mCardiologicalDuplexScan.LCCStenosisPC = cardiologicalDuplexScan.LCCStenosisPC;
                        mCardiologicalDuplexScan.RCIStenosisId = cardiologicalDuplexScan.RCIStenosisId;
                        mCardiologicalDuplexScan.RCIStenosisDM = cardiologicalDuplexScan.RCIStenosisDM;
                        mCardiologicalDuplexScan.RCIStenosisPC = cardiologicalDuplexScan.RCIStenosisPC;
                        mCardiologicalDuplexScan.LCIStenosisId = cardiologicalDuplexScan.LCIStenosisId;
                        mCardiologicalDuplexScan.LCIStenosisDM = cardiologicalDuplexScan.LCIStenosisDM;
                        mCardiologicalDuplexScan.LCIStenosisPC = cardiologicalDuplexScan.LCIStenosisPC;
                        mCardiologicalDuplexScan.RCEStenosisId = cardiologicalDuplexScan.RCEStenosisId;
                        mCardiologicalDuplexScan.RCEStenosisDM = cardiologicalDuplexScan.RCEStenosisDM;
                        mCardiologicalDuplexScan.RCEStenosisPC = cardiologicalDuplexScan.RCEStenosisPC;
                        mCardiologicalDuplexScan.LCEStenosisId = cardiologicalDuplexScan.LCEStenosisId;
                        mCardiologicalDuplexScan.LCEStenosisDM = cardiologicalDuplexScan.LCEStenosisDM;
                        mCardiologicalDuplexScan.LCEStenosisPC = cardiologicalDuplexScan.LCEStenosisPC;
                        mCardiologicalDuplexScan.RVAStenosisId = cardiologicalDuplexScan.RVAStenosisId;
                        mCardiologicalDuplexScan.RVAStenosisDM = cardiologicalDuplexScan.RVAStenosisDM;
                        mCardiologicalDuplexScan.RVAStenosisPC = cardiologicalDuplexScan.RVAStenosisPC;
                        mCardiologicalDuplexScan.LVAStenosisId = cardiologicalDuplexScan.LVAStenosisId;
                        mCardiologicalDuplexScan.LVAStenosisDM = cardiologicalDuplexScan.LVAStenosisDM;
                        mCardiologicalDuplexScan.LVAStenosisPC = cardiologicalDuplexScan.LVAStenosisPC;

                        db.Entry(mCardiologicalDuplexScan).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalDuplexScan", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalDuplexScan([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalDuplexScan()
                        {
                            CardiologicalDuplexScanId = Convert.ToInt32(id),
                        };
                        db.CardiologicalDuplexScans.Attach(item);
                        db.CardiologicalDuplexScans.Remove(item);

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

            var lStenosises = new List<SelectListItem>();
            lStenosises = db.DuplexStenoses.Select(x => new SelectListItem { Text = x.DuplexStenosisName, Value = x.DuplexStenosisId.ToString() }).ToList();
            ViewBag.vbStenosises = lStenosises;
        }
    }
}