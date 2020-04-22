using System;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CardioSence.Controllers
{
    public class CardiologicalCaseInvasionController : Controller
    {        

        public ActionResult ReadCardiologicalCaseInvasionItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseInvasionItem> item = db.CardiologicalCaseInvasionItems.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }        

        public ActionResult ReadCardiologicalCaseInvasions([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseInvasion> item = db.CardiologicalCaseInvasions.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }

    }
}