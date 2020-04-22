using System;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CardioSence.Controllers
{
    public class CardiologicalCaseDrugController : Controller
    {       

        public ActionResult ReadCardiologicalCaseDrugItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseDrugItem> item = db.CardiologicalCaseDrugItems.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }        

        public ActionResult ReadCardiologicalCaseDrugs([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseDrug> item = db.CardiologicalCaseDrugs.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }        

    }
}