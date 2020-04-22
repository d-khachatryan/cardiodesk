using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using CardioSence.Resources;
using System.Web.UI;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "applresidentrole,systemadministratorrole")]
    public class ResidentController : Controller
    {
        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        
        public ActionResult Index()
        {
            ViewBag.activeRec = "active";
            ViewBag.activePat = "active";

            return View();
        }

        public ActionResult ResidentReport()
        {
            ViewBag.activeRec = "active";
            ViewBag.activePat = "active";

            return View();
        }

        public JsonResult ResidentInfo(string text)
        {
            using (var db = new StoreContext())
            {
                List<ResidentInfo> q = db.ResidentInfos.Where(p => p.ResidentName.Contains(text)).ToList();
                return Json(q, JsonRequestBehavior.AllowGet);
            }

        }

        [OutputCache(Duration = 3600, VaryByParam = "id", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult PatientInfo([DataSourceRequest]DataSourceRequest request, string id)
        {
            using (var db = new StoreContext())
            {
                int patientId = 0;
                List<ResidentItem> query;
                bool result = Int32.TryParse(id, out patientId);
                if (result)
                {
                    query = (from c in db.ResidentItems where c.PatientId == patientId select c).ToList();
                    if (query.Count() == 0)
                    {
                        var q = new ResidentItem();
                        q.PatientId = null;
                        query.Add(q);
                    }
                }
                else
                {
                    query = new List<ResidentItem>();
                    var q = new ResidentItem();
                    q.PatientId = null;
                    query.Add(q);
                }


                DataSourceResult rResult = query.ToDataSourceResult(request);
                return Json(rResult, JsonRequestBehavior.AllowGet);
            }
        }

        private void OrganizeViewBugs(StoreContext db)
        {
            var lGenders = new List<SelectListItem>();
            lGenders = db.Genders.Select(x => new SelectListItem { Text = x.GenderName, Value = x.GenderId.ToString() }).ToList();
            ViewBag.vbGenders = lGenders;

            var lProfessions = new List<SelectListItem>();
            lProfessions = db.Professions.Select(x => new SelectListItem { Text = x.ProfessionName, Value = x.ProfessionId.ToString() }).ToList();
            ViewBag.vbProfessions = lProfessions;

            var lCountries = new List<SelectListItem>();
            lCountries = db.Countres.Select(x => new SelectListItem { Text = x.CountryName, Value = x.CountryId.ToString() }).ToList();
            ViewBag.vbCountries = lCountries;

            var lRegions = new List<SelectListItem>();
            lRegions = db.Regions.Select(x => new SelectListItem { Text = x.RegionName, Value = x.RegionId.ToString() }).ToList();
            ViewBag.vbRegions = lRegions;

            var lCommunities = new List<SelectListItem>();
            lCommunities = db.Communities.Select(x => new SelectListItem { Text = x.CommunityName, Value = x.CommunityId.ToString() }).ToList();
            ViewBag.vbCommunitys = lCommunities;

            var lRelativeStatus = new List<SelectListItem>();
            lRelativeStatus = db.RelativeStatuses.Select(x => new SelectListItem { Text = x.RelativeStatusName, Value = x.RelativeStatusId.ToString() }).ToList();
            ViewBag.vbRelativeStatuses = lRelativeStatus;

            var lReferralPhysicians = new List<SelectListItem>();
            lReferralPhysicians = db.ReferralPhysicians.Select(x => new SelectListItem { Text = x.ReferralPhysicianName, Value = x.ReferralPhysicianId.ToString() }).ToList();
            ViewBag.vbReferralPhysicians = lReferralPhysicians;

            var lReferralOrganizations = new List<SelectListItem>();
            lReferralOrganizations = db.ReferralOrganizations.Select(x => new SelectListItem { Text = x.ReferralOrganizationName, Value = x.ReferralOrganizationId.ToString() }).ToList();
            ViewBag.vbReferralOrganizations = lReferralOrganizations;
        }

        public ActionResult ReadResidents([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                using (var db = new StoreContext())
                {
                    IQueryable<ResidentItem> resident = db.ResidentItems;
                    DataSourceResult result = resident.ToDataSourceResult(request);
                    return Json(result);
                }
            }
            catch (Exception ex)
            {
                return Json("-1");
            }
        }

        public ActionResult CreateResident()
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    var item = new Resident();
                    return View("ResidentTemplate", item);
                }
            }
            catch (Exception ex)
            {
                return HttpNotFound(ex.Message);
            }
        }

        //[HttpPost]
        //public ActionResult CreateResident(Resident resident)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            using (var db = new StoreContext())
        //            {
        //                db.Residents.Add(resident);
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(ex.Message, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    else
        //    {
        //        return View("ResidentTemplate");
        //    }

        //}

        [OutputCache(Duration = 3600, VaryByParam = "id", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult UpdateResident(int? id)
        {
            ViewBag.activeRec = "active";
            try
            {
                using (var db = new StoreContext())
                {
                    this.OrganizeViewBugs(db);
                    Resident item = db.Residents.Find(id);
                    return View("ResidentTemplate", item);
                }
            }
            catch (Exception ex)
            {
                return HttpNotFound(ex.Message);
            }
        }

        //[HttpPost]
        //public ActionResult UpdateResident(Resident resident)
        //{
        //    try
        //    {
        //        using (var db = new StoreContext())
        //        {
        //            db.Residents.Attach(resident);
        //            db.Entry(resident).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(ex.Message, JsonRequestBehavior.AllowGet);
        //    }
        //}

        [HttpPost]
        public ActionResult Save(Resident resident)
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
                    if (resident.ResidentId == 0)
                    {
                        //ավելացնել
                        db.Residents.Add(resident);
                    }
                    else
                    {
                        //Վերջում խմբագրում ենք 2-րդ մակարդակի աղյուսակի գրառումը
                        Resident mresident = db.Residents.Find(resident.ResidentId);
                        mresident.PatientId = resident.PatientId;
                        mresident.ResidentLastName = resident.ResidentLastName;
                        mresident.ResidentFirstName = resident.ResidentFirstName;
                        mresident.ResidentPatronymicName = resident.ResidentPatronymicName;
                        mresident.BirthDate = resident.BirthDate;
                        mresident.GenderId = resident.GenderId;
                        mresident.Age = resident.Age;
                        mresident.PassportNumber = resident.PassportNumber;
                        mresident.CountryId = resident.CountryId;
                        mresident.RegionId = resident.RegionId;
                        mresident.CommunityId = resident.CommunityId;
                        mresident.Location = resident.Location;
                        mresident.HomePhone = resident.HomePhone;
                        mresident.WorkPhone = resident.WorkPhone;
                        mresident.RelativeName = resident.RelativeName;
                        mresident.RelativeStatusId = resident.RelativeStatusId;
                        mresident.RelativePhone = resident.RelativePhone;
                        mresident.ProfessionId = resident.ProfessionId;
                        mresident.ChildrenCount = resident.ChildrenCount;
                        mresident.ReferralPhysicianId = resident.ReferralPhysicianId;
                        mresident.ReferralOrganizationId = resident.ReferralOrganizationId;

                        db.Entry(mresident).State = EntityState.Modified;

                    }

                    db.SaveChanges();
                    return this.Json(new { statuscode = 1, message = "" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CardiologicalCase", "Save"));
            }
        }

        //[HttpPost]
        //public ActionResult SaveResident(Resident resident)
        //{
        //    try
        //    {
        //        using (var db = new StoreContext())
        //        {
        //            int? cnt = db.Residents.Where(p => p.ResidentId == resident.ResidentId).Count();
        //            if (cnt == 0)
        //            {
        //                db.Residents.Add(resident);
        //            }
        //            else
        //            {
        //                db.Residents.Attach(resident);
        //                db.Entry(resident).State = EntityState.Modified;
        //            }
        //            db.SaveChanges();
        //            return Json("1", JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(ex.Message, JsonRequestBehavior.AllowGet);
        //    }
        //}

        public ActionResult DeleteResident([DataSourceRequest]DataSourceRequest request, int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new StoreContext())
                    {
                        var item = new Resident()
                        {
                            ResidentId = Convert.ToInt32(id),
                        };
                        db.Residents.Attach(item);
                        db.Residents.Remove(item);

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
        [OutputCache(Duration = 3600, VaryByParam = "id", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult ResidentDetail(int? id)
        {
            using (var db = new StoreContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ResidentItem resident = db.ResidentItems.Find(id);
                if (resident == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View("ResidentDetail", resident);
                }
            }
        }
    }
}