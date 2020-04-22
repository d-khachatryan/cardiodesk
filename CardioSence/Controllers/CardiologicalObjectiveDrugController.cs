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
    public class CardiologicalObjectiveDrugController : Controller
    {
        // GET: CardiologicalObjectiveDrug
        public ActionResult ReadCardiologicalObjectiveDrugItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalObjectiveDrugItem> item = db.CardiologicalObjectiveDrugItems.Where(p => p.CardiologicalObjectiveId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalObjectiveDrugs([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalObjectiveDrug> item = db.CardiologicalObjectiveDrugs.Where(p => p.CardiologicalObjectiveId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}