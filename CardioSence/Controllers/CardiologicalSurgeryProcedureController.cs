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
    public class CardiologicalSurgeryProcedureController : Controller
    {
        // GET: CardiologicalSurgeryProcedure
        public ActionResult ReadCardiologicalSurgeryProcedureItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryProcedureItem> item = db.CardiologicalSurgeryProcedureItems.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalSurgeryProcedures([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryProcedure> item = db.CardiologicalSurgeryProcedures.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}