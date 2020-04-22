using System;
using System.Linq;
using System.Web.Mvc;
using CardioSence.DAL;
using CardioSence.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CardioSence.Controllers
{
    public class CardiologicalCaseComplianController : Controller
    {        

        public ActionResult ReadCardiologicalCaseComplianItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseComplianItem> item = db.CardiologicalCaseComplianItems.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }        

        public ActionResult ReadCardiologicalCaseComplians([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCaseComplian> item = db.CardiologicalCaseComplians.Where(p => p.CardiologicalCaseId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }        

    }
}