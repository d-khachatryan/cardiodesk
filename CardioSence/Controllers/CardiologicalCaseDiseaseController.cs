using System;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CardioSence.Controllers
{
    public class CardiologicalCaseDiseaseController : Controller
    {
        public ActionResult ReadCardiologicalCaseDiseaseItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseDiseaseItem> item = db.CardiologicalCaseDiseaseItems.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ReadCardiologicalCaseDiseases([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseDisease> item = db.CardiologicalCaseDiseases.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

     }
}