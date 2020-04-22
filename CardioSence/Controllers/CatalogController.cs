using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CardioSence.Controllers
{
    [Authorize(Roles = "systemadministratorrole")]
    public class CatalogController : Controller
    {
        #region AbdominalStatus
        public ActionResult AbdominalStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeAbdominalStatus = "active";
            return View();
        }
        public ActionResult AbdominalStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<AbdominalStatus> item = db.AbdominalStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult AbdominalStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AbdominalStatus> item)
        {
            var entities = new List<AbdominalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AbdominalStatus
                        {
                            AbdominalStatusName = itm.AbdominalStatusName,
                        };
                        db.AbdominalStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new AbdominalStatus
            {
                AbdominalStatusId = product.AbdominalStatusId,
                AbdominalStatusName = product.AbdominalStatusName
            }));
        }
        public ActionResult AbdominalStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AbdominalStatus> item)
        {
            var entities = new List<AbdominalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AbdominalStatus
                        {
                            AbdominalStatusId = itm.AbdominalStatusId,
                            AbdominalStatusName = itm.AbdominalStatusName
                        };
                        entities.Add(entity);
                        db.AbdominalStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new AbdominalStatus
            {
                AbdominalStatusId = itm.AbdominalStatusId,
                AbdominalStatusName = itm.AbdominalStatusName
            }));
        }
        public ActionResult AbdominalStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AbdominalStatus> item)
        {
            var entities = new List<AbdominalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AbdominalStatus
                        {
                            AbdominalStatusId = itm.AbdominalStatusId,
                            AbdominalStatusName = itm.AbdominalStatusName
                        };
                        entities.Add(entity);
                        db.AbdominalStatuses.Attach(entity);
                        db.AbdominalStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new AbdominalStatus
            {
                AbdominalStatusId = itm.AbdominalStatusId,
                AbdominalStatusName = itm.AbdominalStatusName
            }));
        }
        #endregion

        #region AlcoholUsage
        public ActionResult AlcoholUsage()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeAlcoholUsage = "active";
            return View();
        }
        public ActionResult AlcoholUsageRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<AlcoholUsage> item = db.AlcoholUsages;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult AlcoholUsageCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AlcoholUsage> item)
        {
            var entities = new List<AlcoholUsage>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AlcoholUsage
                        {
                            AlcoholUsageName = itm.AlcoholUsageName,
                        };
                        db.AlcoholUsages.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new AlcoholUsage
            {
                AlcoholUsageId = product.AlcoholUsageId,
                AlcoholUsageName = product.AlcoholUsageName
            }));
        }
        public ActionResult AlcoholUsageUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AlcoholUsage> item)
        {
            var entities = new List<AlcoholUsage>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AlcoholUsage
                        {
                            AlcoholUsageId = itm.AlcoholUsageId,
                            AlcoholUsageName = itm.AlcoholUsageName
                        };
                        entities.Add(entity);
                        db.AlcoholUsages.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new AlcoholUsage
            {
                AlcoholUsageId = itm.AlcoholUsageId,
                AlcoholUsageName = itm.AlcoholUsageName
            }));
        }
        public ActionResult AlcoholUsageDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AlcoholUsage> item)
        {
            var entities = new List<AlcoholUsage>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new AlcoholUsage
                        {
                            AlcoholUsageId = itm.AlcoholUsageId,
                            AlcoholUsageName = itm.AlcoholUsageName
                        };
                        entities.Add(entity);
                        db.AlcoholUsages.Attach(entity);
                        db.AlcoholUsages.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new AlcoholUsage
            {
                AlcoholUsageId = itm.AlcoholUsageId,
                AlcoholUsageName = itm.AlcoholUsageName
            }));
        }
        #endregion

        #region ArteriaStatus
        public ActionResult ArteriaStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeArteriaStatus = "active";
            return View();
        }
        public ActionResult ArteriaStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ArteriaStatus> item = db.ArteriaStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ArteriaStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ArteriaStatus> item)
        {
            var entities = new List<ArteriaStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ArteriaStatus
                        {
                            ArteriaStatusName = itm.ArteriaStatusName,
                        };
                        db.ArteriaStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ArteriaStatus
            {
                ArteriaStatusId = product.ArteriaStatusId,
                ArteriaStatusName = product.ArteriaStatusName
            }));
        }
        public ActionResult ArteriaStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ArteriaStatus> item)
        {
            var entities = new List<ArteriaStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ArteriaStatus
                        {
                            ArteriaStatusId = itm.ArteriaStatusId,
                            ArteriaStatusName = itm.ArteriaStatusName
                        };
                        entities.Add(entity);
                        db.ArteriaStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ArteriaStatus
            {
                ArteriaStatusId = itm.ArteriaStatusId,
                ArteriaStatusName = itm.ArteriaStatusName
            }));
        }
        public ActionResult ArteriaStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ArteriaStatus> item)
        {
            var entities = new List<ArteriaStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ArteriaStatus
                        {
                            ArteriaStatusId = itm.ArteriaStatusId,
                            ArteriaStatusName = itm.ArteriaStatusName
                        };
                        entities.Add(entity);
                        db.ArteriaStatuses.Attach(entity);
                        db.ArteriaStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ArteriaStatus
            {
                ArteriaStatusId = itm.ArteriaStatusId,
                ArteriaStatusName = itm.ArteriaStatusName
            }));
        }
        #endregion

        #region BBB
        public ActionResult BBB()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBBB = "active";
            return View();
        }
        public ActionResult BBBRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BBB> item = db.BBBS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BBBCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BBB> item)
        {
            var entities = new List<BBB>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BBB
                        {
                            BBBName = itm.BBBName,
                        };
                        db.BBBS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BBB
            {
                BBBId = product.BBBId,
                BBBName = product.BBBName
            }));
        }
        public ActionResult BBBUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BBB> item)
        {
            var entities = new List<BBB>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BBB
                        {
                            BBBId = itm.BBBId,
                            BBBName = itm.BBBName
                        };
                        entities.Add(entity);
                        db.BBBS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BBB
            {
                BBBId = itm.BBBId,
                BBBName = itm.BBBName
            }));
        }
        public ActionResult BBBDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BBB> item)
        {
            var entities = new List<BBB>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BBB
                        {
                            BBBId = itm.BBBId,
                            BBBName = itm.BBBName
                        };
                        entities.Add(entity);
                        db.BBBS.Attach(entity);
                        db.BBBS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BBB
            {
                BBBId = itm.BBBId,
                BBBName = itm.BBBName
            }));
        }
        #endregion

        #region BicarbonateType
        public ActionResult BicarbonateType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBicarbonateType = "active";
            return View();
        }
        public ActionResult BicarbonateTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BicarbonateType> item = db.BicarbonateTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BicarbonateTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BicarbonateType> item)
        {
            var entities = new List<BicarbonateType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BicarbonateType
                        {
                            BicarbonateTypeName = itm.BicarbonateTypeName,
                        };
                        db.BicarbonateTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BicarbonateType
            {
                BicarbonateTypeId = product.BicarbonateTypeId,
                BicarbonateTypeName = product.BicarbonateTypeName
            }));
        }
        public ActionResult BicarbonateTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BicarbonateType> item)
        {
            var entities = new List<BicarbonateType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BicarbonateType
                        {
                            BicarbonateTypeId = itm.BicarbonateTypeId,
                            BicarbonateTypeName = itm.BicarbonateTypeName
                        };
                        entities.Add(entity);
                        db.BicarbonateTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BicarbonateType
            {
                BicarbonateTypeId = itm.BicarbonateTypeId,
                BicarbonateTypeName = itm.BicarbonateTypeName
            }));
        }
        public ActionResult BicarbonateTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BicarbonateType> item)
        {
            var entities = new List<BicarbonateType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BicarbonateType
                        {
                            BicarbonateTypeId = itm.BicarbonateTypeId,
                            BicarbonateTypeName = itm.BicarbonateTypeName
                        };
                        entities.Add(entity);
                        db.BicarbonateTypes.Attach(entity);
                        db.BicarbonateTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BicarbonateType
            {
                BicarbonateTypeId = itm.BicarbonateTypeId,
                BicarbonateTypeName = itm.BicarbonateTypeName
            }));
        }
        #endregion

        #region BloodCholesterol
        public ActionResult BloodCholesterol()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBloodCholesterol = "active";
            return View();
        }
        public ActionResult BloodCholesterolRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BloodCholesterol> item = db.BloodCholesterols;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BloodCholesterolCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodCholesterol> item)
        {
            var entities = new List<BloodCholesterol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodCholesterol
                        {
                            BloodCholesterolName = itm.BloodCholesterolName,
                        };
                        db.BloodCholesterols.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BloodCholesterol
            {
                BloodCholesterolId = product.BloodCholesterolId,
                BloodCholesterolName = product.BloodCholesterolName
            }));
        }
        public ActionResult BloodCholesterolUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodCholesterol> item)
        {
            var entities = new List<BloodCholesterol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodCholesterol
                        {
                            BloodCholesterolId = itm.BloodCholesterolId,
                            BloodCholesterolName = itm.BloodCholesterolName
                        };
                        entities.Add(entity);
                        db.BloodCholesterols.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodCholesterol
            {
                BloodCholesterolId = itm.BloodCholesterolId,
                BloodCholesterolName = itm.BloodCholesterolName
            }));
        }
        public ActionResult BloodCholesterolDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodCholesterol> item)
        {
            var entities = new List<BloodCholesterol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodCholesterol
                        {
                            BloodCholesterolId = itm.BloodCholesterolId,
                            BloodCholesterolName = itm.BloodCholesterolName
                        };
                        entities.Add(entity);
                        db.BloodCholesterols.Attach(entity);
                        db.BloodCholesterols.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodCholesterol
            {
                BloodCholesterolId = itm.BloodCholesterolId,
                BloodCholesterolName = itm.BloodCholesterolName
            }));
        }
        #endregion

        #region BloodGroup
        public ActionResult BloodGroup()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBloodGroup = "active";
            return View();
        }
        public ActionResult BloodGroupRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BloodGroup> item = db.BloodGroups;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BloodGroupCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodGroup> item)
        {
            var entities = new List<BloodGroup>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodGroup
                        {
                            BloodGroupName = itm.BloodGroupName,
                        };
                        db.BloodGroups.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BloodGroup
            {
                BloodGroupId = product.BloodGroupId,
                BloodGroupName = product.BloodGroupName
            }));
        }
        public ActionResult BloodGroupUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodGroup> item)
        {
            var entities = new List<BloodGroup>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodGroup
                        {
                            BloodGroupId = itm.BloodGroupId,
                            BloodGroupName = itm.BloodGroupName
                        };
                        entities.Add(entity);
                        db.BloodGroups.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodGroup
            {
                BloodGroupId = itm.BloodGroupId,
                BloodGroupName = itm.BloodGroupName
            }));
        }
        public ActionResult BloodGroupDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodGroup> item)
        {
            var entities = new List<BloodGroup>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodGroup
                        {
                            BloodGroupId = itm.BloodGroupId,
                            BloodGroupName = itm.BloodGroupName
                        };
                        entities.Add(entity);
                        db.BloodGroups.Attach(entity);
                        db.BloodGroups.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodGroup
            {
                BloodGroupId = itm.BloodGroupId,
                BloodGroupName = itm.BloodGroupName
            }));
        }
        #endregion

        #region BloodProduct
        public ActionResult BloodProduct()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBloodProduct = "active";
            return View();
        }
        public ActionResult BloodProductRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BloodProduct> item = db.BloodProducts;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BloodProductCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodProduct> item)
        {
            var entities = new List<BloodProduct>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodProduct
                        {
                            BloodProductName = itm.BloodProductName,
                        };
                        db.BloodProducts.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BloodProduct
            {
                BloodProductId = product.BloodProductId,
                BloodProductName = product.BloodProductName
            }));
        }
        public ActionResult BloodProductUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodProduct> item)
        {
            var entities = new List<BloodProduct>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodProduct
                        {
                            BloodProductId = itm.BloodProductId,
                            BloodProductName = itm.BloodProductName
                        };
                        entities.Add(entity);
                        db.BloodProducts.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodProduct
            {
                BloodProductId = itm.BloodProductId,
                BloodProductName = itm.BloodProductName
            }));
        }
        public ActionResult BloodProductDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BloodProduct> item)
        {
            var entities = new List<BloodProduct>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BloodProduct
                        {
                            BloodProductId = itm.BloodProductId,
                            BloodProductName = itm.BloodProductName
                        };
                        entities.Add(entity);
                        db.BloodProducts.Attach(entity);
                        db.BloodProducts.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BloodProduct
            {
                BloodProductId = itm.BloodProductId,
                BloodProductName = itm.BloodProductName
            }));
        }
        #endregion

        #region BRUStatus
        public ActionResult BRUStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBRUStatus = "active";
            return View();
        }
        public ActionResult BRUStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<BRUStatus> item = db.BRUStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BRUStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BRUStatus> item)
        {
            var entities = new List<BRUStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BRUStatus
                        {
                            BRUStatusName = itm.BRUStatusName,
                        };
                        db.BRUStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new BRUStatus
            {
                BRUStatusId = product.BRUStatusId,
                BRUStatusName = product.BRUStatusName
            }));
        }
        public ActionResult BRUStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BRUStatus> item)
        {
            var entities = new List<BRUStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BRUStatus
                        {
                            BRUStatusId = itm.BRUStatusId,
                            BRUStatusName = itm.BRUStatusName
                        };
                        entities.Add(entity);
                        db.BRUStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BRUStatus
            {
                BRUStatusId = itm.BRUStatusId,
                BRUStatusName = itm.BRUStatusName
            }));
        }
        public ActionResult BRUStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<BRUStatus> item)
        {
            var entities = new List<BRUStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new BRUStatus
                        {
                            BRUStatusId = itm.BRUStatusId,
                            BRUStatusName = itm.BRUStatusName
                        };
                        entities.Add(entity);
                        db.BRUStatuses.Attach(entity);
                        db.BRUStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new BRUStatus
            {
                BRUStatusId = itm.BRUStatusId,
                BRUStatusName = itm.BRUStatusName
            }));
        }
        #endregion

        #region Bypass
        public ActionResult Bypass()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeBypass = "active";
            return View();
        }
        public ActionResult BypassRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Bypass> item = db.Bypasses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult BypassCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Bypass> item)
        {
            var entities = new List<Bypass>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Bypass
                        {
                            BypassName = itm.BypassName,
                        };
                        db.Bypasses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Bypass
            {
                BypassId = product.BypassId,
                BypassName = product.BypassName
            }));
        }
        public ActionResult BypassUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Bypass> item)
        {
            var entities = new List<Bypass>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Bypass
                        {
                            BypassId = itm.BypassId,
                            BypassName = itm.BypassName
                        };
                        entities.Add(entity);
                        db.Bypasses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Bypass
            {
                BypassId = itm.BypassId,
                BypassName = itm.BypassName
            }));
        }
        public ActionResult BypassDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Bypass> item)
        {
            var entities = new List<Bypass>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Bypass
                        {
                            BypassId = itm.BypassId,
                            BypassName = itm.BypassName
                        };
                        entities.Add(entity);
                        db.Bypasses.Attach(entity);
                        db.Bypasses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Bypass
            {
                BypassId = itm.BypassId,
                BypassName = itm.BypassName
            }));
        }
        #endregion

        #region Cadiomyopathy
        public ActionResult Cadiomyopathy()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCadiomyopathy = "active";
            return View();
        }
        public ActionResult CadiomyopathyRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Cadiomyopathy> item = db.Cadiomyopathies;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CadiomyopathyCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cadiomyopathy> item)
        {
            var entities = new List<Cadiomyopathy>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Cadiomyopathy
                        {
                            CadiomyopathyName = itm.CadiomyopathyName,
                        };
                        db.Cadiomyopathies.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Cadiomyopathy
            {
                CadiomyopathyId = product.CadiomyopathyId,
                CadiomyopathyName = product.CadiomyopathyName
            }));
        }
        public ActionResult CadiomyopathyUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cadiomyopathy> item)
        {
            var entities = new List<Cadiomyopathy>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Cadiomyopathy
                        {
                            CadiomyopathyId = itm.CadiomyopathyId,
                            CadiomyopathyName = itm.CadiomyopathyName
                        };
                        entities.Add(entity);
                        db.Cadiomyopathies.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Cadiomyopathy
            {
                CadiomyopathyId = itm.CadiomyopathyId,
                CadiomyopathyName = itm.CadiomyopathyName
            }));
        }
        public ActionResult CadiomyopathyDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cadiomyopathy> item)
        {
            var entities = new List<Cadiomyopathy>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Cadiomyopathy
                        {
                            CadiomyopathyId = itm.CadiomyopathyId,
                            CadiomyopathyName = itm.CadiomyopathyName
                        };
                        entities.Add(entity);
                        db.Cadiomyopathies.Attach(entity);
                        db.Cadiomyopathies.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Cadiomyopathy
            {
                CadiomyopathyId = itm.CadiomyopathyId,
                CadiomyopathyName = itm.CadiomyopathyName
            }));
        }
        #endregion

        #region CardioplegiaType
        public ActionResult CardioplegiaType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCardioplegiaType = "active";
            return View();
        }
        public ActionResult CardioplegiaTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardioplegiaType> item = db.CardioplegiaTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CardioplegiaTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CardioplegiaType> item)
        {
            var entities = new List<CardioplegiaType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CardioplegiaType
                        {
                            CardioplegiaTypeName = itm.CardioplegiaTypeName,
                        };
                        db.CardioplegiaTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new CardioplegiaType
            {
                CardioplegiaTypeId = product.CardioplegiaTypeId,
                CardioplegiaTypeName = product.CardioplegiaTypeName
            }));
        }
        public ActionResult CardioplegiaTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CardioplegiaType> item)
        {
            var entities = new List<CardioplegiaType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CardioplegiaType
                        {
                            CardioplegiaTypeId = itm.CardioplegiaTypeId,
                            CardioplegiaTypeName = itm.CardioplegiaTypeName
                        };
                        entities.Add(entity);
                        db.CardioplegiaTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CardioplegiaType
            {
                CardioplegiaTypeId = itm.CardioplegiaTypeId,
                CardioplegiaTypeName = itm.CardioplegiaTypeName
            }));
        }
        public ActionResult CardioplegiaTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CardioplegiaType> item)
        {
            var entities = new List<CardioplegiaType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CardioplegiaType
                        {
                            CardioplegiaTypeId = itm.CardioplegiaTypeId,
                            CardioplegiaTypeName = itm.CardioplegiaTypeName
                        };
                        entities.Add(entity);
                        db.CardioplegiaTypes.Attach(entity);
                        db.CardioplegiaTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CardioplegiaType
            {
                CardioplegiaTypeId = itm.CardioplegiaTypeId,
                CardioplegiaTypeName = itm.CardioplegiaTypeName
            }));
        }
        #endregion

        #region CaroticBruit
        public ActionResult CaroticBruit()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCaroticBruit = "active";
            return View();
        }
        public ActionResult CaroticBruitRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CaroticBruit> item = db.CaroticBruits;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CaroticBruitCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CaroticBruit> item)
        {
            var entities = new List<CaroticBruit>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CaroticBruit
                        {
                            CaroticBruitName = itm.CaroticBruitName,
                        };
                        db.CaroticBruits.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new CaroticBruit
            {
                CaroticBruitId = product.CaroticBruitId,
                CaroticBruitName = product.CaroticBruitName
            }));
        }
        public ActionResult CaroticBruitUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CaroticBruit> item)
        {
            var entities = new List<CaroticBruit>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CaroticBruit
                        {
                            CaroticBruitId = itm.CaroticBruitId,
                            CaroticBruitName = itm.CaroticBruitName
                        };
                        entities.Add(entity);
                        db.CaroticBruits.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CaroticBruit
            {
                CaroticBruitId = itm.CaroticBruitId,
                CaroticBruitName = itm.CaroticBruitName
            }));
        }
        public ActionResult CaroticBruitDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CaroticBruit> item)
        {
            var entities = new List<CaroticBruit>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CaroticBruit
                        {
                            CaroticBruitId = itm.CaroticBruitId,
                            CaroticBruitName = itm.CaroticBruitName
                        };
                        entities.Add(entity);
                        db.CaroticBruits.Attach(entity);
                        db.CaroticBruits.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CaroticBruit
            {
                CaroticBruitId = itm.CaroticBruitId,
                CaroticBruitName = itm.CaroticBruitName
            }));
        }
        #endregion

        #region CATD
        public ActionResult CATD()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCATD = "active";
            return View();
        }
        public ActionResult CATDRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CATD> item = db.CATDS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CATDCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CATD> item)
        {
            var entities = new List<CATD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CATD
                        {
                            CATDName = itm.CATDName,
                        };
                        db.CATDS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new CATD
            {
                CATDId = product.CATDId,
                CATDName = product.CATDName
            }));
        }
        public ActionResult CATDUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CATD> item)
        {
            var entities = new List<CATD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CATD
                        {
                            CATDId = itm.CATDId,
                            CATDName = itm.CATDName
                        };
                        entities.Add(entity);
                        db.CATDS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CATD
            {
                CATDId = itm.CATDId,
                CATDName = itm.CATDName
            }));
        }
        public ActionResult CATDDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CATD> item)
        {
            var entities = new List<CATD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CATD
                        {
                            CATDId = itm.CATDId,
                            CATDName = itm.CATDName
                        };
                        entities.Add(entity);
                        db.CATDS.Attach(entity);
                        db.CATDS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CATD
            {
                CATDId = itm.CATDId,
                CATDName = itm.CATDName
            }));
        }
        #endregion

        #region CCS
        public ActionResult CCS()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCCS = "active";
            return View();
        }
        public ActionResult CCSRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CCS> item = db.CCSS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CCSCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CCS> item)
        {
            var entities = new List<CCS>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CCS
                        {
                            CCSName = itm.CCSName,
                        };
                        db.CCSS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new CCS
            {
                CCSId = product.CCSId,
                CCSName = product.CCSName
            }));
        }
        public ActionResult CCSUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CCS> item)
        {
            var entities = new List<CCS>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CCS
                        {
                            CCSId = itm.CCSId,
                            CCSName = itm.CCSName
                        };
                        entities.Add(entity);
                        db.CCSS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CCS
            {
                CCSId = itm.CCSId,
                CCSName = itm.CCSName
            }));
        }
        public ActionResult CCSDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CCS> item)
        {
            var entities = new List<CCS>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CCS
                        {
                            CCSId = itm.CCSId,
                            CCSName = itm.CCSName
                        };
                        entities.Add(entity);
                        db.CCSS.Attach(entity);
                        db.CCSS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CCS
            {
                CCSId = itm.CCSId,
                CCSName = itm.CCSName
            }));
        }
        #endregion

        #region CHD
        public ActionResult CHD()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCHD = "active";
            return View();
        }
        public ActionResult CHDRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CHD> item = db.CHDS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CHDCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CHD> item)
        {
            var entities = new List<CHD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CHD
                        {
                            CHDName = itm.CHDName,
                        };
                        db.CHDS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new CHD
            {
                CHDId = product.CHDId,
                CHDName = product.CHDName
            }));
        }
        public ActionResult CHDUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CHD> item)
        {
            var entities = new List<CHD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CHD
                        {
                            CHDId = itm.CHDId,
                            CHDName = itm.CHDName
                        };
                        entities.Add(entity);
                        db.CHDS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CHD
            {
                CHDId = itm.CHDId,
                CHDName = itm.CHDName
            }));
        }
        public ActionResult CHDDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<CHD> item)
        {
            var entities = new List<CHD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new CHD
                        {
                            CHDId = itm.CHDId,
                            CHDName = itm.CHDName
                        };
                        entities.Add(entity);
                        db.CHDS.Attach(entity);
                        db.CHDS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new CHD
            {
                CHDId = itm.CHDId,
                CHDName = itm.CHDName
            }));
        }
        #endregion

        #region ClimaxStatus
        public ActionResult ClimaxStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeClimaxStatus = "active";
            return View();
        }
        public ActionResult ClimaxStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ClimaxStatus> item = db.ClimaxStatusis;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ClimaxStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ClimaxStatus> item)
        {
            var entities = new List<ClimaxStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ClimaxStatus
                        {
                            ClimaxStatusName = itm.ClimaxStatusName,
                        };
                        db.ClimaxStatusis.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ClimaxStatus
            {
                ClimaxStatusId = product.ClimaxStatusId,
                ClimaxStatusName = product.ClimaxStatusName
            }));
        }
        public ActionResult ClimaxStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ClimaxStatus> item)
        {
            var entities = new List<ClimaxStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ClimaxStatus
                        {
                            ClimaxStatusId = itm.ClimaxStatusId,
                            ClimaxStatusName = itm.ClimaxStatusName
                        };
                        entities.Add(entity);
                        db.ClimaxStatusis.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ClimaxStatus
            {
                ClimaxStatusId = itm.ClimaxStatusId,
                ClimaxStatusName = itm.ClimaxStatusName
            }));
        }
        public ActionResult ClimaxStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ClimaxStatus> item)
        {
            var entities = new List<ClimaxStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ClimaxStatus
                        {
                            ClimaxStatusId = itm.ClimaxStatusId,
                            ClimaxStatusName = itm.ClimaxStatusName
                        };
                        entities.Add(entity);
                        db.ClimaxStatusis.Attach(entity);
                        db.ClimaxStatusis.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ClimaxStatus
            {
                ClimaxStatusId = itm.ClimaxStatusId,
                ClimaxStatusName = itm.ClimaxStatusName
            }));
        }
        #endregion

        #region Community
        public ActionResult Community()
        {
            ViewBag.activeCatalosg = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCommunity = "active";
            return View();
        }
        public ActionResult CommunityRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Community> item = db.Communities;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CommunityCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Community> item)
        {
            var entities = new List<Community>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Community
                        {
                            CommunityName = itm.CommunityName,
                        };
                        db.Communities.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Community
            {
                CommunityId = product.CommunityId,
                CommunityName = product.CommunityName
            }));
        }
        public ActionResult CommunityUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Community> item)
        {
            var entities = new List<Community>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Community
                        {
                            CommunityId = itm.CommunityId,
                            CommunityName = itm.CommunityName
                        };
                        entities.Add(entity);
                        db.Communities.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Community
            {
                CommunityId = itm.CommunityId,
                CommunityName = itm.CommunityName
            }));
        }
        public ActionResult CommunityDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Community> item)
        {
            var entities = new List<Community>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Community
                        {
                            CommunityId = itm.CommunityId,
                            CommunityName = itm.CommunityName
                        };
                        entities.Add(entity);
                        db.Communities.Attach(entity);
                        db.Communities.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Community
            {
                CommunityId = itm.CommunityId,
                CommunityName = itm.CommunityName
            }));
        }
        #endregion

        #region Complian
        public ActionResult Complian()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeComplian = "active";
            return View();
        }
        public ActionResult ComplianRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Complian> item = db.Complians;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ComplianCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complian> item)
        {
            var entities = new List<Complian>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complian
                        {
                            ComplianName = itm.ComplianName,
                        };
                        db.Complians.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Complian
            {
                ComplianId = product.ComplianId,
                ComplianName = product.ComplianName
            }));
        }
        public ActionResult ComplianUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complian> item)
        {
            var entities = new List<Complian>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complian
                        {
                            ComplianId = itm.ComplianId,
                            ComplianName = itm.ComplianName
                        };
                        entities.Add(entity);
                        db.Complians.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Complian
            {
                ComplianId = itm.ComplianId,
                ComplianName = itm.ComplianName
            }));
        }
        public ActionResult ComplianDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complian> item)
        {
            var entities = new List<Complian>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complian
                        {
                            ComplianId = itm.ComplianId,
                            ComplianName = itm.ComplianName
                        };
                        entities.Add(entity);
                        db.Complians.Attach(entity);
                        db.Complians.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Complian
            {
                ComplianId = itm.ComplianId,
                ComplianName = itm.ComplianName
            }));
        }
        #endregion

        #region Complication
        public ActionResult Complication()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeComplication = "active";
            return View();
        }
        public ActionResult ComplicationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Complication> item = db.Complications;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ComplicationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complication> item)
        {
            var entities = new List<Complication>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complication
                        {
                            ComplicationName = itm.ComplicationName,
                        };
                        db.Complications.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Complication
            {
                ComplicationId = product.ComplicationId,
                ComplicationName = product.ComplicationName
            }));
        }
        public ActionResult ComplicationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complication> item)
        {
            var entities = new List<Complication>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complication
                        {
                            ComplicationId = itm.ComplicationId,
                            ComplicationName = itm.ComplicationName
                        };
                        entities.Add(entity);
                        db.Complications.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Complication
            {
                ComplicationId = itm.ComplicationId,
                ComplicationName = itm.ComplicationName
            }));
        }
        public ActionResult ComplicationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Complication> item)
        {
            var entities = new List<Complication>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Complication
                        {
                            ComplicationId = itm.ComplicationId,
                            ComplicationName = itm.ComplicationName
                        };
                        entities.Add(entity);
                        db.Complications.Attach(entity);
                        db.Complications.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Complication
            {
                ComplicationId = itm.ComplicationId,
                ComplicationName = itm.ComplicationName
            }));
        }
        #endregion

        #region ConductionDisturbance
        public ActionResult ConductionDisturbance()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeConductionDisturbance = "active";
            return View();
        }
        public ActionResult ConductionDisturbanceRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ConductionDisturbance> item = db.ConductionDisturbances;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ConductionDisturbanceCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ConductionDisturbance> item)
        {
            var entities = new List<ConductionDisturbance>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ConductionDisturbance
                        {
                            ConductionDisturbanceName = itm.ConductionDisturbanceName,
                        };
                        db.ConductionDisturbances.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ConductionDisturbance
            {
                ConductionDisturbanceId = product.ConductionDisturbanceId,
                ConductionDisturbanceName = product.ConductionDisturbanceName
            }));
        }
        public ActionResult ConductionDisturbanceUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ConductionDisturbance> item)
        {
            var entities = new List<ConductionDisturbance>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ConductionDisturbance
                        {
                            ConductionDisturbanceId = itm.ConductionDisturbanceId,
                            ConductionDisturbanceName = itm.ConductionDisturbanceName
                        };
                        entities.Add(entity);
                        db.ConductionDisturbances.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ConductionDisturbance
            {
                ConductionDisturbanceId = itm.ConductionDisturbanceId,
                ConductionDisturbanceName = itm.ConductionDisturbanceName
            }));
        }
        public ActionResult ConductionDisturbanceDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ConductionDisturbance> item)
        {
            var entities = new List<ConductionDisturbance>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ConductionDisturbance
                        {
                            ConductionDisturbanceId = itm.ConductionDisturbanceId,
                            ConductionDisturbanceName = itm.ConductionDisturbanceName
                        };
                        entities.Add(entity);
                        db.ConductionDisturbances.Attach(entity);
                        db.ConductionDisturbances.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ConductionDisturbance
            {
                ConductionDisturbanceId = itm.ConductionDisturbanceId,
                ConductionDisturbanceName = itm.ConductionDisturbanceName
            }));
        }
        #endregion

        #region Contractility
        public ActionResult Contractility()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeContractility = "active";
            return View();
        }
        public ActionResult ContractilityRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Contractility> item = db.Contractilityes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ContractilityCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Contractility> item)
        {
            var entities = new List<Contractility>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Contractility
                        {
                            ContractilityName = itm.ContractilityName,
                        };
                        db.Contractilityes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Contractility
            {
                ContractilityId = product.ContractilityId,
                ContractilityName = product.ContractilityName
            }));
        }
        public ActionResult ContractilityUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Contractility> item)
        {
            var entities = new List<Contractility>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Contractility
                        {
                            ContractilityId = itm.ContractilityId,
                            ContractilityName = itm.ContractilityName
                        };
                        entities.Add(entity);
                        db.Contractilityes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Contractility
            {
                ContractilityId = itm.ContractilityId,
                ContractilityName = itm.ContractilityName
            }));
        }
        public ActionResult ContractilityDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Contractility> item)
        {
            var entities = new List<Contractility>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Contractility
                        {
                            ContractilityId = itm.ContractilityId,
                            ContractilityName = itm.ContractilityName
                        };
                        entities.Add(entity);
                        db.Contractilityes.Attach(entity);
                        db.Contractilityes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Contractility
            {
                ContractilityId = itm.ContractilityId,
                ContractilityName = itm.ContractilityName
            }));
        }
        #endregion

        #region COPD
        public ActionResult COPD()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCOPD = "active";
            return View();
        }
        public ActionResult COPDRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<COPD> item = db.COPDS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult COPDCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<COPD> item)
        {
            var entities = new List<COPD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new COPD
                        {
                            COPDName = itm.COPDName,
                        };
                        db.COPDS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new COPD
            {
                COPDId = product.COPDId,
                COPDName = product.COPDName
            }));
        }
        public ActionResult COPDUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<COPD> item)
        {
            var entities = new List<COPD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new COPD
                        {
                            COPDId = itm.COPDId,
                            COPDName = itm.COPDName
                        };
                        entities.Add(entity);
                        db.COPDS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new COPD
            {
                COPDId = itm.COPDId,
                COPDName = itm.COPDName
            }));
        }
        public ActionResult COPDDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<COPD> item)
        {
            var entities = new List<COPD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new COPD
                        {
                            COPDId = itm.COPDId,
                            COPDName = itm.COPDName
                        };
                        entities.Add(entity);
                        db.COPDS.Attach(entity);
                        db.COPDS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new COPD
            {
                COPDId = itm.COPDId,
                COPDName = itm.COPDName
            }));
        }
        #endregion

        #region Country
        public ActionResult Country()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeCountry = "active";
            return View();
        }
        public ActionResult CountryRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Country> item = db.Countres;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult CountryCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Country> item)
        {
            var entities = new List<Country>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Country
                        {
                            CountryName= itm.CountryName,
                        };
                        db.Countres.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Country
            {
                CountryId = product.CountryId,
                CountryName = product.CountryName
            }));
        }
        public ActionResult CountryUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Country> item)
        {
            var entities = new List<Country>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Country
                        {
                            CountryId = itm.CountryId,
                            CountryName = itm.CountryName
                        };
                        entities.Add(entity);
                        db.Countres.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Country
            {
                CountryId = itm.CountryId,
                CountryName = itm.CountryName
            }));
        }
        public ActionResult CountryDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Country> item)
        {
            var entities = new List<Country>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Country
                        {
                            CountryId = itm.CountryId,
                            CountryName = itm.CountryName
                        };
                        entities.Add(entity);
                        db.Countres.Attach(entity);
                        db.Countres.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Country
            {
                CountryId = itm.CountryId,
                CountryName = itm.CountryName
            }));
        }
        #endregion

        #region DeathCause
        public ActionResult DeathCause()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDeathCause = "active";
            return View();
        }
        public ActionResult DeathCauseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DeathCause> item = db.DeathCausis;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DeathCauseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathCause> item)
        {
            var entities = new List<DeathCause>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathCause
                        {
                            DeathCauseName = itm.DeathCauseName,
                        };
                        db.DeathCausis.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DeathCause
            {
                DeathCauseId = product.DeathCauseId,
                DeathCauseName = product.DeathCauseName
            }));
        }
        public ActionResult DeathCauseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathCause> item)
        {
            var entities = new List<DeathCause>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathCause
                        {
                            DeathCauseId = itm.DeathCauseId,
                            DeathCauseName = itm.DeathCauseName
                        };
                        entities.Add(entity);
                        db.DeathCausis.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DeathCause
            {
                DeathCauseId = itm.DeathCauseId,
                DeathCauseName = itm.DeathCauseName
            }));
        }
        public ActionResult DeathCauseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathCause> item)
        {
            var entities = new List<DeathCause>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathCause
                        {
                            DeathCauseId = itm.DeathCauseId,
                            DeathCauseName = itm.DeathCauseName
                        };
                        entities.Add(entity);
                        db.DeathCausis.Attach(entity);
                        db.DeathCausis.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DeathCause
            {
                DeathCauseId = itm.DeathCauseId,
                DeathCauseName = itm.DeathCauseName
            }));
        }
        #endregion

        #region DeathOrganization
        public ActionResult DeathOrganization()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDeathOrganization = "active";
            return View();
        }
        public ActionResult DeathOrganizationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DeathOrganization> item = db.DeathOrganizations;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DeathOrganizationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathOrganization> item)
        {
            var entities = new List<DeathOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathOrganization
                        {
                            DeathOrganizationName = itm.DeathOrganizationName,
                        };
                        db.DeathOrganizations.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DeathOrganization
            {
                DeathOrganizationId = product.DeathOrganizationId,
                DeathOrganizationName = product.DeathOrganizationName
            }));
        }
        public ActionResult DeathOrganizationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathOrganization> item)
        {
            var entities = new List<DeathOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathOrganization
                        {
                            DeathOrganizationId = itm.DeathOrganizationId,
                            DeathOrganizationName = itm.DeathOrganizationName
                        };
                        entities.Add(entity);
                        db.DeathOrganizations.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DeathOrganization
            {
                DeathOrganizationId = itm.DeathOrganizationId,
                DeathOrganizationName = itm.DeathOrganizationName
            }));
        }
        public ActionResult DeathOrganizationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DeathOrganization> item)
        {
            var entities = new List<DeathOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DeathOrganization
                        {
                            DeathOrganizationId = itm.DeathOrganizationId,
                            DeathOrganizationName = itm.DeathOrganizationName
                        };
                        entities.Add(entity);
                        db.DeathOrganizations.Attach(entity);
                        db.DeathOrganizations.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DeathOrganization
            {
                DeathOrganizationId = itm.DeathOrganizationId,
                DeathOrganizationName = itm.DeathOrganizationName
            }));
        }
        #endregion

        #region DentalDisease
        public ActionResult DentalDisease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDentalDisease = "active";
            return View();
        }
        public ActionResult DentalDiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DentalDisease> item = db.DentalDiseases;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DentalDiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DentalDisease> item)
        {
            var entities = new List<DentalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DentalDisease
                        {
                            DentalDiseaseName = itm.DentalDiseaseName,
                        };
                        db.DentalDiseases.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DentalDisease
            {
                DentalDiseaseId = product.DentalDiseaseId,
                DentalDiseaseName = product.DentalDiseaseName
            }));
        }
        public ActionResult DentalDiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DentalDisease> item)
        {
            var entities = new List<DentalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DentalDisease
                        {
                            DentalDiseaseId = itm.DentalDiseaseId,
                            DentalDiseaseName = itm.DentalDiseaseName
                        };
                        entities.Add(entity);
                        db.DentalDiseases.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DentalDisease
            {
                DentalDiseaseId = itm.DentalDiseaseId,
                DentalDiseaseName = itm.DentalDiseaseName
            }));
        }
        public ActionResult DentalDiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DentalDisease> item)
        {
            var entities = new List<DentalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DentalDisease
                        {
                            DentalDiseaseId = itm.DentalDiseaseId,
                            DentalDiseaseName = itm.DentalDiseaseName
                        };
                        entities.Add(entity);
                        db.DentalDiseases.Attach(entity);
                        db.DentalDiseases.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DentalDisease
            {
                DentalDiseaseId = itm.DentalDiseaseId,
                DentalDiseaseName = itm.DentalDiseaseName
            }));
        }
        #endregion

        #region Disease
        public ActionResult Disease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDisease = "active";
            return View();
        }
        public ActionResult DiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Disease> item = db.Diseases;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Disease> item)
        {
            var entities = new List<Disease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Disease
                        {
                            DiseaseName = itm.DiseaseName,
                        };
                        db.Diseases.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Disease
            {
                DiseaseId = product.DiseaseId,
                DiseaseName = product.DiseaseName
            }));
        }
        public ActionResult DiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Disease> item)
        {
            var entities = new List<Disease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Disease
                        {
                            DiseaseId = itm.DiseaseId,
                            DiseaseName = itm.DiseaseName
                        };
                        entities.Add(entity);
                        db.Diseases.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Disease
            {
                DiseaseId = itm.DiseaseId,
                DiseaseName = itm.DiseaseName
            }));
        }
        public ActionResult DiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Disease> item)
        {
            var entities = new List<Disease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Disease
                        {
                            DiseaseId = itm.DiseaseId,
                            DiseaseName = itm.DiseaseName
                        };
                        entities.Add(entity);
                        db.Diseases.Attach(entity);
                        db.Diseases.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Disease
            {
                DiseaseId = itm.DiseaseId,
                DiseaseName = itm.DiseaseName
            }));
        }
        #endregion

        #region DiseaseStatus
        public ActionResult DiseaseStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDiseaseStatus = "active";
            return View();
        }
        public ActionResult DiseaseStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DiseaseStatus> item = db.DiseaseStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DiseaseStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DiseaseStatus> item)
        {
            var entities = new List<DiseaseStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DiseaseStatus
                        {
                            DiseaseStatusName = itm.DiseaseStatusName,
                        };
                        db.DiseaseStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DiseaseStatus
            {
                DiseaseStatusId = product.DiseaseStatusId,
                DiseaseStatusName = product.DiseaseStatusName
            }));
        }
        public ActionResult DiseaseStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DiseaseStatus> item)
        {
            var entities = new List<DiseaseStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DiseaseStatus
                        {
                            DiseaseStatusId = itm.DiseaseStatusId,
                            DiseaseStatusName = itm.DiseaseStatusName
                        };
                        entities.Add(entity);
                        db.DiseaseStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DiseaseStatus
            {
                DiseaseStatusId = itm.DiseaseStatusId,
                DiseaseStatusName = itm.DiseaseStatusName
            }));
        }
        public ActionResult DiseaseStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DiseaseStatus> item)
        {
            var entities = new List<DiseaseStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DiseaseStatus
                        {
                            DiseaseStatusId = itm.DiseaseStatusId,
                            DiseaseStatusName = itm.DiseaseStatusName
                        };
                        entities.Add(entity);
                        db.DiseaseStatuses.Attach(entity);
                        db.DiseaseStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DiseaseStatus
            {
                DiseaseStatusId = itm.DiseaseStatusId,
                DiseaseStatusName = itm.DiseaseStatusName
            }));
        }
        #endregion

        #region DominanceType
        public ActionResult DominanceType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDominanceType = "active";
            return View();
        }
        public ActionResult DominanceTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DominanceType> item = db.DominanceTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DominanceTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DominanceType> item)
        {
            var entities = new List<DominanceType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DominanceType
                        {
                            DominanceTypeName = itm.DominanceTypeName,
                        };
                        db.DominanceTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DominanceType
            {
                DominanceTypeId = product.DominanceTypeId,
                DominanceTypeName = product.DominanceTypeName
            }));
        }
        public ActionResult DominanceTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DominanceType> item)
        {
            var entities = new List<DominanceType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DominanceType
                        {
                            DominanceTypeId = itm.DominanceTypeId,
                            DominanceTypeName = itm.DominanceTypeName
                        };
                        entities.Add(entity);
                        db.DominanceTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DominanceType
            {
                DominanceTypeId = itm.DominanceTypeId,
                DominanceTypeName = itm.DominanceTypeName
            }));
        }
        public ActionResult DominanceTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DominanceType> item)
        {
            var entities = new List<DominanceType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DominanceType
                        {
                            DominanceTypeId = itm.DominanceTypeId,
                            DominanceTypeName = itm.DominanceTypeName
                        };
                        entities.Add(entity);
                        db.DominanceTypes.Attach(entity);
                        db.DominanceTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DominanceType
            {
                DominanceTypeId = itm.DominanceTypeId,
                DominanceTypeName = itm.DominanceTypeName
            }));
        }
        #endregion

        #region Drug
        public ActionResult Drug()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDrug = "active";
            return View();
        }
        public ActionResult DrugRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Drug> item = db.Drugs;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DrugCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Drug> item)
        {
            var entities = new List<Drug>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Drug
                        {
                            DrugName = itm.DrugName,
                        };
                        db.Drugs.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Drug
            {
                DrugId = product.DrugId,
                DrugName = product.DrugName
            }));
        }
        public ActionResult DrugUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Drug> item)
        {
            var entities = new List<Drug>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Drug
                        {
                            DrugId = itm.DrugId,
                            DrugName = itm.DrugName
                        };
                        entities.Add(entity);
                        db.Drugs.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Drug
            {
                DrugId = itm.DrugId,
                DrugName = itm.DrugName
            }));
        }
        public ActionResult DrugDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Drug> item)
        {
            var entities = new List<Drug>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Drug
                        {
                            DrugId = itm.DrugId,
                            DrugName = itm.DrugName
                        };
                        entities.Add(entity);
                        db.Drugs.Attach(entity);
                        db.Drugs.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Drug
            {
                DrugId = itm.DrugId,
                DrugName = itm.DrugName
            }));
        }
        #endregion

        #region DrugElutionType
        public ActionResult DrugElutionType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDrugElutionType = "active";
            return View();
        }
        public ActionResult DrugElutionTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DrugElutionType> item = db.DrugElutionTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DrugElutionTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugElutionType> item)
        {
            var entities = new List<DrugElutionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugElutionType
                        {
                            DrugElutionTypeName = itm.DrugElutionTypeName,
                        };
                        db.DrugElutionTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DrugElutionType
            {
                DrugElutionTypeId = product.DrugElutionTypeId,
                DrugElutionTypeName = product.DrugElutionTypeName
            }));
        }
        public ActionResult DrugElutionTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugElutionType> item)
        {
            var entities = new List<DrugElutionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugElutionType
                        {
                            DrugElutionTypeId = itm.DrugElutionTypeId,
                            DrugElutionTypeName = itm.DrugElutionTypeName
                        };
                        entities.Add(entity);
                        db.DrugElutionTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DrugElutionType
            {
                DrugElutionTypeId = itm.DrugElutionTypeId,
                DrugElutionTypeName = itm.DrugElutionTypeName
            }));
        }
        public ActionResult DrugElutionTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugElutionType> item)
        {
            var entities = new List<DrugElutionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugElutionType
                        {
                            DrugElutionTypeId = itm.DrugElutionTypeId,
                            DrugElutionTypeName = itm.DrugElutionTypeName
                        };
                        entities.Add(entity);
                        db.DrugElutionTypes.Attach(entity);
                        db.DrugElutionTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DrugElutionType
            {
                DrugElutionTypeId = itm.DrugElutionTypeId,
                DrugElutionTypeName = itm.DrugElutionTypeName
            }));
        }
        #endregion

        #region DrugFrequency
        public ActionResult DrugFrequency()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDrugFrequency = "active";
            return View();
        }
        public ActionResult DrugFrequencyRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DrugFrequency> item = db.DrugFrequencies;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DrugFrequencyCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugFrequency> item)
        {
            var entities = new List<DrugFrequency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugFrequency
                        {
                            DrugFrequencyName = itm.DrugFrequencyName,
                        };
                        db.DrugFrequencies.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DrugFrequency
            {
                DrugFrequencyId = product.DrugFrequencyId,
                DrugFrequencyName = product.DrugFrequencyName
            }));
        }
        public ActionResult DrugFrequencyUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugFrequency> item)
        {
            var entities = new List<DrugFrequency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugFrequency
                        {
                            DrugFrequencyId = itm.DrugFrequencyId,
                            DrugFrequencyName = itm.DrugFrequencyName
                        };
                        entities.Add(entity);
                        db.DrugFrequencies.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DrugFrequency
            {
                DrugFrequencyId = itm.DrugFrequencyId,
                DrugFrequencyName = itm.DrugFrequencyName
            }));
        }
        public ActionResult DrugFrequencyDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DrugFrequency> item)
        {
            var entities = new List<DrugFrequency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DrugFrequency
                        {
                            DrugFrequencyId = itm.DrugFrequencyId,
                            DrugFrequencyName = itm.DrugFrequencyName
                        };
                        entities.Add(entity);
                        db.DrugFrequencies.Attach(entity);
                        db.DrugFrequencies.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DrugFrequency
            {
                DrugFrequencyId = itm.DrugFrequencyId,
                DrugFrequencyName = itm.DrugFrequencyName
            }));
        }
        #endregion

        #region DuplexStenosis
        public ActionResult DuplexStenosis()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeDuplexStenosis = "active";
            return View();
        }
        public ActionResult DuplexStenosisRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<DuplexStenosis> item = db.DuplexStenoses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult DuplexStenosisCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DuplexStenosis> item)
        {
            var entities = new List<DuplexStenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DuplexStenosis
                        {
                            DuplexStenosisName = itm.DuplexStenosisName,
                        };
                        db.DuplexStenoses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new DuplexStenosis
            {
                DuplexStenosisId = product.DuplexStenosisId,
                DuplexStenosisName = product.DuplexStenosisName
            }));
        }
        public ActionResult DuplexStenosisUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DuplexStenosis> item)
        {
            var entities = new List<DuplexStenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DuplexStenosis
                        {
                            DuplexStenosisId = itm.DuplexStenosisId,
                            DuplexStenosisName = itm.DuplexStenosisName
                        };
                        entities.Add(entity);
                        db.DuplexStenoses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DuplexStenosis
            {
                DuplexStenosisId = itm.DuplexStenosisId,
                DuplexStenosisName = itm.DuplexStenosisName
            }));
        }
        public ActionResult DuplexStenosisDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<DuplexStenosis> item)
        {
            var entities = new List<DuplexStenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new DuplexStenosis
                        {
                            DuplexStenosisId = itm.DuplexStenosisId,
                            DuplexStenosisName = itm.DuplexStenosisName
                        };
                        entities.Add(entity);
                        db.DuplexStenoses.Attach(entity);
                        db.DuplexStenoses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new DuplexStenosis
            {
                DuplexStenosisId = itm.DuplexStenosisId,
                DuplexStenosisName = itm.DuplexStenosisName
            }));
        }
        #endregion

        #region ECGZone
        public ActionResult ECGZone()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeECGZone = "active";
            return View();
        }
        public ActionResult ECGZoneRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ECGZone> item = db.ECGZones;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ECGZoneCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ECGZone> item)
        {
            var entities = new List<ECGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ECGZone
                        {
                            ECGZoneName = itm.ECGZoneName,
                        };
                        db.ECGZones.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ECGZone
            {
                ECGZoneId = product.ECGZoneId,
                ECGZoneName = product.ECGZoneName
            }));
        }
        public ActionResult ECGZoneUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ECGZone> item)
        {
            var entities = new List<ECGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ECGZone
                        {
                            ECGZoneId = itm.ECGZoneId,
                            ECGZoneName = itm.ECGZoneName
                        };
                        entities.Add(entity);
                        db.ECGZones.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ECGZone
            {
                ECGZoneId = itm.ECGZoneId,
                ECGZoneName = itm.ECGZoneName
            }));
        }
        public ActionResult ECGZoneDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ECGZone> item)
        {
            var entities = new List<ECGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ECGZone
                        {
                            ECGZoneId = itm.ECGZoneId,
                            ECGZoneName = itm.ECGZoneName
                        };
                        entities.Add(entity);
                        db.ECGZones.Attach(entity);
                        db.ECGZones.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ECGZone
            {
                ECGZoneId = itm.ECGZoneId,
                ECGZoneName = itm.ECGZoneName
            }));
        }
        #endregion

        #region EchoCGZone
        public ActionResult EchoCGZone()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeEchoCGZone = "active";
            return View();
        }
        public ActionResult EchoCGZoneRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<EchoCGZone> item = db.EchoCGZones;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult EchoCGZoneCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<EchoCGZone> item)
        {
            var entities = new List<EchoCGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new EchoCGZone
                        {
                            EchoCGZoneName = itm.EchoCGZoneName,
                        };
                        db.EchoCGZones.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new EchoCGZone
            {
                EchoCGZoneId = product.EchoCGZoneId,
                EchoCGZoneName = product.EchoCGZoneName
            }));
        }
        public ActionResult EchoCGZoneUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<EchoCGZone> item)
        {
            var entities = new List<EchoCGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new EchoCGZone
                        {
                            EchoCGZoneId = itm.EchoCGZoneId,
                            EchoCGZoneName = itm.EchoCGZoneName
                        };
                        entities.Add(entity);
                        db.EchoCGZones.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new EchoCGZone
            {
                EchoCGZoneId = itm.EchoCGZoneId,
                EchoCGZoneName = itm.EchoCGZoneName
            }));
        }
        public ActionResult EchoCGZoneDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<EchoCGZone> item)
        {
            var entities = new List<EchoCGZone>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new EchoCGZone
                        {
                            EchoCGZoneId = itm.EchoCGZoneId,
                            EchoCGZoneName = itm.EchoCGZoneName
                        };
                        entities.Add(entity);
                        db.EchoCGZones.Attach(entity);
                        db.EchoCGZones.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new EchoCGZone
            {
                EchoCGZoneId = itm.EchoCGZoneId,
                EchoCGZoneName = itm.EchoCGZoneName
            }));
        }
        #endregion

        #region GastrointestinalDisease
        public ActionResult GastrointestinalDisease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeGastrointestinalDisease = "active";
            return View();
        }
        public ActionResult GastrointestinalDiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<GastrointestinalDisease> item = db.GastrointestinalDiseasis;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult GastrointestinalDiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<GastrointestinalDisease> item)
        {
            var entities = new List<GastrointestinalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new GastrointestinalDisease
                        {
                            GastrointestinalDiseaseName = itm.GastrointestinalDiseaseName,
                        };
                        db.GastrointestinalDiseasis.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new GastrointestinalDisease
            {
                GastrointestinalDiseaseId = product.GastrointestinalDiseaseId,
                GastrointestinalDiseaseName = product.GastrointestinalDiseaseName
            }));
        }
        public ActionResult GastrointestinalDiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<GastrointestinalDisease> item)
        {
            var entities = new List<GastrointestinalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new GastrointestinalDisease
                        {
                            GastrointestinalDiseaseId = itm.GastrointestinalDiseaseId,
                            GastrointestinalDiseaseName = itm.GastrointestinalDiseaseName
                        };
                        entities.Add(entity);
                        db.GastrointestinalDiseasis.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new GastrointestinalDisease
            {
                GastrointestinalDiseaseId = itm.GastrointestinalDiseaseId,
                GastrointestinalDiseaseName = itm.GastrointestinalDiseaseName
            }));
        }
        public ActionResult GastrointestinalDiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<GastrointestinalDisease> item)
        {
            var entities = new List<GastrointestinalDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new GastrointestinalDisease
                        {
                            GastrointestinalDiseaseId = itm.GastrointestinalDiseaseId,
                            GastrointestinalDiseaseName = itm.GastrointestinalDiseaseName
                        };
                        entities.Add(entity);
                        db.GastrointestinalDiseasis.Attach(entity);
                        db.GastrointestinalDiseasis.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new GastrointestinalDisease
            {
                GastrointestinalDiseaseId = itm.GastrointestinalDiseaseId,
                GastrointestinalDiseaseName = itm.GastrointestinalDiseaseName
            }));
        }
        #endregion

        #region Gender
        public ActionResult Gender()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeGender = "active";
            return View();
        }
        public ActionResult GenderRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Gender> item = db.Genders;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult GenderCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Gender> item)
        {
            var entities = new List<Gender>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Gender
                        {
                            GenderName = itm.GenderName,
                        };
                        db.Genders.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Gender
            {
                GenderId = product.GenderId,
                GenderName = product.GenderName
            }));
        }
        public ActionResult GenderUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Gender> item)
        {
            var entities = new List<Gender>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Gender
                        {
                            GenderId = itm.GenderId,
                            GenderName = itm.GenderName
                        };
                        entities.Add(entity);
                        db.Genders.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Gender
            {
                GenderId = itm.GenderId,
                GenderName = itm.GenderName
            }));
        }
        public ActionResult GenderDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Gender> item)
        {
            var entities = new List<Gender>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Gender
                        {
                            GenderId = itm.GenderId,
                            GenderName = itm.GenderName
                        };
                        entities.Add(entity);
                        db.Genders.Attach(entity);
                        db.Genders.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Gender
            {
                GenderId = itm.GenderId,
                GenderName = itm.GenderName
            }));
        }
        #endregion

        #region HBCriteria
        public ActionResult HBCriteria()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHBCriteria = "active";
            return View();
        }
        public ActionResult HBCriteriaRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HBCriteria> item = db.HBCriterias;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HBCriteriaCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBCriteria> item)
        {
            var entities = new List<HBCriteria>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBCriteria
                        {
                            HBCriteriaName = itm.HBCriteriaName,
                        };
                        db.HBCriterias.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HBCriteria
            {
                HBCriteriaId = product.HBCriteriaId,
                HBCriteriaName = product.HBCriteriaName
            }));
        }
        public ActionResult HBCriteriaUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBCriteria> item)
        {
            var entities = new List<HBCriteria>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBCriteria
                        {
                            HBCriteriaId = itm.HBCriteriaId,
                            HBCriteriaName = itm.HBCriteriaName
                        };
                        entities.Add(entity);
                        db.HBCriterias.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HBCriteria
            {
                HBCriteriaId = itm.HBCriteriaId,
                HBCriteriaName = itm.HBCriteriaName
            }));
        }
        public ActionResult HBCriteriaDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBCriteria> item)
        {
            var entities = new List<HBCriteria>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBCriteria
                        {
                            HBCriteriaId = itm.HBCriteriaId,
                            HBCriteriaName = itm.HBCriteriaName
                        };
                        entities.Add(entity);
                        db.HBCriterias.Attach(entity);
                        db.HBCriterias.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HBCriteria
            {
                HBCriteriaId = itm.HBCriteriaId,
                HBCriteriaName = itm.HBCriteriaName
            }));
        }
        #endregion

        #region HBSStatus
        public ActionResult HBSStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHBSStatus = "active";
            return View();
        }
        public ActionResult HBSStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HBSStatus> item = db.HBSStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HBSStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBSStatus> item)
        {
            var entities = new List<HBSStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBSStatus
                        {
                            HBSStatusName = itm.HBSStatusName,
                        };
                        db.HBSStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HBSStatus
            {
                HBSStatusId = product.HBSStatusId,
                HBSStatusName = product.HBSStatusName
            }));
        }
        public ActionResult HBSStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBSStatus> item)
        {
            var entities = new List<HBSStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBSStatus
                        {
                            HBSStatusId = itm.HBSStatusId,
                            HBSStatusName = itm.HBSStatusName
                        };
                        entities.Add(entity);
                        db.HBSStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HBSStatus
            {
                HBSStatusId = itm.HBSStatusId,
                HBSStatusName = itm.HBSStatusName
            }));
        }
        public ActionResult HBSStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HBSStatus> item)
        {
            var entities = new List<HBSStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HBSStatus
                        {
                            HBSStatusId = itm.HBSStatusId,
                            HBSStatusName = itm.HBSStatusName
                        };
                        entities.Add(entity);
                        db.HBSStatuses.Attach(entity);
                        db.HBSStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HBSStatus
            {
                HBSStatusId = itm.HBSStatusId,
                HBSStatusName = itm.HBSStatusName
            }));
        }
        #endregion

        #region HCVStatus
        public ActionResult HCVStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHCVStatus = "active";
            return View();
        }
        public ActionResult HCVStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HCVStatus> item = db.HCVStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HCVStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HCVStatus> item)
        {
            var entities = new List<HCVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HCVStatus
                        {
                            HCVStatusName = itm.HCVStatusName,
                        };
                        db.HCVStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HCVStatus
            {
                HCVStatusId = product.HCVStatusId,
                HCVStatusName = product.HCVStatusName
            }));
        }
        public ActionResult HCVStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HCVStatus> item)
        {
            var entities = new List<HCVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HCVStatus
                        {
                            HCVStatusId = itm.HCVStatusId,
                            HCVStatusName = itm.HCVStatusName
                        };
                        entities.Add(entity);
                        db.HCVStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HCVStatus
            {
                HCVStatusId = itm.HCVStatusId,
                HCVStatusName = itm.HCVStatusName
            }));
        }
        public ActionResult HCVStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HCVStatus> item)
        {
            var entities = new List<HCVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HCVStatus
                        {
                            HCVStatusId = itm.HCVStatusId,
                            HCVStatusName = itm.HCVStatusName
                        };
                        entities.Add(entity);
                        db.HCVStatuses.Attach(entity);
                        db.HCVStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HCVStatus
            {
                HCVStatusId = itm.HCVStatusId,
                HCVStatusName = itm.HCVStatusName
            }));
        }
        #endregion

        #region HeartMurmurType
        public ActionResult HeartMurmurType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHeartMurmurType = "active";
            return View();
        }
        public ActionResult HeartMurmurTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HeartMurmurType> item = db.HeartMurmurTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HeartMurmurTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartMurmurType> item)
        {
            var entities = new List<HeartMurmurType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartMurmurType
                        {
                            HeartMurmurTypeName = itm.HeartMurmurTypeName,
                        };
                        db.HeartMurmurTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HeartMurmurType
            {
                HeartMurmurTypeId = product.HeartMurmurTypeId,
                HeartMurmurTypeName = product.HeartMurmurTypeName
            }));
        }
        public ActionResult HeartMurmurTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartMurmurType> item)
        {
            var entities = new List<HeartMurmurType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartMurmurType
                        {
                            HeartMurmurTypeId = itm.HeartMurmurTypeId,
                            HeartMurmurTypeName = itm.HeartMurmurTypeName
                        };
                        entities.Add(entity);
                        db.HeartMurmurTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HeartMurmurType
            {
                HeartMurmurTypeId = itm.HeartMurmurTypeId,
                HeartMurmurTypeName = itm.HeartMurmurTypeName
            }));
        }
        public ActionResult HeartMurmurTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartMurmurType> item)
        {
            var entities = new List<HeartMurmurType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartMurmurType
                        {
                            HeartMurmurTypeId = itm.HeartMurmurTypeId,
                            HeartMurmurTypeName = itm.HeartMurmurTypeName
                        };
                        entities.Add(entity);
                        db.HeartMurmurTypes.Attach(entity);
                        db.HeartMurmurTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HeartMurmurType
            {
                HeartMurmurTypeId = itm.HeartMurmurTypeId,
                HeartMurmurTypeName = itm.HeartMurmurTypeName
            }));
        }
        #endregion

        #region HeartSoundType
        public ActionResult HeartSoundType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHeartSoundType = "active";
            return View();
        }
        public ActionResult HeartSoundTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HeartSoundType> item = db.HeartSoundTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HeartSoundTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartSoundType> item)
        {
            var entities = new List<HeartSoundType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartSoundType
                        {
                            HeartSoundTypeName = itm.HeartSoundTypeName,
                        };
                        db.HeartSoundTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HeartSoundType
            {
                HeartSoundTypeId = product.HeartSoundTypeId,
                HeartSoundTypeName = product.HeartSoundTypeName
            }));
        }
        public ActionResult HeartSoundTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartSoundType> item)
        {
            var entities = new List<HeartSoundType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartSoundType
                        {
                            HeartSoundTypeId = itm.HeartSoundTypeId,
                            HeartSoundTypeName = itm.HeartSoundTypeName
                        };
                        entities.Add(entity);
                        db.HeartSoundTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HeartSoundType
            {
                HeartSoundTypeId = itm.HeartSoundTypeId,
                HeartSoundTypeName = itm.HeartSoundTypeName
            }));
        }
        public ActionResult HeartSoundTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HeartSoundType> item)
        {
            var entities = new List<HeartSoundType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HeartSoundType
                        {
                            HeartSoundTypeId = itm.HeartSoundTypeId,
                            HeartSoundTypeName = itm.HeartSoundTypeName
                        };
                        entities.Add(entity);
                        db.HeartSoundTypes.Attach(entity);
                        db.HeartSoundTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HeartMurmurType
            {
                HeartMurmurTypeId = itm.HeartSoundTypeId,
                HeartMurmurTypeName = itm.HeartSoundTypeName
            }));
        }
        #endregion

        #region HIT
        public ActionResult HIT()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHIT = "active";
            return View();
        }
        public ActionResult HITRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HIT> item = db.HITS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HITCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIT> item)
        {
            var entities = new List<HIT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIT
                        {
                            HITName = itm.HITName,
                        };
                        db.HITS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HIT
            {
                HITId = product.HITId,
                HITName = product.HITName
            }));
        }
        public ActionResult HITUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIT> item)
        {
            var entities = new List<HIT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIT
                        {
                            HITId = itm.HITId,
                            HITName = itm.HITName
                        };
                        entities.Add(entity);
                        db.HITS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HIT
            {
                HITId = itm.HITId,
                HITName = itm.HITName
            }));
        }
        public ActionResult HITDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIT> item)
        {
            var entities = new List<HIT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIT
                        {
                            HITId = itm.HITId,
                            HITName = itm.HITName
                        };
                        entities.Add(entity);
                        db.HITS.Attach(entity);
                        db.HITS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HIT
            {
                HITId = itm.HITId,
                HITName = itm.HITName
            }));
        }
        #endregion

        #region HIVStatus
        public ActionResult HIVStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHIVStatus = "active";
            return View();
        }
        public ActionResult HIVStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HIVStatus> item = db.HIVStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HIVStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIVStatus> item)
        {
            var entities = new List<HIVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIVStatus
                        {
                            HIVStatusName = itm.HIVStatusName,
                        };
                        db.HIVStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HIVStatus
            {
                HIVStatusId = product.HIVStatusId,
                HIVStatusName = product.HIVStatusName
            }));
        }
        public ActionResult HIVStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIVStatus> item)
        {
            var entities = new List<HIVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIVStatus
                        {
                            HIVStatusId = itm.HIVStatusId,
                            HIVStatusName = itm.HIVStatusName
                        };
                        entities.Add(entity);
                        db.HIVStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HIVStatus
            {
                HIVStatusId = itm.HIVStatusId,
                HIVStatusName = itm.HIVStatusName
            }));
        }
        public ActionResult HIVStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HIVStatus> item)
        {
            var entities = new List<HIVStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HIVStatus
                        {
                            HIVStatusId = itm.HIVStatusId,
                            HIVStatusName = itm.HIVStatusName
                        };
                        entities.Add(entity);
                        db.HIVStatuses.Attach(entity);
                        db.HIVStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HIVStatus
            {
                HIVStatusId = itm.HIVStatusId,
                HIVStatusName = itm.HIVStatusName
            }));
        }
        #endregion

        #region HVD
        public ActionResult HVD()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHVD = "active";
            return View();
        }
        public ActionResult HVDRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HVD> item = db.HVDS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HVDCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HVD> item)
        {
            var entities = new List<HVD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HVD
                        {
                            HVDName = itm.HVDName,
                        };
                        db.HVDS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HVD
            {
                HVDId = product.HVDId,
                HVDName = product.HVDName
            }));
        }
        public ActionResult HVDUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HVD> item)
        {
            var entities = new List<HVD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HVD
                        {
                            HVDId = itm.HVDId,
                            HVDName = itm.HVDName
                        };
                        entities.Add(entity);
                        db.HVDS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HVD
            {
                HVDId = itm.HVDId,
                HVDName = itm.HVDName
            }));
        }
        public ActionResult HVDDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HVD> item)
        {
            var entities = new List<HVD>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HVD
                        {
                            HVDId = itm.HVDId,
                            HVDName = itm.HVDName
                        };
                        entities.Add(entity);
                        db.HVDS.Attach(entity);
                        db.HVDS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HVD
            {
                HVDId = itm.HVDId,
                HVDName = itm.HVDName
            }));
        }
        #endregion

        #region HypertensionDuration
        public ActionResult HypertensionDuration()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeHypertensionDuration = "active";
            return View();
        }
        public ActionResult HypertensionDurationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<HypertensionDuration> item = db.HypertensionDurations;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult HypertensionDurationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HypertensionDuration> item)
        {
            var entities = new List<HypertensionDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HypertensionDuration
                        {
                            HypertensionDurationName = itm.HypertensionDurationName,
                        };
                        db.HypertensionDurations.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new HypertensionDuration
            {
                HypertensionDurationId = product.HypertensionDurationId,
                HypertensionDurationName = product.HypertensionDurationName
            }));
        }
        public ActionResult HypertensionDurationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HypertensionDuration> item)
        {
            var entities = new List<HypertensionDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HypertensionDuration
                        {
                            HypertensionDurationId = itm.HypertensionDurationId,
                            HypertensionDurationName = itm.HypertensionDurationName
                        };
                        entities.Add(entity);
                        db.HypertensionDurations.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HypertensionDuration
            {
                HypertensionDurationId = itm.HypertensionDurationId,
                HypertensionDurationName = itm.HypertensionDurationName
            }));
        }
        public ActionResult HypertensionDurationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<HypertensionDuration> item)
        {
            var entities = new List<HypertensionDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new HypertensionDuration
                        {
                            HypertensionDurationId = itm.HypertensionDurationId,
                            HypertensionDurationName = itm.HypertensionDurationName
                        };
                        entities.Add(entity);
                        db.HypertensionDurations.Attach(entity);
                        db.HypertensionDurations.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new HypertensionDuration
            {
                HypertensionDurationId = itm.HypertensionDurationId,
                HypertensionDurationName = itm.HypertensionDurationName
            }));
        }
        #endregion

        #region ImmunologicalStatus
        public ActionResult ImmunologicalStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeImmunologicalStatus = "active";
            return View();
        }
        public ActionResult ImmunologicalStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ImmunologicalStatus> item = db.ImmunologicalStatusis;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ImmunologicalStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImmunologicalStatus> item)
        {
            var entities = new List<ImmunologicalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImmunologicalStatus
                        {
                            ImmunologicalStatusName = itm.ImmunologicalStatusName,
                        };
                        db.ImmunologicalStatusis.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ImmunologicalStatus
            {
                ImmunologicalStatusId = product.ImmunologicalStatusId,
                ImmunologicalStatusName = product.ImmunologicalStatusName
            }));
        }
        public ActionResult ImmunologicalStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImmunologicalStatus> item)
        {
            var entities = new List<ImmunologicalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImmunologicalStatus
                        {
                            ImmunologicalStatusId = itm.ImmunologicalStatusId,
                            ImmunologicalStatusName = itm.ImmunologicalStatusName
                        };
                        entities.Add(entity);
                        db.ImmunologicalStatusis.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ImmunologicalStatus
            {
                ImmunologicalStatusId = itm.ImmunologicalStatusId,
                ImmunologicalStatusName = itm.ImmunologicalStatusName
            }));
        }
        public ActionResult ImmunologicalStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImmunologicalStatus> item)
        {
            var entities = new List<ImmunologicalStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImmunologicalStatus
                        {
                            ImmunologicalStatusId = itm.ImmunologicalStatusId,
                            ImmunologicalStatusName = itm.ImmunologicalStatusName
                        };
                        entities.Add(entity);
                        db.ImmunologicalStatusis.Attach(entity);
                        db.ImmunologicalStatusis.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ImmunologicalStatus
            {
                ImmunologicalStatusId = itm.ImmunologicalStatusId,
                ImmunologicalStatusName = itm.ImmunologicalStatusName
            }));
        }
        #endregion

        #region Implant
        public ActionResult Implant()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeImplant = "active";
            return View();
        }
        public ActionResult ImplantRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Implant> item = db.Implants;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ImplantCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Implant> item)
        {
            var entities = new List<Implant>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Implant
                        {
                            ImplantName = itm.ImplantName,
                        };
                        db.Implants.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Implant
            {
                ImplantId = product.ImplantId,
                ImplantName = product.ImplantName
            }));
        }
        public ActionResult ImplantUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Implant> item)
        {
            var entities = new List<Implant>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Implant
                        {
                            ImplantId = itm.ImplantId,
                            ImplantName = itm.ImplantName
                        };
                        entities.Add(entity);
                        db.Implants.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Implant
            {
                ImplantId = itm.ImplantId,
                ImplantName = itm.ImplantName
            }));
        }
        public ActionResult ImplantDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Implant> item)
        {
            var entities = new List<Implant>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Implant
                        {
                            ImplantId = itm.ImplantId,
                            ImplantName = itm.ImplantName
                        };
                        entities.Add(entity);
                        db.Implants.Attach(entity);
                        db.Implants.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Implant
            {
                ImplantId = itm.ImplantId,
                ImplantName = itm.ImplantName
            }));
        }
        #endregion

        #region ImplantSize
        public ActionResult ImplantSize()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeImplantSize = "active";
            return View();
        }
        public ActionResult ImplantSizeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ImplantSize> item = db.ImplantSizes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ImplantSizeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImplantSize> item)
        {
            var entities = new List<ImplantSize>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImplantSize
                        {
                            ImplantSizeName = itm.ImplantSizeName,
                        };
                        db.ImplantSizes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ImplantSize
            {
                ImplantSizeId = product.ImplantSizeId,
                ImplantSizeName = product.ImplantSizeName
            }));
        }
        public ActionResult ImplantSizeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImplantSize> item)
        {
            var entities = new List<ImplantSize>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImplantSize
                        {
                            ImplantSizeId = itm.ImplantSizeId,
                            ImplantSizeName = itm.ImplantSizeName
                        };
                        entities.Add(entity);
                        db.ImplantSizes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ImplantSize
            {
                ImplantSizeId = itm.ImplantSizeId,
                ImplantSizeName = itm.ImplantSizeName
            }));
        }
        public ActionResult ImplantSizeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ImplantSize> item)
        {
            var entities = new List<ImplantSize>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ImplantSize
                        {
                            ImplantSizeId = itm.ImplantSizeId,
                            ImplantSizeName = itm.ImplantSizeName
                        };
                        entities.Add(entity);
                        db.ImplantSizes.Attach(entity);
                        db.ImplantSizes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ImplantSize
            {
                ImplantSizeId = itm.ImplantSizeId,
                ImplantSizeName = itm.ImplantSizeName
            }));
        }
        #endregion

        #region InfectiousEndocarditis
        public ActionResult InfectiousEndocarditis()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeInfectiousEndocarditis = "active";
            return View();
        }
        public ActionResult InfectiousEndocarditisRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<InfectiousEndocarditis> item = db.InfectiousEndocarditisis;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult InfectiousEndocarditisCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InfectiousEndocarditis> item)
        {
            var entities = new List<InfectiousEndocarditis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InfectiousEndocarditis
                        {
                            InfectiousEndocarditisName = itm.InfectiousEndocarditisName,
                        };
                        db.InfectiousEndocarditisis.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new InfectiousEndocarditis
            {
                InfectiousEndocarditisId = product.InfectiousEndocarditisId,
                InfectiousEndocarditisName = product.InfectiousEndocarditisName
            }));
        }
        public ActionResult InfectiousEndocarditisUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InfectiousEndocarditis> item)
        {
            var entities = new List<InfectiousEndocarditis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InfectiousEndocarditis
                        {
                            InfectiousEndocarditisId = itm.InfectiousEndocarditisId,
                            InfectiousEndocarditisName = itm.InfectiousEndocarditisName
                        };
                        entities.Add(entity);
                        db.InfectiousEndocarditisis.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new InfectiousEndocarditis
            {
                InfectiousEndocarditisId = itm.InfectiousEndocarditisId,
                InfectiousEndocarditisName = itm.InfectiousEndocarditisName
            }));
        }
        public ActionResult InfectiousEndocarditisDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InfectiousEndocarditis> item)
        {
            var entities = new List<InfectiousEndocarditis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InfectiousEndocarditis
                        {
                            InfectiousEndocarditisId = itm.InfectiousEndocarditisId,
                            InfectiousEndocarditisName = itm.InfectiousEndocarditisName
                        };
                        entities.Add(entity);
                        db.InfectiousEndocarditisis.Attach(entity);
                        db.InfectiousEndocarditisis.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new InfectiousEndocarditis
            {
                InfectiousEndocarditisId = itm.InfectiousEndocarditisId,
                InfectiousEndocarditisName = itm.InfectiousEndocarditisName
            }));
        }
        #endregion

        #region InotropicSupport
        public ActionResult InotropicSupport()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeInotropicSupport = "active";
            return View();
        }
        public ActionResult InotropicSupportRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<InotropicSupport> item = db.InotropicSupports;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult InotropicSupportCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InotropicSupport> item)
        {
            var entities = new List<InotropicSupport>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InotropicSupport
                        {
                            InotropicSupportName = itm.InotropicSupportName,
                        };
                        db.InotropicSupports.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new InotropicSupport
            {
                InotropicSupportId = product.InotropicSupportId,
                InotropicSupportName = product.InotropicSupportName
            }));
        }
        public ActionResult InotropicSupportUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InotropicSupport> item)
        {
            var entities = new List<InotropicSupport>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InotropicSupport
                        {
                            InotropicSupportId = itm.InotropicSupportId,
                            InotropicSupportName = itm.InotropicSupportName
                        };
                        entities.Add(entity);
                        db.InotropicSupports.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new InotropicSupport
            {
                InotropicSupportId = itm.InotropicSupportId,
                InotropicSupportName = itm.InotropicSupportName
            }));
        }
        public ActionResult InotropicSupportDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<InotropicSupport> item)
        {
            var entities = new List<InotropicSupport>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new InotropicSupport
                        {
                            InotropicSupportId = itm.InotropicSupportId,
                            InotropicSupportName = itm.InotropicSupportName
                        };
                        entities.Add(entity);
                        db.InotropicSupports.Attach(entity);
                        db.InotropicSupports.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new InotropicSupport
            {
                InotropicSupportId = itm.InotropicSupportId,
                InotropicSupportName = itm.InotropicSupportName
            }));
        }
        #endregion

        #region Insufficiency
        public ActionResult Insufficiency()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeInsufficiency = "active";
            return View();
        }
        public ActionResult InsufficiencyRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Insufficiency> item = db.Insufficiencyes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult InsufficiencyCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Insufficiency> item)
        {
            var entities = new List<Insufficiency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Insufficiency
                        {
                            InsufficiencyName = itm.InsufficiencyName,
                        };
                        db.Insufficiencyes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Insufficiency
            {
                InsufficiencyId = product.InsufficiencyId,
                InsufficiencyName = product.InsufficiencyName
            }));
        }
        public ActionResult InsufficiencyUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Insufficiency> item)
        {
            var entities = new List<Insufficiency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Insufficiency
                        {
                            InsufficiencyId = itm.InsufficiencyId,
                            InsufficiencyName = itm.InsufficiencyName
                        };
                        entities.Add(entity);
                        db.Insufficiencyes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Insufficiency
            {
                InsufficiencyId = itm.InsufficiencyId,
                InsufficiencyName = itm.InsufficiencyName
            }));
        }
        public ActionResult InsufficiencyDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Insufficiency> item)
        {
            var entities = new List<Insufficiency>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Insufficiency
                        {
                            InsufficiencyId = itm.InsufficiencyId,
                            InsufficiencyName = itm.InsufficiencyName
                        };
                        entities.Add(entity);
                        db.Insufficiencyes.Attach(entity);
                        db.Insufficiencyes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Insufficiency
            {
                InsufficiencyId = itm.InsufficiencyId,
                InsufficiencyName = itm.InsufficiencyName
            }));
        }
        #endregion

        #region Invasion
        public ActionResult Invasion()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeInvasion = "active";
            return View();
        }
        public ActionResult InvasionRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Invasion> item = db.Invasions;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult InvasionCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Invasion> item)
        {
            var entities = new List<Invasion>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Invasion
                        {
                            InvasionName = itm.InvasionName,
                        };
                        db.Invasions.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Invasion
            {
                InvasionId = product.InvasionId,
                InvasionName = product.InvasionName
            }));
        }
        public ActionResult InvasionUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Invasion> item)
        {
            var entities = new List<Invasion>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Invasion
                        {
                            InvasionId = itm.InvasionId,
                            InvasionName = itm.InvasionName
                        };
                        entities.Add(entity);
                        db.Invasions.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Invasion
            {
                InvasionId = itm.InvasionId,
                InvasionName = itm.InvasionName
            }));
        }
        public ActionResult InvasionDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Invasion> item)
        {
            var entities = new List<Invasion>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Invasion
                        {
                            InvasionId = itm.InvasionId,
                            InvasionName = itm.InvasionName
                        };
                        entities.Add(entity);
                        db.Invasions.Attach(entity);
                        db.Invasions.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Invasion
            {
                InvasionId = itm.InvasionId,
                InvasionName = itm.InvasionName
            }));
        }
        #endregion

        #region Laun
        public ActionResult Laun()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeLaun = "active";
            return View();
        }
        public ActionResult LaunRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Laun> item = db.Launs;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult LaunCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Laun> item)
        {
            var entities = new List<Laun>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Laun
                        {
                            LaunName = itm.LaunName,
                        };
                        db.Launs.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Laun
            {
                LaunId = product.LaunId,
                LaunName = product.LaunName
            }));
        }
        public ActionResult LaunUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Laun> item)
        {
            var entities = new List<Laun>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Laun
                        {
                            LaunId = itm.LaunId,
                            LaunName = itm.LaunName
                        };
                        entities.Add(entity);
                        db.Launs.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Laun
            {
                LaunId = itm.LaunId,
                LaunName = itm.LaunName
            }));
        }
        public ActionResult LaunDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Laun> item)
        {
            var entities = new List<Laun>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Laun
                        {
                            LaunId = itm.LaunId,
                            LaunName = itm.LaunName
                        };
                        entities.Add(entity);
                        db.Launs.Attach(entity);
                        db.Launs.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Laun
            {
                LaunId = itm.LaunId,
                LaunName = itm.LaunName
            }));
        }
        #endregion

        #region LesionType
        public ActionResult LesionType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeLesionType = "active";
            return View();
        }
        public ActionResult LesionTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<LesionType> item = db.LesionTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult LesionTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LesionType> item)
        {
            var entities = new List<LesionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new LesionType
                        {
                            LesionTypeName = itm.LesionTypeName,
                        };
                        db.LesionTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new LesionType
            {
                LesionTypeId = product.LesionTypeId,
                LesionTypeName = product.LesionTypeName
            }));
        }
        public ActionResult LesionTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LesionType> item)
        {
            var entities = new List<LesionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new LesionType
                        {
                            LesionTypeId = itm.LesionTypeId,
                            LesionTypeName = itm.LesionTypeName
                        };
                        entities.Add(entity);
                        db.LesionTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new LesionType
            {
                LesionTypeId = itm.LesionTypeId,
                LesionTypeName = itm.LesionTypeName
            }));
        }
        public ActionResult LesionTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LesionType> item)
        {
            var entities = new List<LesionType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new LesionType
                        {
                            LesionTypeId = itm.LesionTypeId,
                            LesionTypeName = itm.LesionTypeName
                        };
                        entities.Add(entity);
                        db.LesionTypes.Attach(entity);
                        db.LesionTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new LesionType
            {
                LesionTypeId = itm.LesionTypeId,
                LesionTypeName = itm.LesionTypeName
            }));
        }
        #endregion

        #region Liquid
        public ActionResult Liquid()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeLiquid = "active";
            return View();
        }
        public ActionResult LiquidRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Liquid> item = db.Liquids;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult LiquidCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liquid> item)
        {
            var entities = new List<Liquid>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liquid
                        {
                            LiquidName = itm.LiquidName,
                        };
                        db.Liquids.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Liquid
            {
                LiquidId = product.LiquidId,
                LiquidName = product.LiquidName
            }));
        }
        public ActionResult LiquidUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liquid> item)
        {
            var entities = new List<Liquid>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liquid
                        {
                            LiquidId = itm.LiquidId,
                            LiquidName = itm.LiquidName
                        };
                        entities.Add(entity);
                        db.Liquids.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Liquid
            {
                LiquidId = itm.LiquidId,
                LiquidName = itm.LiquidName
            }));
        }
        public ActionResult LiquidDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liquid> item)
        {
            var entities = new List<Liquid>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liquid
                        {
                            LiquidId = itm.LiquidId,
                            LiquidName = itm.LiquidName
                        };
                        entities.Add(entity);
                        db.Liquids.Attach(entity);
                        db.Liquids.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Liquid 
            {
                LiquidId = itm.LiquidId,
                LiquidName = itm.LiquidName
            }));
        }
        #endregion

        #region Liver
        public ActionResult Liver()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeLiver = "active";
            return View();
        }
        public ActionResult LiverRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Liver> item = db.Livers;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult LiverCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liver> item)
        {
            var entities = new List<Liver>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liver
                        {
                            LiverName = itm.LiverName,
                        };
                        db.Livers.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Liver
            {
                LiverId = product.LiverId,
                LiverName = product.LiverName
            }));
        }
        public ActionResult LiverUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liver> item)
        {
            var entities = new List<Liver>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liver
                        {
                            LiverId = itm.LiverId,
                            LiverName = itm.LiverName
                        };
                        entities.Add(entity);
                        db.Livers.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Liver
            {
                LiverId = itm.LiverId,
                LiverName = itm.LiverName
            }));
        }
        public ActionResult LiverDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Liver> item)
        {
            var entities = new List<Liver>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Liver
                        {
                            LiverId = itm.LiverId,
                            LiverName = itm.LiverName
                        };
                        entities.Add(entity);
                        db.Livers.Attach(entity);
                        db.Livers.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Liver
            {
                LiverId = itm.LiverId,
                LiverName = itm.LiverName
            }));
        }
        #endregion

        #region Lung
        public ActionResult Lung()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeLung = "active";
            return View();
        }
        public ActionResult LungRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Lung> item = db.Lungs;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult LungCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Lung> item)
        {
            var entities = new List<Lung>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Lung
                        {
                            LungName = itm.LungName,
                        };
                        db.Lungs.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Lung
            {
                LungId = product.LungId,
                LungName = product.LungName
            }));
        }
        public ActionResult LungUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Lung> item)
        {
            var entities = new List<Lung>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Lung
                        {
                            LungId = itm.LungId,
                            LungName = itm.LungName
                        };
                        entities.Add(entity);
                        db.Lungs.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Lung
            {
                LungId = itm.LungId,
                LungName = itm.LungName
            }));
        }
        public ActionResult LungDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Lung> item)
        {
            var entities = new List<Lung>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Lung
                        {
                            LungId = itm.LungId,
                            LungName = itm.LungName
                        };
                        entities.Add(entity);
                        db.Lungs.Attach(entity);
                        db.Lungs.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Lung
            {
                LungId = itm.LungId,
                LungName = itm.LungName
            }));
        }
        #endregion

        #region MedicalProcedure
        public ActionResult MedicalProcedure()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeMedicalProcedure = "active";
            return View();
        }
        public ActionResult MedicalProcedureRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<MedicalProcedure> item = db.MedicalProcedures;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult MedicalProcedureCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MedicalProcedure> item)
        {
            var entities = new List<MedicalProcedure>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MedicalProcedure
                        {
                            MedicalProcedureName = itm.MedicalProcedureName,
                        };
                        db.MedicalProcedures.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new MedicalProcedure
            {
                MedicalProcedureId = product.MedicalProcedureId,
                MedicalProcedureName = product.MedicalProcedureName
            }));
        }
        public ActionResult MedicalProcedureUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MedicalProcedure> item)
        {
            var entities = new List<MedicalProcedure>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MedicalProcedure
                        {
                            MedicalProcedureId = itm.MedicalProcedureId,
                            MedicalProcedureName = itm.MedicalProcedureName
                        };
                        entities.Add(entity);
                        db.MedicalProcedures.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MedicalProcedure
            {
                MedicalProcedureId = itm.MedicalProcedureId,
                MedicalProcedureName = itm.MedicalProcedureName
            }));
        }
        public ActionResult MedicalProcedureDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MedicalProcedure> item)
        {
            var entities = new List<MedicalProcedure>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MedicalProcedure
                        {
                            MedicalProcedureId = itm.MedicalProcedureId,
                            MedicalProcedureName = itm.MedicalProcedureName
                        };
                        entities.Add(entity);
                        db.MedicalProcedures.Attach(entity);
                        db.MedicalProcedures.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MedicalProcedure
            {
                MedicalProcedureId = itm.MedicalProcedureId,
                MedicalProcedureName = itm.MedicalProcedureName
            }));
        }
        #endregion

        #region MortalityType
        public ActionResult MortalityType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeMortalityType = "active";
            return View();
        }
        public ActionResult MortalityTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<MortalityType> item = db.MortalityTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult MortalityTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MortalityType> item)
        {
            var entities = new List<MortalityType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MortalityType
                        {
                            MortalityTypeName = itm.MortalityTypeName,
                        };
                        db.MortalityTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new MortalityType
            {
                MortalityTypeId = product.MortalityTypeId,
                MortalityTypeName = product.MortalityTypeName
            }));
        }
        public ActionResult MortalityTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MortalityType> item)
        {
            var entities = new List<MortalityType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MortalityType
                        {
                            MortalityTypeId = itm.MortalityTypeId,
                            MortalityTypeName = itm.MortalityTypeName
                        };
                        entities.Add(entity);
                        db.MortalityTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MortalityType
            {
                MortalityTypeId = itm.MortalityTypeId,
                MortalityTypeName = itm.MortalityTypeName
            }));
        }
        public ActionResult MortalityTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MortalityType> item)
        {
            var entities = new List<MortalityType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MortalityType
                        {
                            MortalityTypeId = itm.MortalityTypeId,
                            MortalityTypeName = itm.MortalityTypeName
                        };
                        entities.Add(entity);
                        db.MortalityTypes.Attach(entity);
                        db.MortalityTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MortalityType
            {
                MortalityTypeId = itm.MortalityTypeId,
                MortalityTypeName = itm.MortalityTypeName
            }));
        }
        #endregion

        #region MovementStatus
        public ActionResult MovementStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeMovementStatus = "active";
            return View();
        }
        public ActionResult MovementStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<MovementStatus> item = db.MovementStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult MovementStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MovementStatus> item)
        {
            var entities = new List<MovementStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MovementStatus
                        {
                            MovementStatusName = itm.MovementStatusName,
                        };
                        db.MovementStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new MovementStatus
            {
                MovementStatusId = product.MovementStatusId,
                MovementStatusName = product.MovementStatusName
            }));
        }
        public ActionResult MovementStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MovementStatus> item)
        {
            var entities = new List<MovementStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MovementStatus
                        {
                            MovementStatusId = itm.MovementStatusId,
                            MovementStatusName = itm.MovementStatusName
                        };
                        entities.Add(entity);
                        db.MovementStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MovementStatus
            {
                MovementStatusId = itm.MovementStatusId,
                MovementStatusName = itm.MovementStatusName
            }));
        }
        public ActionResult MovementStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<MovementStatus> item)
        {
            var entities = new List<MovementStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new MovementStatus
                        {
                            MovementStatusId = itm.MovementStatusId,
                            MovementStatusName = itm.MovementStatusName
                        };
                        entities.Add(entity);
                        db.MovementStatuses.Attach(entity);
                        db.MovementStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new MovementStatus
            {
                MovementStatusId = itm.MovementStatusId,
                MovementStatusName = itm.MovementStatusName
            }));
        }
        #endregion

        #region NYHA
        public ActionResult NYHA()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeNYHA = "active";
            return View();
        }
        public ActionResult NYHARead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<NYHA> item = db.NYHAS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult NYHACreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<NYHA> item)
        {
            var entities = new List<NYHA>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new NYHA
                        {
                            NYHAName = itm.NYHAName,
                        };
                        db.NYHAS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new NYHA
            {
                NYHAId = product.NYHAId,
                NYHAName = product.NYHAName
            }));
        }
        public ActionResult NYHAUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<NYHA> item)
        {
            var entities = new List<NYHA>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new NYHA
                        {
                            NYHAId = itm.NYHAId,
                            NYHAName = itm.NYHAName
                        };
                        entities.Add(entity);
                        db.NYHAS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new NYHA
            {
                NYHAId = itm.NYHAId,
                NYHAName = itm.NYHAName
            }));
        }
        public ActionResult NYHADestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<NYHA> item)
        {
            var entities = new List<NYHA>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new NYHA
                        {
                            NYHAId = itm.NYHAId,
                            NYHAName = itm.NYHAName
                        };
                        entities.Add(entity);
                        db.NYHAS.Attach(entity);
                        db.NYHAS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new NYHA
            {
                NYHAId = itm.NYHAId,
                NYHAName = itm.NYHAName
            }));
        }
        #endregion

        #region Organization
        public ActionResult Organization()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeOrganization = "active";
            return View();
        }
        public ActionResult OrganizationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Organization> item = db.Organizations;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult OrganizationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Organization> item)
        {
            var entities = new List<Organization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Organization
                        {
                            OrganizationName = itm.OrganizationName,
                        };
                        db.Organizations.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Organization
            {
                OrganizationId = product.OrganizationId,
                OrganizationName = product.OrganizationName
            }));
        }
        public ActionResult OrganizationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Organization> item)
        {
            var entities = new List<Organization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Organization
                        {
                            OrganizationId = itm.OrganizationId,
                            OrganizationName = itm.OrganizationName
                        };
                        entities.Add(entity);
                        db.Organizations.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Organization
            {
                OrganizationId = itm.OrganizationId,
                OrganizationName = itm.OrganizationName
            }));
        }
        public ActionResult OrganizationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Organization> item)
        {
            var entities = new List<Organization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Organization
                        {
                            OrganizationId = itm.OrganizationId,
                            OrganizationName = itm.OrganizationName
                        };
                        entities.Add(entity);
                        db.Organizations.Attach(entity);
                        db.Organizations.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Organization
            {
                OrganizationId = itm.OrganizationId,
                OrganizationName = itm.OrganizationName
            }));
        }
        #endregion

        #region OtherDisease
        public ActionResult OtherDisease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeOtherDisease = "active";
            return View();
        }
        public ActionResult OtherDiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<OtherDisease> item = db.OtherDiseases;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult OtherDiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<OtherDisease> item)
        {
            var entities = new List<OtherDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new OtherDisease
                        {
                            OtherDiseaseName = itm.OtherDiseaseName,
                        };
                        db.OtherDiseases.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new OtherDisease
            {
                OtherDiseaseId = product.OtherDiseaseId,
                OtherDiseaseName = product.OtherDiseaseName
            }));
        }
        public ActionResult OtherDiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<OtherDisease> item)
        {
            var entities = new List<OtherDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new OtherDisease
                        {
                            OtherDiseaseId = itm.OtherDiseaseId,
                            OtherDiseaseName = itm.OtherDiseaseName
                        };
                        entities.Add(entity);
                        db.OtherDiseases.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new OtherDisease
            {
                OtherDiseaseId = itm.OtherDiseaseId,
                OtherDiseaseName = itm.OtherDiseaseName
            }));
        }
        public ActionResult OtherDiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<OtherDisease> item)
        {
            var entities = new List<OtherDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new OtherDisease
                        {
                            OtherDiseaseId = itm.OtherDiseaseId,
                            OtherDiseaseName = itm.OtherDiseaseName
                        };
                        entities.Add(entity);
                        db.OtherDiseases.Attach(entity);
                        db.OtherDiseases.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new OtherDisease
            {
                OtherDiseaseId = itm.OtherDiseaseId,
                OtherDiseaseName = itm.OtherDiseaseName
            }));
        }
        #endregion

        #region PeripherialStatus
        public ActionResult OtherDiPeripherialStatussease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeOtherDiPeripherialStatussease = "active";
            return View();
        }
        public ActionResult PeripherialStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<PeripherialStatus> item = db.PeripherialStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult PeripherialStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PeripherialStatus> item)
        {
            var entities = new List<PeripherialStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PeripherialStatus
                        {
                            PeripherialStatusName = itm.PeripherialStatusName,
                        };
                        db.PeripherialStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new PeripherialStatus
            {
                PeripherialStatusId = product.PeripherialStatusId,
                PeripherialStatusName = product.PeripherialStatusName
            }));
        }
        public ActionResult PeripherialStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PeripherialStatus> item)
        {
            var entities = new List<PeripherialStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PeripherialStatus
                        {
                            PeripherialStatusId = itm.PeripherialStatusId,
                            PeripherialStatusName = itm.PeripherialStatusName
                        };
                        entities.Add(entity);
                        db.PeripherialStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PeripherialStatus
            {
                PeripherialStatusId = itm.PeripherialStatusId,
                PeripherialStatusName = itm.PeripherialStatusName
            }));
        }
        public ActionResult PeripherialStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PeripherialStatus> item)
        {
            var entities = new List<PeripherialStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PeripherialStatus
                        {
                            PeripherialStatusId = itm.PeripherialStatusId,
                            PeripherialStatusName = itm.PeripherialStatusName
                        };
                        entities.Add(entity);
                        db.PeripherialStatuses.Attach(entity);
                        db.PeripherialStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PeripherialStatus
            {
                PeripherialStatusId = itm.PeripherialStatusId,
                PeripherialStatusName = itm.PeripherialStatusName
            }));
        }
        #endregion

        #region Physician
        public ActionResult Physician()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activePhysician = "active";
            return View();
        }
        public ActionResult PhysicianRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Physician> item = db.Physicians;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult PhysicianCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Physician> item)
        {
            var entities = new List<Physician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Physician
                        {
                            PhysicianName = itm.PhysicianName,
                        };
                        db.Physicians.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Physician
            {
                PhysicianId = product.PhysicianId,
                PhysicianName = product.PhysicianName
            }));
        }
        public ActionResult PhysicianUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Physician> item)
        {
            var entities = new List<Physician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Physician
                        {
                            PhysicianId = itm.PhysicianId,
                            PhysicianName = itm.PhysicianName
                        };
                        entities.Add(entity);
                        db.Physicians.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Physician
            {
                PhysicianId = itm.PhysicianId,
                PhysicianName = itm.PhysicianName
            }));
        }
        public ActionResult PhysicianDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Physician> item)
        {
            var entities = new List<Physician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Physician
                        {
                            PhysicianId = itm.PhysicianId,
                            PhysicianName = itm.PhysicianName
                        };
                        entities.Add(entity);
                        db.Physicians.Attach(entity);
                        db.Physicians.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Physician
            {
                PhysicianId = itm.PhysicianId,
                PhysicianName = itm.PhysicianName
            }));
        }
        #endregion

        #region Profession
        public ActionResult Profession()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeProfession = "active";
            return View();
        }
        public ActionResult ProfessionRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Profession> item = db.Professions;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ProfessionCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Profession> item)
        {
            var entities = new List<Profession>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Profession
                        {
                            ProfessionName = itm.ProfessionName,
                        };
                        db.Professions.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Profession
            {
                ProfessionId = product.ProfessionId,
                ProfessionName = product.ProfessionName
            }));
        }
        public ActionResult ProfessionUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Profession> item)
        {
            var entities = new List<Profession>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Profession
                        {
                            ProfessionId = itm.ProfessionId,
                            ProfessionName = itm.ProfessionName
                        };
                        entities.Add(entity);
                        db.Professions.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Profession
            {
                ProfessionId = itm.ProfessionId,
                ProfessionName = itm.ProfessionName
            }));
        }
        public ActionResult ProfessionDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Profession> item)
        {
            var entities = new List<Profession>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Profession
                        {
                            ProfessionId = itm.ProfessionId,
                            ProfessionName = itm.ProfessionName
                        };
                        entities.Add(entity);
                        db.Professions.Attach(entity);
                        db.Professions.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Profession
            {
                ProfessionId = itm.ProfessionId,
                ProfessionName = itm.ProfessionName
            }));
        }
        #endregion

        #region Prothesis
        public ActionResult Prothesis()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeProthesis = "active";
            return View();
        }
        public ActionResult ProthesisRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Prothesis> item = db.Prothesises;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ProthesisCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Prothesis> item)
        {
            var entities = new List<Prothesis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Prothesis
                        {
                            ProthesisName = itm.ProthesisName,
                        };
                        db.Prothesises.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Prothesis
            {
                ProthesisId = product.ProthesisId,
                ProthesisName = product.ProthesisName
            }));
        }
        public ActionResult ProthesisUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Prothesis> item)
        {
            var entities = new List<Prothesis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Prothesis
                        {
                            ProthesisId = itm.ProthesisId,
                            ProthesisName = itm.ProthesisName
                        };
                        entities.Add(entity);
                        db.Prothesises.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Prothesis
            {
                ProthesisId = itm.ProthesisId,
                ProthesisName = itm.ProthesisName
            }));
        }
        public ActionResult ProthesisDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Prothesis> item)
        {
            var entities = new List<Prothesis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Prothesis
                        {
                            ProthesisId = itm.ProthesisId,
                            ProthesisName = itm.ProthesisName
                        };
                        entities.Add(entity);
                        db.Prothesises.Attach(entity);
                        db.Prothesises.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Prothesis
            {
                ProthesisId = itm.ProthesisId,
                ProthesisName = itm.ProthesisName
            }));
        }
        #endregion

        #region PulmonaryDisease
        public ActionResult PulmonaryDisease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activePulmonaryDisease = "active";
            return View();
        }
        public ActionResult PulmonaryDiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<PulmonaryDisease> item = db.PulmonaryDiseases;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult PulmonaryDiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PulmonaryDisease> item)
        {
            var entities = new List<PulmonaryDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PulmonaryDisease
                        {
                            PulmonaryDiseaseName = itm.PulmonaryDiseaseName,
                        };
                        db.PulmonaryDiseases.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new PulmonaryDisease
            {
                PulmonaryDiseaseId = product.PulmonaryDiseaseId,
                PulmonaryDiseaseName = product.PulmonaryDiseaseName
            }));
        }
        public ActionResult PulmonaryDiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PulmonaryDisease> item)
        {
            var entities = new List<PulmonaryDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PulmonaryDisease
                        {
                            PulmonaryDiseaseId = itm.PulmonaryDiseaseId,
                            PulmonaryDiseaseName = itm.PulmonaryDiseaseName
                        };
                        entities.Add(entity);
                        db.PulmonaryDiseases.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PulmonaryDisease
            {
                PulmonaryDiseaseId = itm.PulmonaryDiseaseId,
                PulmonaryDiseaseName = itm.PulmonaryDiseaseName
            }));
        }
        public ActionResult PulmonaryDiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PulmonaryDisease> item)
        {
            var entities = new List<PulmonaryDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PulmonaryDisease
                        {
                            PulmonaryDiseaseId = itm.PulmonaryDiseaseId,
                            PulmonaryDiseaseName = itm.PulmonaryDiseaseName
                        };
                        entities.Add(entity);
                        db.PulmonaryDiseases.Attach(entity);
                        db.PulmonaryDiseases.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PulmonaryDisease
            {
                PulmonaryDiseaseId = itm.PulmonaryDiseaseId,
                PulmonaryDiseaseName = itm.PulmonaryDiseaseName
            }));
        }
        #endregion

        #region PVDT
        public ActionResult PVDT()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activePVDT = "active";
            return View();
        }
        public ActionResult PVDTRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<PVDT> item = db.PVDTS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult PVDTCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PVDT> item)
        {
            var entities = new List<PVDT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PVDT
                        {
                            PVDTName = itm.PVDTName,
                        };
                        db.PVDTS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new PVDT
            {
                PVDTId = product.PVDTId,
                PVDTName = product.PVDTName
            }));
        }
        public ActionResult PVDTUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PVDT> item)
        {
            var entities = new List<PVDT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PVDT
                        {
                            PVDTId = itm.PVDTId,
                            PVDTName = itm.PVDTName
                        };
                        entities.Add(entity);
                        db.PVDTS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PVDT
            {
                PVDTId = itm.PVDTId,
                PVDTName = itm.PVDTName
            }));
        }
        public ActionResult PVDTDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PVDT> item)
        {
            var entities = new List<PVDT>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new PVDT
                        {
                            PVDTId = itm.PVDTId,
                            PVDTName = itm.PVDTName
                        };
                        entities.Add(entity);
                        db.PVDTS.Attach(entity);
                        db.PVDTS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new PVDT
            {
                PVDTId = itm.PVDTId,
                PVDTName = itm.PVDTName
            }));
        }
        #endregion

        #region ReferralOrganization
        public ActionResult ReferralOrganization()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeReferralOrganization = "active";
            return View();
        }
        public ActionResult ReferralOrganizationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ReferralOrganization> item = db.ReferralOrganizations;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ReferralOrganizationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralOrganization> item)
        {
            var entities = new List<ReferralOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralOrganization
                        {
                            ReferralOrganizationName = itm.ReferralOrganizationName,
                        };
                        db.ReferralOrganizations.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ReferralOrganization
            {
                ReferralOrganizationId = product.ReferralOrganizationId,
                ReferralOrganizationName = product.ReferralOrganizationName
            }));
        }
        public ActionResult ReferralOrganizationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralOrganization> item)
        {
            var entities = new List<ReferralOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralOrganization
                        {
                            ReferralOrganizationId = itm.ReferralOrganizationId,
                            ReferralOrganizationName = itm.ReferralOrganizationName
                        };
                        entities.Add(entity);
                        db.ReferralOrganizations.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ReferralOrganization
            {
                ReferralOrganizationId = itm.ReferralOrganizationId,
                ReferralOrganizationName = itm.ReferralOrganizationName
            }));
        }
        public ActionResult ReferralOrganizationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralOrganization> item)
        {
            var entities = new List<ReferralOrganization>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralOrganization
                        {
                            ReferralOrganizationId = itm.ReferralOrganizationId,
                            ReferralOrganizationName = itm.ReferralOrganizationName
                        };
                        entities.Add(entity);
                        db.ReferralOrganizations.Attach(entity);
                        db.ReferralOrganizations.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ReferralOrganization
            {
                ReferralOrganizationId = itm.ReferralOrganizationId,
                ReferralOrganizationName = itm.ReferralOrganizationName
            }));
        }
        #endregion

        #region ReferralPhysician
        public ActionResult ReferralPhysician()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeReferralPhysician = "active";
            return View();
        }
        public ActionResult ReferralPhysicianRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ReferralPhysician> item = db.ReferralPhysicians;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ReferralPhysicianCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralPhysician> item)
        {
            var entities = new List<ReferralPhysician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralPhysician
                        {
                            ReferralPhysicianName = itm.ReferralPhysicianName,
                        };
                        db.ReferralPhysicians.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ReferralPhysician
            {
                ReferralPhysicianId = product.ReferralPhysicianId,
                ReferralPhysicianName = product.ReferralPhysicianName
            }));
        }
        public ActionResult ReferralPhysicianUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralPhysician> item)
        {
            var entities = new List<ReferralPhysician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralPhysician
                        {
                            ReferralPhysicianId = itm.ReferralPhysicianId,
                            ReferralPhysicianName = itm.ReferralPhysicianName
                        };
                        entities.Add(entity);
                        db.ReferralPhysicians.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ReferralPhysician
            {
                ReferralPhysicianId = itm.ReferralPhysicianId,
                ReferralPhysicianName = itm.ReferralPhysicianName
            }));
        }
        public ActionResult ReferralPhysicianDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ReferralPhysician> item)
        {
            var entities = new List<ReferralPhysician>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ReferralPhysician
                        {
                            ReferralPhysicianId = itm.ReferralPhysicianId,
                            ReferralPhysicianName = itm.ReferralPhysicianName
                        };
                        entities.Add(entity);
                        db.ReferralPhysicians.Attach(entity);
                        db.ReferralPhysicians.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ReferralPhysician
            {
                ReferralPhysicianId = itm.ReferralPhysicianId,
                ReferralPhysicianName = itm.ReferralPhysicianName
            }));
        }
        #endregion

        #region Region
        public ActionResult Region()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeRegion = "active";
            return View();
        }
        public ActionResult RegionRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Region> item = db.Regions;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult RegionCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Region> item)
        {
            var entities = new List<Region>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Region
                        {
                            RegionName = itm.RegionName,
                        };
                        db.Regions.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Region
            {
                RegionId = product.RegionId,
                RegionName = product.RegionName
            }));
        }
        public ActionResult RegionUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Region> item)
        {
            var entities = new List<Region>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Region
                        {
                            RegionId = itm.RegionId,
                            RegionName = itm.RegionName
                        };
                        entities.Add(entity);
                        db.Regions.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Region
            {
                RegionId = itm. RegionId,
                RegionName = itm.RegionName
            }));
        }
        public ActionResult RegionDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Region> item)
        {
            var entities = new List<Region>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Region
                        {
                            RegionId = itm.RegionId,
                            RegionName = itm.RegionName
                        };
                        entities.Add(entity);
                        db.Regions.Attach(entity);
                        db.Regions.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Region
            {
                RegionId = itm.RegionId,
                RegionName = itm.RegionName
            }));
        }
        #endregion

        #region RelativeStatus
        public ActionResult RelativeStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeRelativeStatus = "active";
            return View();
        }
        public ActionResult RelativeStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<RelativeStatus> item = db.RelativeStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult RelativeStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RelativeStatus> item)
        {
            var entities = new List<RelativeStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RelativeStatus
                        {
                            RelativeStatusName = itm.RelativeStatusName,
                        };
                        db.RelativeStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new RelativeStatus
            {
                RelativeStatusId = product.RelativeStatusId,
                RelativeStatusName = product.RelativeStatusName
            }));
        }
        public ActionResult RelativeStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RelativeStatus> item)
        {
            var entities = new List<RelativeStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RelativeStatus
                        {
                            RelativeStatusId = itm.RelativeStatusId,
                            RelativeStatusName = itm.RelativeStatusName
                        };
                        entities.Add(entity);
                        db.RelativeStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RelativeStatus
            {
                RelativeStatusId = itm.RelativeStatusId,
                RelativeStatusName = itm.RelativeStatusName
            }));
        }
        public ActionResult RelativeStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RelativeStatus> item)
        {
            var entities = new List<RelativeStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RelativeStatus
                        {
                            RelativeStatusId = itm.RelativeStatusId,
                            RelativeStatusName = itm.RelativeStatusName
                        };
                        entities.Add(entity);
                        db.RelativeStatuses.Attach(entity);
                        db.RelativeStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RelativeStatus
            {
                RelativeStatusId = itm.RelativeStatusId,
                RelativeStatusName = itm.RelativeStatusName
            }));
        }
        #endregion

        #region RheumatizmDuration
        public ActionResult RheumatizmDuration()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeRheumatizmDuration = "active";
            return View();
        }
        public ActionResult RheumatizmDurationRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<RheumatizmDuration> item = db.RheumatizmDurations;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult RheumatizmDurationCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RheumatizmDuration> item)
        {
            var entities = new List<RheumatizmDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RheumatizmDuration
                        {
                            RheumatizmDurationName = itm.RheumatizmDurationName,
                        };
                        db.RheumatizmDurations.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new RheumatizmDuration
            {
                RheumatizmDurationId = product.RheumatizmDurationId,
                RheumatizmDurationName = product.RheumatizmDurationName
            }));
        }
        public ActionResult RheumatizmDurationUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RheumatizmDuration> item)
        {
            var entities = new List<RheumatizmDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RheumatizmDuration
                        {
                            RheumatizmDurationId = itm.RheumatizmDurationId,
                            RheumatizmDurationName = itm.RheumatizmDurationName
                        };
                        entities.Add(entity);
                        db.RheumatizmDurations.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RheumatizmDuration
            {
                RheumatizmDurationId = itm.RheumatizmDurationId,
                RheumatizmDurationName = itm.RheumatizmDurationName
            }));
        }
        public ActionResult RheumatizmDurationDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RheumatizmDuration> item)
        {
            var entities = new List<RheumatizmDuration>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RheumatizmDuration
                        {
                            RheumatizmDurationId = itm.RheumatizmDurationId,
                            RheumatizmDurationName = itm.RheumatizmDurationName
                        };
                        entities.Add(entity);
                        db.RheumatizmDurations.Attach(entity);
                        db.RheumatizmDurations.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RheumatizmDuration
            {
                RheumatizmDurationId = itm.RheumatizmDurationId,
                RheumatizmDurationName = itm.RheumatizmDurationName
            }));
        }
        #endregion

        #region RhFactor
        public ActionResult RhFactor()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeRhFactor = "active";
            return View();
        }
        public ActionResult RhFactorRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<RhFactor> item = db.RhFactors;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult RhFactorCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhFactor> item)
        {
            var entities = new List<RhFactor>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhFactor
                        {
                            RhFactorName = itm.RhFactorName,
                        };
                        db.RhFactors.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new RhFactor
            {
                RhFactorId = product.RhFactorId,
                RhFactorName = product.RhFactorName
            }));
        }
        public ActionResult RhFactorUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhFactor> item)
        {
            var entities = new List<RhFactor>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhFactor
                        {
                            RhFactorId = itm.RhFactorId,
                            RhFactorName = itm.RhFactorName
                        };
                        entities.Add(entity);
                        db.RhFactors.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RhFactor
            {
                RhFactorId = itm.RhFactorId,
                RhFactorName = itm.RhFactorName
            }));
        }
        public ActionResult RhFactorDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhFactor> item)
        {
            var entities = new List<RhFactor>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhFactor
                        {
                            RhFactorId = itm.RhFactorId,
                            RhFactorName = itm.RhFactorName
                        };
                        entities.Add(entity);
                        db.RhFactors.Attach(entity);
                        db.RhFactors.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RhFactor
            {
                RhFactorId = itm.RhFactorId,
                RhFactorName = itm.RhFactorName
            }));
        }
        #endregion

        #region RhythmType
        public ActionResult RhythmType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeRhythmType = "active";
            return View();
        }
        public ActionResult RhythmTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<RhythmType> item = db.RhythmTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult RhythmTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhythmType> item)
        {
            var entities = new List<RhythmType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhythmType
                        {
                            RhythmTypeName = itm.RhythmTypeName,
                        };
                        db.RhythmTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new RhythmType
            {
                RhythmTypeId = product.RhythmTypeId,
                RhythmTypeName = product.RhythmTypeName
            }));
        }
        public ActionResult RhythmTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhythmType> item)
        {
            var entities = new List<RhythmType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhythmType
                        {
                            RhythmTypeId = itm.RhythmTypeId,
                            RhythmTypeName = itm.RhythmTypeName
                        };
                        entities.Add(entity);
                        db.RhythmTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RhythmType
            {
                RhythmTypeId = itm.RhythmTypeId,
                RhythmTypeName = itm.RhythmTypeName
            }));
        }
        public ActionResult RhythmTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<RhythmType> item)
        {
            var entities = new List<RhythmType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new RhythmType
                        {
                            RhythmTypeId = itm.RhythmTypeId,
                            RhythmTypeName = itm.RhythmTypeName
                        };
                        entities.Add(entity);
                        db.RhythmTypes.Attach(entity);
                        db.RhythmTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new RhythmType
            {
                RhythmTypeId = itm.RhythmTypeId,
                RhythmTypeName = itm.RhythmTypeName
            }));
        }
        #endregion

        #region Segment
        public ActionResult Segment()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeSegment = "active";
            return View();
        }
        public ActionResult SegmentRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Segment> item = db.Segments;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult SegmentCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Segment> item)
        {
            var entities = new List<Segment>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Segment
                        {
                            SegmentName = itm.SegmentName,
                        };
                        db.Segments.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Segment
            {
                SegmentId = product.SegmentId,
                SegmentName = product.SegmentName
            }));
        }
        public ActionResult SegmentUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Segment> item)
        {
            var entities = new List<Segment>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Segment
                        {
                            SegmentId = itm.SegmentId,
                            SegmentName = itm.SegmentName
                        };
                        entities.Add(entity);
                        db.Segments.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Segment
            {
                SegmentId = itm.SegmentId,
                SegmentName = itm.SegmentName
            }));
        }
        public ActionResult SegmentDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Segment> item)
        {
            var entities = new List<Segment>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Segment
                        {
                            SegmentId = itm.SegmentId,
                            SegmentName = itm.SegmentName
                        };
                        entities.Add(entity);
                        db.Segments.Attach(entity);
                        db.Segments.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Segment
            {
                SegmentId = itm.SegmentId,
                SegmentName = itm.SegmentName
            }));
        }
        #endregion

        #region ShockType
        public ActionResult ShockType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeShockType = "active";
            return View();
        }
        public ActionResult ShockTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ShockType> item = db.ShockTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ShockTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ShockType> item)
        {
            var entities = new List<ShockType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ShockType
                        {
                            ShockTypeName = itm.ShockTypeName,
                        };
                        db.ShockTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ShockType
            {
                ShockTypeId = product.ShockTypeId,
                ShockTypeName = product.ShockTypeName
            }));
        }
        public ActionResult ShockTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ShockType> item)
        {
            var entities = new List<ShockType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ShockType
                        {
                            ShockTypeId = itm.ShockTypeId,
                            ShockTypeName = itm.ShockTypeName
                        };
                        entities.Add(entity);
                        db.ShockTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ShockType
            {
                ShockTypeId = itm.ShockTypeId,
                ShockTypeName = itm.ShockTypeName
            }));
        }
        public ActionResult ShockTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ShockType> item)
        {
            var entities = new List<ShockType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ShockType
                        {
                            ShockTypeId = itm.ShockTypeId,
                            ShockTypeName = itm.ShockTypeName
                        };
                        entities.Add(entity);
                        db.ShockTypes.Attach(entity);
                        db.ShockTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ShockType
            {
                ShockTypeId = itm.ShockTypeId,
                ShockTypeName = itm.ShockTypeName
            }));
        }
        #endregion

        #region SmokingStatus
        public ActionResult SmokingStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeSmokingStatus = "active";
            return View();
        }
        public ActionResult SmokingStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<SmokingStatus> item = db.SmokingStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult SmokingStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingStatus> item)
        {
            var entities = new List<SmokingStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingStatus
                        {
                            SmokingStatusName = itm.SmokingStatusName,
                        };
                        db.SmokingStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new SmokingStatus
            {
                SmokingStatusId = product.SmokingStatusId,
                SmokingStatusName = product.SmokingStatusName
            }));
        }
        public ActionResult SmokingStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingStatus> item)
        {
            var entities = new List<SmokingStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingStatus
                        {
                            SmokingStatusId = itm.SmokingStatusId,
                            SmokingStatusName = itm.SmokingStatusName
                        };
                        entities.Add(entity);
                        db.SmokingStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new SmokingStatus
            {
                SmokingStatusId = itm.SmokingStatusId,
                SmokingStatusName = itm.SmokingStatusName
            }));
        }
        public ActionResult SmokingStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingStatus> item)
        {
            var entities = new List<SmokingStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingStatus
                        {
                            SmokingStatusId = itm.SmokingStatusId,
                            SmokingStatusName = itm.SmokingStatusName
                        };
                        entities.Add(entity);
                        db.SmokingStatuses.Attach(entity);
                        db.SmokingStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new SmokingStatus
            {
                SmokingStatusId = itm.SmokingStatusId,
                SmokingStatusName = itm.SmokingStatusName
            }));
        }
        #endregion

        #region SmokingType
        public ActionResult SmokingType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeSmokingType = "active";
            return View();
        }
        public ActionResult SmokingTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<SmokingStatus> item = db.SmokingStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult SmokingTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingType> item)
        {
            var entities = new List<SmokingType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingType
                        {
                            SmokingTypeName = itm.SmokingTypeName,
                        };
                        db.SmokingTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new SmokingType
            {
                SmokingTypeId = product.SmokingTypeId,
                SmokingTypeName = product.SmokingTypeName
            }));
        }
        public ActionResult SmokingTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingType> item)
        {
            var entities = new List<SmokingType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingType
                        {
                            SmokingTypeId = itm.SmokingTypeId,
                            SmokingTypeName = itm.SmokingTypeName
                        };
                        entities.Add(entity);
                        db.SmokingTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new SmokingType
            {
                SmokingTypeId = itm.SmokingTypeId,
                SmokingTypeName = itm.SmokingTypeName
            }));
        }
        public ActionResult SmokingTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<SmokingType> item)
        {
            var entities = new List<SmokingType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new SmokingType
                        {
                            SmokingTypeId = itm.SmokingTypeId,
                            SmokingTypeName = itm.SmokingTypeName
                        };
                        entities.Add(entity);
                        db.SmokingTypes.Attach(entity);
                        db.SmokingTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new SmokingType
            {
                SmokingTypeId = itm.SmokingTypeId,
                SmokingTypeName = itm.SmokingTypeName
            }));
        }
        #endregion

        #region Stenosis
        public ActionResult Stenosis()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeStenosis = "active";
            return View();
        }
        public ActionResult StenosisRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Stenosis> item = db.Stenosises;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult StenosisCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stenosis> item)
        {
            var entities = new List<Stenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stenosis
                        {
                            StenosisName = itm.StenosisName,
                        };
                        db.Stenosises.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Stenosis
            {
                StenosisId = product.StenosisId,
                StenosisName = product.StenosisName
            }));
        }
        public ActionResult StenosisUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stenosis> item)
        {
            var entities = new List<Stenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stenosis
                        {
                            StenosisId = itm.StenosisId,
                            StenosisName = itm.StenosisName
                        };
                        entities.Add(entity);
                        db.Stenosises.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Stenosis
            {
                StenosisId = itm.StenosisId,
                StenosisName = itm.StenosisName
            }));
        }
        public ActionResult StenosisDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stenosis> item)
        {
            var entities = new List<Stenosis>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stenosis
                        {
                            StenosisId = itm.StenosisId,
                            StenosisName = itm.StenosisName
                        };
                        entities.Add(entity);
                        db.Stenosises.Attach(entity);
                        db.Stenosises.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Stenosis
            {
                StenosisId = itm.StenosisId,
                StenosisName = itm.StenosisName
            }));
        }
        #endregion

        #region Stent
        public ActionResult Stent()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeStent = "active";
            return View();
        }
        public ActionResult StentRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Stent> item = db.Stents;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult StentCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stent> item)
        {
            var entities = new List<Stent>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stent
                        {
                            StentName = itm.StentName,
                        };
                        db.Stents.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Stent
            {
                StentId= product.StentId,
                StentName = product.StentName
            }));
        }
        public ActionResult StentUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stent> item)
        {
            var entities = new List<Stent>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stent
                        {
                            StentId = itm.StentId,
                            StentName = itm.StentName
                        };
                        entities.Add(entity);
                        db.Stents.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Stent
            {
                StentId = itm.StentId,
                StentName = itm.StentName
            }));
        }
        public ActionResult StentDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stent> item)
        {
            var entities = new List<Stent>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Stent
                        {
                            StentId = itm.StentId,
                            StentName = itm.StentName
                        };
                        entities.Add(entity);
                        db.Stents.Attach(entity);
                        db.Stents.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Stent
            {
                StentId = itm.StentId,
                StentName = itm.StentName
            }));
        }
        #endregion

        #region StentType
        public ActionResult StentType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeStentType = "active";
            return View();
        }
        public ActionResult StentTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<StentType> item = db.StentTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult StentTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StentType> item)
        {
            var entities = new List<StentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StentType
                        {
                            StentTypeName = itm.StentTypeName,
                        };
                        db.StentTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new StentType
            {
                StentTypeId = product.StentTypeId,
                StentTypeName = product.StentTypeName
            }));
        }
        public ActionResult StentTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StentType> item)
        {
            var entities = new List<StentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StentType
                        {
                            StentTypeId = itm.StentTypeId,
                            StentTypeName = itm.StentTypeName
                        };
                        entities.Add(entity);
                        db.StentTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new StentType
            {
                StentTypeId = itm.StentTypeId,
                StentTypeName = itm.StentTypeName
            }));
        }
        public ActionResult StentTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StentType> item)
        {
            var entities = new List<StentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StentType
                        {
                            StentTypeId = itm.StentTypeId,
                            StentTypeName = itm.StentTypeName
                        };
                        entities.Add(entity);
                        db.StentTypes.Attach(entity);
                        db.StentTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new StentType
            {
                StentTypeId = itm.StentTypeId,
                StentTypeName = itm.StentTypeName
            }));
        }
        #endregion

        #region StrokeType
        public ActionResult StrokeType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeStrokeType = "active";
            return View();
        }
        public ActionResult StrokeTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<StrokeType> item = db.StrokeTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult StrokeTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StrokeType> item)
        {
            var entities = new List<StrokeType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StrokeType
                        {
                            StrokeTypeName = itm.StrokeTypeName,
                        };
                        db.StrokeTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new StrokeType
            {
                StrokeTypeId = product.StrokeTypeId,
                StrokeTypeName = product.StrokeTypeName
            }));
        }
        public ActionResult StrokeTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StrokeType> item)
        {
            var entities = new List<StrokeType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StrokeType
                        {
                            StrokeTypeId = itm.StrokeTypeId,
                            StrokeTypeName = itm.StrokeTypeName
                        };
                        entities.Add(entity);
                        db.StrokeTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new StrokeType
            {
                StrokeTypeId = itm.StrokeTypeId,
                StrokeTypeName = itm.StrokeTypeName
            }));
        }
        public ActionResult StrokeTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<StrokeType> item)
        {
            var entities = new List<StrokeType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new StrokeType
                        {
                            StrokeTypeId = itm.StrokeTypeId,
                            StrokeTypeName = itm.StrokeTypeName
                        };
                        entities.Add(entity);
                        db.StrokeTypes.Attach(entity);
                        db.StrokeTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new StrokeType
            {
                StrokeTypeId = itm.StrokeTypeId,
                StrokeTypeName = itm.StrokeTypeName
            }));
        }
        #endregion

        #region TIMI
        public ActionResult TIMI()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTIMI = "active";
            return View();
        }
        public ActionResult TIMIRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TIMI> item = db.TIMIS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TIMICreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TIMI> item)
        {
            var entities = new List<TIMI>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TIMI
                        {
                            TIMIName = itm.TIMIName,
                        };
                        db.TIMIS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TIMI
            {
                TIMIId = product.TIMIId,
                TIMIName = product.TIMIName
            }));
        }
        public ActionResult TIMIUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TIMI> item)
        {
            var entities = new List<TIMI>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TIMI
                        {
                            TIMIId = itm.TIMIId,
                            TIMIName = itm.TIMIName
                        };
                        entities.Add(entity);
                        db.TIMIS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TIMI
            {
                TIMIId = itm.TIMIId,
                TIMIName = itm.TIMIName
            }));
        }
        public ActionResult TIMIDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TIMI> item)
        {
            var entities = new List<TIMI>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TIMI
                        {
                            TIMIId = itm.TIMIId,
                            TIMIName = itm.TIMIName
                        };
                        entities.Add(entity);
                        db.TIMIS.Attach(entity);
                        db.TIMIS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TIMI
            {
                TIMIId = itm.TIMIId,
                TIMIName = itm.TIMIName
            }));
        }
        #endregion

        #region TPHAStatus
        public ActionResult TPHAStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTPHAStatus = "active";
            return View();
        }
        public ActionResult TPHAStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TPHAStatus> item = db.TPHAStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TPHAStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TPHAStatus> item)
        {
            var entities = new List<TPHAStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TPHAStatus
                        {
                            TPHAStatusName = itm.TPHAStatusName,
                        };
                        db.TPHAStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TPHAStatus
            {
                TPHAStatusId = product.TPHAStatusId,
                TPHAStatusName = product.TPHAStatusName
            }));
        }
        public ActionResult TPHAStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TPHAStatus> item)
        {
            var entities = new List<TPHAStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TPHAStatus
                        {
                            TPHAStatusId = itm.TPHAStatusId,
                            TPHAStatusName = itm.TPHAStatusName
                        };
                        entities.Add(entity);
                        db.TPHAStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TPHAStatus
            {
                TPHAStatusId = itm.TPHAStatusId,
                TPHAStatusName = itm.TPHAStatusName
            }));
        }
        public ActionResult TPHAStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TPHAStatus> item)
        {
            var entities = new List<TPHAStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TPHAStatus
                        {
                            TPHAStatusId = itm.TPHAStatusId,
                            TPHAStatusName = itm.TPHAStatusName
                        };
                        entities.Add(entity);
                        db.TPHAStatuses.Attach(entity);
                        db.TPHAStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TPHAStatus
            {
                TPHAStatusId = itm.TPHAStatusId,
                TPHAStatusName = itm.TPHAStatusName
            }));
        }
        #endregion

        #region TreadmilProtocol
        public ActionResult TreadmilProtocol()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTreadmilProtocol = "active";
            return View();
        }
        public ActionResult TreadmilProtocolRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TreadmilProtocol> item = db.TreadmilProtocols;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TreadmilProtocolCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilProtocol> item)
        {
            var entities = new List<TreadmilProtocol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilProtocol
                        {
                            TreadmilProtocolName = itm.TreadmilProtocolName,
                        };
                        db.TreadmilProtocols.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TreadmilProtocol
            {
                TreadmilProtocolId = product.TreadmilProtocolId,
                TreadmilProtocolName = product.TreadmilProtocolName
            }));
        }
        public ActionResult TreadmilProtocolUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilProtocol> item)
        {
            var entities = new List<TreadmilProtocol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilProtocol
                        {
                            TreadmilProtocolId = itm.TreadmilProtocolId,
                            TreadmilProtocolName = itm.TreadmilProtocolName
                        };
                        entities.Add(entity);
                        db.TreadmilProtocols.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreadmilProtocol
            {
                TreadmilProtocolId = itm.TreadmilProtocolId,
                TreadmilProtocolName = itm.TreadmilProtocolName
            }));
        }
        public ActionResult TreadmilProtocolDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilProtocol> item)
        {
            var entities = new List<TreadmilProtocol>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilProtocol
                        {
                            TreadmilProtocolId = itm.TreadmilProtocolId,
                            TreadmilProtocolName = itm.TreadmilProtocolName
                        };
                        entities.Add(entity);
                        db.TreadmilProtocols.Attach(entity);
                        db.TreadmilProtocols.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreadmilProtocol
            {
                TreadmilProtocolId = itm.TreadmilProtocolId,
                TreadmilProtocolName = itm.TreadmilProtocolName
            }));
        }
        #endregion

        #region TreadmilResult
        public ActionResult TreadmilResult()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTreadmilResult = "active";
            return View();
        }
        public ActionResult TreadmilResultRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TreadmilResult> item = db.TreadmilResults;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TreadmilResultCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilResult> item)
        {
            var entities = new List<TreadmilResult>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilResult
                        {
                            TreadmilResultName = itm.TreadmilResultName,
                        };
                        db.TreadmilResults.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TreadmilResult
            {
                TreadmilResultId = product.TreadmilResultId,
                TreadmilResultName = product.TreadmilResultName
            }));
        }
        public ActionResult TreadmilResultUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilResult> item)
        {
            var entities = new List<TreadmilResult>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilResult
                        {
                            TreadmilResultId = itm.TreadmilResultId,
                            TreadmilResultName = itm.TreadmilResultName
                        };
                        entities.Add(entity);
                        db.TreadmilResults.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreadmilResult
            {
                TreadmilResultId = itm.TreadmilResultId,
                TreadmilResultName = itm.TreadmilResultName
            }));
        }
        public ActionResult TreadmilResultDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreadmilResult> item)
        {
            var entities = new List<TreadmilResult>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreadmilResult
                        {
                            TreadmilResultId = itm.TreadmilResultId,
                            TreadmilResultName = itm.TreadmilResultName
                        };
                        entities.Add(entity);
                        db.TreadmilResults.Attach(entity);
                        db.TreadmilResults.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreadmilResult
            {
                TreadmilResultId = itm.TreadmilResultId,
                TreadmilResultName = itm.TreadmilResultName
            }));
        }
        #endregion

        #region TreatmentType
        public ActionResult TreatmentType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTreatmentType = "active";
            return View();
        }
        public ActionResult TreatmentTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TreatmentType> item = db.TreatmentTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TreatmentTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreatmentType> item)
        {
            var entities = new List<TreatmentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreatmentType
                        {
                            TreatmentTypeName = itm.TreatmentTypeName,
                        };
                        db.TreatmentTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TreatmentType
            {
                TreatmentTypeId = product.TreatmentTypeId,
                TreatmentTypeName = product.TreatmentTypeName
            }));
        }
        public ActionResult TreatmentTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreatmentType> item)
        {
            var entities = new List<TreatmentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreatmentType
                        {
                            TreatmentTypeId = itm.TreatmentTypeId,
                            TreatmentTypeName = itm.TreatmentTypeName
                        };
                        entities.Add(entity);
                        db.TreatmentTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreatmentType
            {
                TreatmentTypeId = itm.TreatmentTypeId,
                TreatmentTypeName = itm.TreatmentTypeName
            }));
        }
        public ActionResult TreatmentTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TreatmentType> item)
        {
            var entities = new List<TreatmentType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TreatmentType
                        {
                            TreatmentTypeId = itm.TreatmentTypeId,
                            TreatmentTypeName = itm.TreatmentTypeName
                        };
                        entities.Add(entity);
                        db.TreatmentTypes.Attach(entity);
                        db.TreatmentTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TreatmentType
            {
                TreatmentTypeId = itm.TreatmentTypeId,
                TreatmentTypeName = itm.TreatmentTypeName
            }));
        }
        #endregion

        #region TroponinStatus
        public ActionResult TroponinStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeTroponinStatus = "active";
            return View();
        }
        public ActionResult TroponinStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<TroponinStatus> item = db.TroponinStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult TroponinStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TroponinStatus> item)
        {
            var entities = new List<TroponinStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TroponinStatus
                        {
                            TroponinStatusName = itm.TroponinStatusName,
                        };
                        db.TroponinStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new TroponinStatus
            {
                TroponinStatusId = product.TroponinStatusId,
                TroponinStatusName = product. TroponinStatusName
            }));
        }
        public ActionResult TroponinStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TroponinStatus> item)
        {
            var entities = new List<TroponinStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TroponinStatus
                        {
                            TroponinStatusId = itm.TroponinStatusId,
                            TroponinStatusName = itm.TroponinStatusName
                        };
                        entities.Add(entity);
                        db.TroponinStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TroponinStatus
            {
                TroponinStatusId = itm.TroponinStatusId,
                TroponinStatusName = itm.TroponinStatusName
            }));
        }
        public ActionResult TroponinStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<TroponinStatus> item)
        {
            var entities = new List<TroponinStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new TroponinStatus
                        {
                            TroponinStatusId = itm.TroponinStatusId,
                            TroponinStatusName = itm.TroponinStatusName
                        };
                        entities.Add(entity);
                        db.TroponinStatuses.Attach(entity);
                        db.TroponinStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new TroponinStatus
            {
                TroponinStatusId = itm.TroponinStatusId,
                TroponinStatusName = itm.TroponinStatusName
            }));
        }
        #endregion

        #region UrineCylinderStatus
        public ActionResult UrineCylinderStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeUrineCylinderStatus = "active";
            return View();
        }
        public ActionResult UrineCylinderStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<UrineCylinderStatus> item = db.UrineCylinderStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult UrineCylinderStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineCylinderStatus> item)
        {
            var entities = new List<UrineCylinderStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineCylinderStatus
                        {
                             UrineCylinderStatusName = itm.UrineCylinderStatusName,
                        };
                        db.UrineCylinderStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new UrineCylinderStatus
            {
                UrineCylinderStatusId = product.UrineCylinderStatusId,
                UrineCylinderStatusName = product.UrineCylinderStatusName
            }));
        }
        public ActionResult UrineCylinderStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineCylinderStatus> item)
        {
            var entities = new List<UrineCylinderStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineCylinderStatus
                        {
                            UrineCylinderStatusId = itm.UrineCylinderStatusId,
                            UrineCylinderStatusName = itm.UrineCylinderStatusName
                        };
                        entities.Add(entity);
                        db.UrineCylinderStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrineCylinderStatus
            {
                UrineCylinderStatusId = itm.UrineCylinderStatusId,
                UrineCylinderStatusName = itm.UrineCylinderStatusName
            }));
        }
        public ActionResult UrineCylinderStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineCylinderStatus> item)
        {
            var entities = new List<UrineCylinderStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineCylinderStatus
                        {
                            UrineCylinderStatusId = itm.UrineCylinderStatusId,
                            UrineCylinderStatusName = itm.UrineCylinderStatusName
                        };
                        entities.Add(entity);
                        db.UrineCylinderStatuses.Attach(entity);
                        db.UrineCylinderStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrineCylinderStatus
            {
                UrineCylinderStatusId = itm.UrineCylinderStatusId,
                UrineCylinderStatusName = itm.UrineCylinderStatusName
            }));
        }
        #endregion

        #region UrineMicroorganismStatus
        public ActionResult UrineMicroorganismStatus()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeUrineMicroorganismStatus = "active";
            return View();
        }
        public ActionResult UrineMicroorganismStatusRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<UrineMicroorganismStatus> item = db.UrineMicroorganismStatuses;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult UrineMicroorganismStatusCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineMicroorganismStatus> item)
        {
            var entities = new List<UrineMicroorganismStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineMicroorganismStatus
                        {
                            UrineMicroorganismStatusName = itm.UrineMicroorganismStatusName,
                        };
                        db.UrineMicroorganismStatuses.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new UrineMicroorganismStatus
            {
                UrineMicroorganismStatusId = product.UrineMicroorganismStatusId,
                UrineMicroorganismStatusName = product.UrineMicroorganismStatusName
            }));
        }
        public ActionResult UrineMicroorganismStatusUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineMicroorganismStatus> item)
        {
            var entities = new List<UrineMicroorganismStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineMicroorganismStatus
                        {
                            UrineMicroorganismStatusId = itm.UrineMicroorganismStatusId,
                            UrineMicroorganismStatusName = itm.UrineMicroorganismStatusName
                        };
                        entities.Add(entity);
                        db.UrineMicroorganismStatuses.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrineMicroorganismStatus
            {
                UrineMicroorganismStatusId = itm. UrineMicroorganismStatusId,
                UrineMicroorganismStatusName = itm.UrineMicroorganismStatusName
            }));
        }
        public ActionResult UrineMicroorganismStatusDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrineMicroorganismStatus> item)
        {
            var entities = new List<UrineMicroorganismStatus>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrineMicroorganismStatus
                        {
                            UrineMicroorganismStatusId = itm.UrineMicroorganismStatusId,
                            UrineMicroorganismStatusName = itm.UrineMicroorganismStatusName
                        };
                        entities.Add(entity);
                        db.UrineMicroorganismStatuses.Attach(entity);
                        db.UrineMicroorganismStatuses.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrineMicroorganismStatus
            {
                UrineMicroorganismStatusId = itm.UrineMicroorganismStatusId,
                UrineMicroorganismStatusName = itm.UrineMicroorganismStatusName
            }));
        }
        #endregion

        #region UrogenitalicDisease
        public ActionResult UrogenitalicDisease()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeUrogenitalicDisease = "active";
            return View();
        }
        public ActionResult UrogenitalicDiseaseRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<UrogenitalicDisease> item = db.UrogenitalicDiseases;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult UrogenitalicDiseaseCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrogenitalicDisease> item)
        {
            var entities = new List<UrogenitalicDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrogenitalicDisease
                        {
                            UrogenitalicDiseaseName = itm.UrogenitalicDiseaseName,
                        };
                        db.UrogenitalicDiseases.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new UrogenitalicDisease
            {
                UrogenitalicDiseaseId = product.UrogenitalicDiseaseId,
                UrogenitalicDiseaseName = product.UrogenitalicDiseaseName
            }));
        }
        public ActionResult UrogenitalicDiseaseUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrogenitalicDisease> item)
        {
            var entities = new List<UrogenitalicDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrogenitalicDisease
                        {
                            UrogenitalicDiseaseId = itm.UrogenitalicDiseaseId,
                            UrogenitalicDiseaseName = itm.UrogenitalicDiseaseName
                        };
                        entities.Add(entity);
                        db.UrogenitalicDiseases.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrogenitalicDisease
            {
                UrogenitalicDiseaseId = itm.UrogenitalicDiseaseId,
                UrogenitalicDiseaseName = itm.UrogenitalicDiseaseName
            }));
        }
        public ActionResult UrogenitalicDiseaseDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<UrogenitalicDisease> item)
        {
            var entities = new List<UrogenitalicDisease>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new UrogenitalicDisease
                        {
                            UrogenitalicDiseaseId = itm.UrogenitalicDiseaseId,
                            UrogenitalicDiseaseName = itm.UrogenitalicDiseaseName
                        };
                        entities.Add(entity);
                        db.UrogenitalicDiseases.Attach(entity);
                        db.UrogenitalicDiseases.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new UrogenitalicDisease
            {
                UrogenitalicDiseaseId = itm.UrogenitalicDiseaseId,
                UrogenitalicDiseaseName = itm.UrogenitalicDiseaseName
            }));
        }
        #endregion

        #region Valve
        public ActionResult Valve()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeValve = "active";
            return View();
        }
        public ActionResult ValveRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<Valve> item = db.Valves;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ValveCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Valve> item)
        {
            var entities = new List<Valve>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Valve
                        {
                            ValveName = itm.ValveName,
                        };
                        db.Valves.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new Valve
            {
                ValveId = product.ValveId,
                ValveName = product.ValveName
            }));
        }
        public ActionResult ValveUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Valve> item)
        {
            var entities = new List<Valve>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Valve
                        {
                            ValveId = itm.ValveId,
                            ValveName = itm.ValveName
                        };
                        entities.Add(entity);
                        db.Valves.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Valve
            {
                ValveId = itm.ValveId,
                ValveName = itm.ValveName
            }));
        }
        public ActionResult ValveDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Valve> item)
        {
            var entities = new List<Valve>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new Valve
                        {
                            ValveId = itm.ValveId,
                            ValveName = itm.ValveName
                        };
                        entities.Add(entity);
                        db.Valves.Attach(entity);
                        db.Valves.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new Valve
            {
                ValveId = itm.ValveId,
                ValveName = itm.ValveName
            }));
        }
        #endregion

        #region ValveSurgeryType
        public ActionResult ValveSurgeryType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeValveSurgeryType = "active";
            return View();
        }
        public ActionResult ValveSurgeryTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ValveSurgeryType> item = db.ValveSurgeryTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ValveSurgeryTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveSurgeryType> item)
        {
            var entities = new List<ValveSurgeryType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveSurgeryType
                        {
                            ValveSurgeryTypeName = itm.ValveSurgeryTypeName,
                        };
                        db.ValveSurgeryTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ValveSurgeryType
            {
                ValveSurgeryTypeId = product.ValveSurgeryTypeId,
                ValveSurgeryTypeName = product.ValveSurgeryTypeName
            }));
        }
        public ActionResult ValveSurgeryTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveSurgeryType> item)
        {
            var entities = new List<ValveSurgeryType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveSurgeryType
                        {
                            ValveSurgeryTypeId = itm.ValveSurgeryTypeId,
                            ValveSurgeryTypeName = itm.ValveSurgeryTypeName
                        };
                        entities.Add(entity);
                        db.ValveSurgeryTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ValveSurgeryType
            {
                ValveSurgeryTypeId = itm.ValveSurgeryTypeId,
                ValveSurgeryTypeName = itm.ValveSurgeryTypeName
            }));
        }
        public ActionResult ValveSurgeryTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveSurgeryType> item)
        {
            var entities = new List<ValveSurgeryType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveSurgeryType
                        {
                            ValveSurgeryTypeId = itm.ValveSurgeryTypeId,
                            ValveSurgeryTypeName = itm.ValveSurgeryTypeName
                        };
                        entities.Add(entity);
                        db.ValveSurgeryTypes.Attach(entity);
                        db.ValveSurgeryTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ValveSurgeryType
            {
                ValveSurgeryTypeId = itm.ValveSurgeryTypeId,
                ValveSurgeryTypeName = itm.ValveSurgeryTypeName
            }));
        }
        #endregion

        #region ValveType
        public ActionResult ValveType()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeValveType = "active";
            return View();
        }
        public ActionResult ValveTypeRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<ValveType> item = db.ValveTypes;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult ValveTypeCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveType> item)
        {
            var entities = new List<ValveType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveType
                        {
                            ValveTypeName = itm.ValveTypeName,
                        };
                        db.ValveTypes.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new ValveType
            {
                ValveTypeId = product.ValveTypeId,
                ValveTypeName = product.ValveTypeName
            }));
        }
        public ActionResult ValveTypeUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveType> item)
        {
            var entities = new List<ValveType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveType
                        {
                            ValveTypeId = itm.ValveTypeId,
                            ValveTypeName = itm.ValveTypeName
                        };
                        entities.Add(entity);
                        db.ValveTypes.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ValveType
            {
                ValveTypeId = itm.ValveTypeId,
                ValveTypeName = itm.ValveTypeName
            }));
        }
        public ActionResult ValveTypeDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ValveType> item)
        {
            var entities = new List<ValveType>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new ValveType
                        {
                            ValveTypeId = itm.ValveTypeId,
                            ValveTypeName = itm.ValveTypeName
                        };
                        entities.Add(entity);
                        db.ValveTypes.Attach(entity);
                        db.ValveTypes.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new ValveType
            {
                ValveTypeId = itm.ValveTypeId,
                ValveTypeName = itm.ValveTypeName
            }));
        }
        #endregion

        #region VH
        public ActionResult VH()
        {
            ViewBag.activeCatalogs = "active";
            ViewBag.activeSys = "active";
            ViewBag.activeVH = "active";
            return View();
        }
        public ActionResult VHRead([DataSourceRequest]DataSourceRequest request)
        {
            using (var db = new StoreContext())
            {
                IQueryable<VH> item = db.VHS;
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
        public ActionResult VHCreate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<VH> item)
        {
            var entities = new List<VH>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new VH
                        {
                            VHName = itm.VHName,
                        };
                        db.VHS.Add(entity);
                        entities.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, product => new VH
            {
                VHId = product.VHId,
                VHName = product.VHName
            }));
        }
        public ActionResult VHUpdate([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<VH> item)
        {
            var entities = new List<VH>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new VH
                        {
                            VHId = itm.VHId,
                            VHName = itm.VHName
                        };
                        entities.Add(entity);
                        db.VHS.Attach(entity);
                        db.Entry(entity).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new VH
            {
                VHId = itm.VHId,
                VHName = itm.VHName
            }));
        }
        public ActionResult VHDestroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<VH> item)
        {
            var entities = new List<VH>();
            if (ModelState.IsValid)
            {
                using (var db = new StoreContext())
                {
                    foreach (var itm in item)
                    {
                        var entity = new VH
                        {
                            VHId = itm.VHId,
                            VHName = itm.VHName
                        };
                        entities.Add(entity);
                        db.VHS.Attach(entity);
                        db.VHS.Remove(entity);
                    }
                    db.SaveChanges();
                }
            }
            return Json(entities.ToDataSourceResult(request, ModelState, itm => new VH
            {
                VHId = itm.VHId,
                VHName = itm.VHName
            }));
        }
        #endregion
    }
}