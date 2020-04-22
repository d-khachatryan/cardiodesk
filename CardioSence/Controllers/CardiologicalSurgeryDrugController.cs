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
    public class CardiologicalSurgeryDrugController : Controller
    {
        // GET: CardiologicalSurgeryDrug
        public ActionResult ReadCardiologicalSurgeryDrugItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryDrugItem> item = db.CardiologicalSurgeryDrugItems.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalSurgeryDrugs([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalSurgeryDrug> item = db.CardiologicalSurgeryDrugs.Where(p => p.CardiologicalSurgeryId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}