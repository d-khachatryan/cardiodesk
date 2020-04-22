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
    public class CardiologicalPCISegmentController : Controller
    {
        // GET: CardiologicalPCISegment
        public ActionResult ReadCardiologicalPCISegmentItems([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalPCISegmentItem> item = db.CardiologicalPCISegmentItems.Where(p => p.CardiologicalPCIId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult ReadCardiologicalPCISegments([DataSourceRequest]DataSourceRequest request, int? id)
        {
            using (var db = new StoreContext())
            {
                IQueryable<CardiologicalPCISegment> item = db.CardiologicalPCISegments.Where(p => p.CardiologicalPCIId == id);
                DataSourceResult result = item.ToDataSourceResult(request);
                return Json(result);
            }
        }
    }
}