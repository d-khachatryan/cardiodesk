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
    public class CardiologicalEchoCGVelocityController : Controller
    {
        // GET: CardiologicalEchoCGVelocity
        public ActionResult ReadCardiologicalEchoCGVelocityItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalEchoCGVelocityItem> item = db.CardiologicalEchoCGVelocityItems.Where(p => p.CardiologicalEchoCGId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }

        }

        public ActionResult ReadCardiologicalEchoCGVelocitys([DataSourceRequest]DataSourceRequest request, int? id)
        {
                using (var db = new StoreContext())
                {
                    IQueryable<CardiologicalEchoCGVelocity> item = db.CardiologicalEchoCGVelocitys.Where(p => p.CardiologicalEchoCGId == id);
                    DataSourceResult result = item.ToDataSourceResult(request);
                    return Json(result);
                }
        }
    }
}