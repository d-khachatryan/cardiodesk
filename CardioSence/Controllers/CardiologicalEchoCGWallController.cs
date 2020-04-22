using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CardioSence.Controllers
{
    public class CardiologicalEchoCGWallController : Controller
    {
        // GET: CardiologicalEchoCGWall
        public ActionResult ReadCardiologicalEchoCGWallItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalEchoCGWallItem> item = db.CardiologicalEchoCGWallItems.Where(p => p.CardiologicalEchoCGId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }

        public ActionResult ReadCardiologicalEchoCGWalls([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalEchoCGWall> item = db.CardiologicalEchoCGWalls.Where(p => p.CardiologicalEchoCGId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}