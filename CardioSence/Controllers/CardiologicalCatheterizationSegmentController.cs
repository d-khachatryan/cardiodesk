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
    public class CardiologicalCatheterizationSegmentController : Controller
    {
        // GET: CardiologicalCatheterizationSegment
        public ActionResult ReadCardiologicalCatheterizationSegmentItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCatheterizationSegmentItem> item = db.CardiologicalCatheterizationSegmentItems.Where(p => p.CardiologicalCatheterizationId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalCatheterizationSegments([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalCatheterizationSegment> item = db.CardiologicalCatheterizationSegments.Where(p => p.CardiologicalCatheterizationId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}