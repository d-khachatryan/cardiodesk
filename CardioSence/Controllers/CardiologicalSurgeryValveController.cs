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
    public class CardiologicalSurgeryValveController : Controller
    {
        // GET: CardiologicalSurgeryValve
        public ActionResult ReadCardiologicalSurgeryValveItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryValveItem> item = db.CardiologicalSurgeryValveItems.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalSurgeryValves([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryValve> item = db.CardiologicalSurgeryValves.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}