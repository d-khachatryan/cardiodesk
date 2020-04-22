using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardioSence.Resources;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalecgrole,systemadministratorrole")]
    public class CardiologicalECGController : Controller
    {
        // GET: CardiologicalECG
        public ActionResult Index()
        {
            ViewBag.activeExm = "active";
            ViewBag.activeElcCrd = "active";
            return View();
        }

        public ActionResult ReadCardiologicalECGItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalECGItem> items = db.CardiologicalECGItems;
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
                    var item = new CardiologicalECGItem();
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
                    var item = new CardiologicalECGItem();

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
                    IQueryable<CardiologicalECGItem> item = db.CardiologicalECGItems
                        .Where(p => p.CardiologicalECGId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalECG cardiologicalECG)
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
                    if (cardiologicalECG.CardiologicalECGId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalECGS.Add(cardiologicalECG);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalECG mCardiologicalECG = db.CardiologicalECGS.Find(cardiologicalECG.CardiologicalECGId);

                        //mCardiologicalDuplexScan.CardiologicalDuplexScanId = cardiologicalDuplexScan.CardiologicalDuplexScanId;
                        mCardiologicalECG.ResidentId = cardiologicalECG.ResidentId;
                        mCardiologicalECG.CardiologicalECGDate = cardiologicalECG.CardiologicalECGDate;
                        mCardiologicalECG.HR = cardiologicalECG.HR;
                        mCardiologicalECG.RhythmTypeID = cardiologicalECG.RhythmTypeID;
                        mCardiologicalECG.AxisDegree = cardiologicalECG.AxisDegree;
                        mCardiologicalECG.PQ = cardiologicalECG.PQ;
                        mCardiologicalECG.QT = cardiologicalECG.QT;
                        mCardiologicalECG.LVHId = cardiologicalECG.LVHId;
                        mCardiologicalECG.RVHId = cardiologicalECG.RVHId;
                        mCardiologicalECG.ZoneIshemiaId = cardiologicalECG.ZoneIshemiaId;
                        mCardiologicalECG.ZoneInfarctionId = cardiologicalECG.ZoneInfarctionId;
                        mCardiologicalECG.LaunId = cardiologicalECG.LaunId;
                        mCardiologicalECG.PAC = cardiologicalECG.PAC;
                        mCardiologicalECG.ConductionDisturbanceId = cardiologicalECG.ConductionDisturbanceId;
                        mCardiologicalECG.BBBId = cardiologicalECG.BBBId;
                        mCardiologicalECG.Comment = cardiologicalECG.Comment;


                        db.Entry(mCardiologicalECG).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalECG", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalECG([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalECG()
                        {
                            CardiologicalECGId = Convert.ToInt32(id),
                        };
                        db.CardiologicalECGS.Attach(item);
                        db.CardiologicalECGS.Remove(item);

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
            var lRhythmTypes = new List<SelectListItem>();
            lRhythmTypes = db.RhythmTypes.Select(x => new SelectListItem { Text = x.RhythmTypeName, Value = x.RhythmTypeId.ToString() }).ToList();
            ViewBag.vbRhythmTypes = lRhythmTypes;

            var lVHS = new List<SelectListItem>();
            lVHS = db.VHS.Select(x => new SelectListItem { Text = x.VHName, Value = x.VHId.ToString() }).ToList();
            ViewBag.vbVHS = lVHS;

            var lECGZones = new List<SelectListItem>();
            lECGZones = db.ECGZones.Select(x => new SelectListItem { Text = x.ECGZoneName, Value = x.ECGZoneId.ToString() }).ToList();
            ViewBag.vbECGZones = lECGZones;

            var lLauns = new List<SelectListItem>();
            lLauns = db.Launs.Select(x => new SelectListItem { Text = x.LaunName, Value = x.LaunId.ToString() }).ToList();
            ViewBag.vbLauns = lLauns;

            var lConductionDisturbances = new List<SelectListItem>();
            lConductionDisturbances = db.ConductionDisturbances.Select(x => new SelectListItem { Text = x.ConductionDisturbanceName, Value = x.ConductionDisturbanceId.ToString() }).ToList();
            ViewBag.vbConductionDisturbances = lConductionDisturbances;

            var lBBBS = new List<SelectListItem>();
            lBBBS = db.BBBS.Select(x => new SelectListItem { Text = x.BBBName, Value = x.BBBId.ToString() }).ToList();
            ViewBag.vbBBBS = lBBBS;

        }
    }
}