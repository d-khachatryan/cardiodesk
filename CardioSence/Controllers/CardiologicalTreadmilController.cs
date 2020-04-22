using CardioSence.DAL;
using CardioSence.Models;
using CardioSence.Resources;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "apptreadmilrole,systemadministratorrole")]
    public class CardiologicalTreadmilController : Controller
    {
        // GET: CardiologicalTreadmil
        public ActionResult Index()
        {
            ViewBag.activeExm = "active";
            ViewBag.activeTrd = "active";
            return View();
        }
        public ActionResult ReadCardiologicalTreadmilItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalTreadmilItem> items = db.CardiologicalTreadmilItems;
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
                    var item = new CardiologicalTreadmilItem();
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
                    var item = new CardiologicalTreadmilItem();

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
                    IQueryable<CardiologicalTreadmilItem> item = db.CardiologicalTreadmilItems
                        .Where(p => p.CardiologicalTreadmilId == id);

                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalTreadmil cardiologicalTreadmil)
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
                    if (cardiologicalTreadmil.CardiologicalTreadmilId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalTreadmils.Add(cardiologicalTreadmil);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalTreadmil mCardiologicalTreadmil = db.CardiologicalTreadmils.Find(cardiologicalTreadmil.CardiologicalTreadmilId);

                        mCardiologicalTreadmil.ResidentId = cardiologicalTreadmil.ResidentId;
                        mCardiologicalTreadmil.CardiologicalTreadmilDate = cardiologicalTreadmil.CardiologicalTreadmilDate;
                        mCardiologicalTreadmil.TreadmilProtocolId = cardiologicalTreadmil.TreadmilProtocolId;
                        mCardiologicalTreadmil.METSAchieved = cardiologicalTreadmil.METSAchieved;
                        mCardiologicalTreadmil.TreadmilResultid = cardiologicalTreadmil.TreadmilResultid;
                        mCardiologicalTreadmil.Comment = cardiologicalTreadmil.Comment;

                        db.Entry(mCardiologicalTreadmil).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalTreadmil", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalTreadmil([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalTreadmil()
                        {
                            CardiologicalTreadmilId = Convert.ToInt32(id),
                        };
                        db.CardiologicalTreadmils.Attach(item);
                        db.CardiologicalTreadmils.Remove(item);

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
            var lTreadmilProtocols = new List<SelectListItem>();
            lTreadmilProtocols = db.TreadmilProtocols.Select(x => new SelectListItem { Text = x.TreadmilProtocolName, Value = x.TreadmilProtocolId.ToString() }).ToList();
            ViewBag.vbTreadmilProtocols = lTreadmilProtocols;

            var lTreadmilResults = new List<SelectListItem>();
            lTreadmilResults = db.TreadmilResults.Select(x => new SelectListItem { Text = x.TreadmilResultName, Value = x.TreadmilResultId.ToString() }).ToList();
            ViewBag.vbTreadmilResults = lTreadmilResults;


        }
    }
}