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
    [Authorize(Roles = "applcardiologicalpcirole,systemadministratorrole")]
    public class CardiologicalPCIController : Controller
    {
        // GET: CardiologicalPCI
        public ActionResult Index()
        {
            ViewBag.activeInv = "active";
            ViewBag.activePCI = "active";
            return View();
        }
        public ActionResult ReadCardiologicalPCIItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalPCIItem> items = db.CardiologicalPCIItems;
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
                    var item = new CardiologicalPCIItem();
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
                    var item = new CardiologicalPCIItem();

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
                    IQueryable<CardiologicalPCIItem> item = db.CardiologicalPCIItems
                        //.Include(m => m.CardiologicalPCISegments)
                        .Where(p => p.CardiologicalPCIId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalPCI cardiologicalPCI)
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
                    if (cardiologicalPCI.CardiologicalPCIId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalPCIS.Add(cardiologicalPCI);

                        //հետո ավելացնում ենք ենթաաղյոսակների տողերը ամեն մի ենթաաղյուսակի համար, էս դեպքում 4 աղյուսակի համար
                        if (cardiologicalPCI.CardiologicalPCISegments != null)
                        {
                            foreach (var item in cardiologicalPCI.CardiologicalPCISegments)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalPCI = cardiologicalPCI;
                                    db.CardiologicalPCISegments.Add(item);
                                }
                            }
                        }

                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalPCI mCardiologicalPCI = db.CardiologicalPCIS.Find(cardiologicalPCI.CardiologicalPCIId);

                        mCardiologicalPCI.ResidentId = cardiologicalPCI.ResidentId;
                        mCardiologicalPCI.CardiologicalPCIDate = cardiologicalPCI.CardiologicalPCIDate;
                        mCardiologicalPCI.PhysicianId = cardiologicalPCI.PhysicianId;
                        mCardiologicalPCI.Comment = cardiologicalPCI.Comment;
                        //mCardiologicalPCI.PCIMovieURL = cardiologicalPCI.PCIMovieURL;
                        //mCardiologicalPCI.PCIImageURL = cardiologicalPCI.PCIImageURL;


                        db.Entry(mCardiologicalPCI).State = EntityState.Modified;

                        //ենթաաղյուսակների լրացում
                        if (cardiologicalPCI.CardiologicalPCISegments != null)
                        {
                            foreach (var item in cardiologicalPCI.CardiologicalPCISegments)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalPCI = mCardiologicalPCI;
                                    db.CardiologicalPCISegments.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalPCISegments.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalPCISegment rCardiologicalPCISegment = db.CardiologicalPCISegments.Find(item.CardiologicalPCISegmentId);
                                    db.CardiologicalPCISegments.Remove(rCardiologicalPCISegment);
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
                return View("Error", new HandleErrorInfo(ex, "CardiologicalPCI", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalPCI([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalPCI()
                        {
                            CardiologicalPCIId = Convert.ToInt32(id),
                        };
                        db.CardiologicalPCIS.Attach(item);
                        db.CardiologicalPCIS.Remove(item);

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
            var lPhysicians = new List<SelectListItem>();
            lPhysicians = db.Physicians.Select(x => new SelectListItem { Text = x.PhysicianName, Value = x.PhysicianId.ToString() }).ToList();
            ViewBag.vbPhysicians = lPhysicians;

            var lStents = new List<SelectListItem>();
            lStents = db.Stents.Select(x => new SelectListItem { Text = x.StentName, Value = x.StentId.ToString() }).ToList();
            ViewBag.vbStents = lStents;

            var lSegments = new List<SelectListItem>();
            lSegments = db.Segments.Select(x => new SelectListItem { Text = x.SegmentName, Value = x.SegmentId.ToString() }).ToList();
            ViewBag.vbSegments = lSegments;

            var lLesionTypes = new List<SelectListItem>();
            lLesionTypes = db.LesionTypes.Select(x => new SelectListItem { Text = x.LesionTypeName, Value = x.LesionTypeId.ToString() }).ToList();
            ViewBag.vbLesionTypes = lLesionTypes;

            var lTIMIS = new List<SelectListItem>();
            lTIMIS = db.TIMIS.Select(x => new SelectListItem { Text = x.TIMIName, Value = x.TIMIId.ToString() }).ToList();
            ViewBag.vbTIMIS = lTIMIS;

            var lStentTypes = new List<SelectListItem>();
            lStentTypes = db.StentTypes.Select(x => new SelectListItem { Text = x.StentTypeName, Value = x.StentTypeId.ToString() }).ToList();
            ViewBag.vbStentTypes = lStentTypes;

            var lDrugElutionTypes = new List<SelectListItem>();
            lDrugElutionTypes = db.DrugElutionTypes.Select(x => new SelectListItem { Text = x.DrugElutionTypeName, Value = x.DrugElutionTypeId.ToString() }).ToList();
            ViewBag.vbDrugElutionTypes = lDrugElutionTypes;

        }
    }
}