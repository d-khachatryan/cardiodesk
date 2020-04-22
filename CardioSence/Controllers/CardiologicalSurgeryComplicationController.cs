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
    public class CardiologicalSurgeryComplicationController : Controller
    {
        // GET: CardiologicalSurgeryComplication
        public ActionResult ReadCardiologicalSurgeryComplicationItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryComplicationItem> item = db.CardiologicalSurgeryComplicationItems.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalSurgeryComplications([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryComplication> item = db.CardiologicalSurgeryComplications.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}