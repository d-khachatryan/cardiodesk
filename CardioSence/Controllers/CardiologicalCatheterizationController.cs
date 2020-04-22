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
using System.IO;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applcardiologicalcatheterisationrole,systemadministratorrole")]
    public class CardiologicalCatheterizationController : Controller
    {
        // GET: CardiologicalCatheterization
        public ActionResult Index()
        {
            ViewBag.activeInv = "active";
            ViewBag.activeCath = "active";
            return View();
        }
        public ActionResult ReadCardiologicalCatheterizationItem([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                //string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                IQueryable<CardiologicalCatheterizationItem> items = db.CardiologicalCatheterizationItems;
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
                    //ViewBag.Folder = Guid.NewGuid().ToString();
                    //ViewBag.FileImage = Guid.NewGuid().ToString();

                    this.OrganizeViewBugs(db);
                    var item = new CardiologicalCatheterizationItem();
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
                    var item = new CardiologicalCatheterizationItem();

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
                    IQueryable<CardiologicalCatheterizationItem> item = db.CardiologicalCatheterizationItems
                        //.Include(m => m.CardiologicalCatheterizationSegments)
                        .Where(p => p.CardiologicalCatheterizationId == id);
                    return View("InputForm", item.First());
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Save(CardiologicalCatheterization cardiologicalCatheterization/*, string folder, string fileImage, string fileMovie*/)
        {
            try
            {
                //string pxPath = "~/FileStorage/Catheterization/";
                //string directoryPath = Server.MapPath(pxPath + folder);

                if (!ModelState.IsValid)
                {
                    return this.Json(new { statuscode = -1, message = General.msgInvalidModel }, JsonRequestBehavior.AllowGet);
                }

                using (var db = new StoreContext())
                {
                    // եթե 2-րդ մակարդակի աղյուսակի տողը նոր գրառումա ավելացնում ենք
                    if (cardiologicalCatheterization.CardiologicalCatheterizationId == 0)
                    {
                        //ավելացնել
                        db.CardiologicalCatheterizations.Add(cardiologicalCatheterization);

                        //հետո ավելացնում ենք ենթաաղյոսակների տողերը ամեն մի ենթաաղյուսակի համար, էս դեպքում 4 աղյուսակի համար
                        if (cardiologicalCatheterization.CardiologicalCatheterizationSegments != null)
                        {
                            foreach (var item in cardiologicalCatheterization.CardiologicalCatheterizationSegments)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalCatheterization = cardiologicalCatheterization;
                                    db.CardiologicalCatheterizationSegments.Add(item);
                                }
                            }
                        }

                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        CardiologicalCatheterization mCardiologicalCatheterization = db.CardiologicalCatheterizations.Find(cardiologicalCatheterization.CardiologicalCatheterizationId);

                        mCardiologicalCatheterization.ResidentId = cardiologicalCatheterization.ResidentId;
                        mCardiologicalCatheterization.CardiologicalCatheterizationDate = cardiologicalCatheterization.CardiologicalCatheterizationDate;
                        mCardiologicalCatheterization.DominanceTypeId = cardiologicalCatheterization.DominanceTypeId;
                        mCardiologicalCatheterization.LM = cardiologicalCatheterization.LM;
                        mCardiologicalCatheterization.LMStenosis = cardiologicalCatheterization.LMStenosis;
                        mCardiologicalCatheterization.LAD1 = cardiologicalCatheterization.LAD1;
                        mCardiologicalCatheterization.LAD1Stenosis = cardiologicalCatheterization.LAD1Stenosis;
                        mCardiologicalCatheterization.LAD2 = cardiologicalCatheterization.LAD2;
                        mCardiologicalCatheterization.LAD2Stenosis = cardiologicalCatheterization.LAD2Stenosis;
                        mCardiologicalCatheterization.LAD3 = cardiologicalCatheterization.LAD3;
                        mCardiologicalCatheterization.LAD3Stenosis = cardiologicalCatheterization.LAD3Stenosis;
                        mCardiologicalCatheterization.Diag1 = cardiologicalCatheterization.Diag1;
                        mCardiologicalCatheterization.Diag1Stenosis = cardiologicalCatheterization.Diag1Stenosis;
                        mCardiologicalCatheterization.Diag2 = cardiologicalCatheterization.Diag2;
                        mCardiologicalCatheterization.Diag2Stenosis = cardiologicalCatheterization.Diag2Stenosis;
                        mCardiologicalCatheterization.Cx1 = cardiologicalCatheterization.Cx1;
                        mCardiologicalCatheterization.Cx1Stenosis = cardiologicalCatheterization.Cx1Stenosis;
                        mCardiologicalCatheterization.Cx2 = cardiologicalCatheterization.Cx2;
                        mCardiologicalCatheterization.Cx2Stenosis = cardiologicalCatheterization.Cx2Stenosis;
                        mCardiologicalCatheterization.Cx3 = cardiologicalCatheterization.Cx3;
                        mCardiologicalCatheterization.Cx3Stenosis = cardiologicalCatheterization.Cx3Stenosis;
                        mCardiologicalCatheterization.Rm = cardiologicalCatheterization.Rm;
                        mCardiologicalCatheterization.RmStenosis = cardiologicalCatheterization.RmStenosis;
                        mCardiologicalCatheterization.OM1 = cardiologicalCatheterization.OM1;
                        mCardiologicalCatheterization.OM1Stenosis = cardiologicalCatheterization.OM1Stenosis;
                        mCardiologicalCatheterization.OM2 = cardiologicalCatheterization.OM2;
                        mCardiologicalCatheterization.OM2Stenosis = cardiologicalCatheterization.OM2Stenosis;
                        mCardiologicalCatheterization.OM3 = cardiologicalCatheterization.OM3;
                        mCardiologicalCatheterization.OM3Stenosis = cardiologicalCatheterization.OM3Stenosis;
                        mCardiologicalCatheterization.OM4 = cardiologicalCatheterization.OM4;
                        mCardiologicalCatheterization.OM4Stenosis = cardiologicalCatheterization.OM4Stenosis;
                        mCardiologicalCatheterization.RCA1 = cardiologicalCatheterization.RCA1;
                        mCardiologicalCatheterization.RCA1Stenosis = cardiologicalCatheterization.RCA1Stenosis;
                        mCardiologicalCatheterization.RCA2 = cardiologicalCatheterization.RCA2;
                        mCardiologicalCatheterization.RCA2Stenosis = cardiologicalCatheterization.RCA2Stenosis;
                        mCardiologicalCatheterization.RCA3 = cardiologicalCatheterization.RCA3;
                        mCardiologicalCatheterization.RCA3Stenosis = cardiologicalCatheterization.RCA3Stenosis;
                        mCardiologicalCatheterization.PDA = cardiologicalCatheterization.PDA;
                        mCardiologicalCatheterization.PDAStenosis = cardiologicalCatheterization.PDAStenosis;
                        mCardiologicalCatheterization.PL1 = cardiologicalCatheterization.PL1;
                        mCardiologicalCatheterization.PL1Stenosis = cardiologicalCatheterization.PL1Stenosis;
                        mCardiologicalCatheterization.LVGraphy = cardiologicalCatheterization.LVGraphy;
                        mCardiologicalCatheterization.LVEDP = cardiologicalCatheterization.LVEDP;
                        mCardiologicalCatheterization.LVEDV = cardiologicalCatheterization.LVEDV;
                        mCardiologicalCatheterization.LVESV = cardiologicalCatheterization.LVESV;
                        mCardiologicalCatheterization.LVEF = cardiologicalCatheterization.LVEF;
                        mCardiologicalCatheterization.PhysicianId = cardiologicalCatheterization.PhysicianId;
                        //mCardiologicalCatheterization.CatheterizationMovieURL = cardiologicalCatheterization.CatheterizationMovieURL;
                        //mCardiologicalCatheterization.CatheterizationImageURL = cardiologicalCatheterization.CatheterizationImageURL;
                        mCardiologicalCatheterization.Comment = cardiologicalCatheterization.Comment;


                        db.Entry(mCardiologicalCatheterization).State = EntityState.Modified;

                        //ենթաաղյուսակների լրացում
                        if (cardiologicalCatheterization.CardiologicalCatheterizationSegments != null)
                        {
                            foreach (var item in cardiologicalCatheterization.CardiologicalCatheterizationSegments)
                            {
                                if (item.RecordStatus == 1)
                                {
                                    item.CardiologicalCatheterization = mCardiologicalCatheterization;
                                    db.CardiologicalCatheterizationSegments.Add(item);
                                }
                                else if (item.RecordStatus == 2)
                                {
                                    db.CardiologicalCatheterizationSegments.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                }
                                else if (item.RecordStatus == 3)
                                {
                                    CardiologicalCatheterizationSegment rCardiologicalCatheterizationSegment = db.CardiologicalCatheterizationSegments.Find(item.CardiologicalCatheterizationSegmentId);
                                    db.CardiologicalCatheterizationSegments.Remove(rCardiologicalCatheterizationSegment);
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
                return View("Error", new HandleErrorInfo(ex, "CardiologicalCatheterization", "Save"));
            }
        }

        public ActionResult DeleteCardiologicalCatheterization([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new CardiologicalCatheterization()
                        {
                            CardiologicalCatheterizationId = Convert.ToInt32(id),
                        };
                        db.CardiologicalCatheterizations.Attach(item);
                        db.CardiologicalCatheterizations.Remove(item);

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

        //public ActionResult UploadImage(IEnumerable<HttpPostedFileBase> images, string name, string path)
        //{
        //    if (images != null)
        //    {
        //        this.SaveTempFile(images, name, path);
        //    }
        //    return Json("1", JsonRequestBehavior.AllowGet);
        //}

        //private void SaveTempFile(IEnumerable<HttpPostedFileBase> files, string name, string path)
        //{
        //    string directoryPath = Server.MapPath("~/FileStorage/Catheterization/" + path);
        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }
        //    foreach (var file in files)
        //    {
        //        string fileName = name + Path.GetExtension(file.FileName);
        //        string filePath = Path.Combine(Server.MapPath("~/FileStorage/Catheterization/" + path), fileName);
        //        if (System.IO.File.Exists(filePath))
        //        {
        //            System.IO.File.Delete(filePath);
        //        }
        //        file.SaveAs(filePath);
        //    }
        //}

        //public ActionResult DeleteImage(string name, string path)
        //{
        //    string[] files = Directory.GetFiles(Server.MapPath("~/FileStorage/Catheterization/" + path), name + ".*");

        //    if (files != null)
        //    {
        //        foreach (var file in files)
        //        {
        //            if (System.IO.File.Exists(file))
        //            {
        //                System.IO.File.Delete(file);
        //            }
        //        }
        //    }
        //    return Json("1", JsonRequestBehavior.AllowGet);
        //}

        private void OrganizeViewBugs(StoreContext db)
        {
            var lDominanceTypes = new List<SelectListItem>();
            lDominanceTypes = db.DominanceTypes.Select(x => new SelectListItem { Text = x.DominanceTypeName, Value = x.DominanceTypeId.ToString() }).ToList();
            ViewBag.vbDominanceTypes = lDominanceTypes;

            var lPhysicians = new List<SelectListItem>();
            lPhysicians = db.Physicians.Select(x => new SelectListItem { Text = x.PhysicianName, Value = x.PhysicianId.ToString() }).ToList();
            ViewBag.vbPhysicians = lPhysicians;

            var lSegments = new List<SelectListItem>();
            lSegments = db.Segments.Select(x => new SelectListItem { Text = x.SegmentName, Value = x.SegmentId.ToString() }).ToList();
            ViewBag.vbSegments = lSegments;

        }
    }
}