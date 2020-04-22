using System.Web;
using System.Web.Optimization;

namespace CardioSence
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //-- Scripts Bundles --
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js"
                        //"~/Scripts/kendo/2016.3.1028/jquery.min.js",
                        "~/Scripts/jquery-2.2.3.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate.unobtrusive.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        //"~/Scripts/fastclick.min.js",
                        "~/Scripts/fastclick.js",
                        //"~/Scripts/jquery.sparkline.min.js",
                        "~/Scripts/jquery.sparkline.js",
                        //"~/Scripts/jquery.slimscroll.min.js",
                        "~/Scripts/jquery.slimscroll.js",
                        //"~/Scripts/Chart.min.js",
                        "~/Scripts/Chart.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        //"~/Scripts/app.min.js",
                        "~/Scripts/app.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/dist").Include(
                        //"~/Scripts/dashboard.js",
                        "~/Scripts/dashboard2.js"
                        //"~/Scripts/demo.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalForms").Include(
                        "~/Scripts/jquery.validate-bootstrap-forms.js"
                        ));

            //Kendo Scripts
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo/2017.1.118/jquery.min.js",
                        "~/Scripts/kendo/2017.1.118/jszip.min.js",
                        "~/Scripts/kendo/2017.1.118/kendo.all.min.js",
                        "~/Scripts/kendo/2017.1.118/kendo.aspnetmvc.min.js",
                        "~/Scripts/kendo.modernizr.custom.js"
                        ));

            //--------------------------------------------------------------------------------------------------------------

            //-- Styles Bundles --
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                     "~/Content/reset.css",
                     //"~/Content/bootstrap.min.css",
                     "~/Content/bootstrap.css"
                     ));

            bundles.Add(new StyleBundle("~/fonts/font-awesome/css/font-awesome").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css"
                      ));

            bundles.Add(new StyleBundle("~/fonts/Ionicons/css/ionicons").Include(
                     //"~/fonts/Ionicons/css/ionicons.min.css",
                      "~/fonts/Ionicons/css/ionicons.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                      "~/Content/AdminLTE.css",
                      "~/Content/all-skins.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css",
                        "~/Content/style.css"
                        ));

            bundles.Add(new StyleBundle("~/Content/kendo/2017.1.118/kendo").Include(
                      "~/Content/kendo/2017.1.118/kendo.common.min.css",
                      "~/Content/kendo/2017.1.118/kendo.mobile.all.min.css",
                      "~/Content/kendo/2017.1.118/kendo.dataviz.min.css",
                      "~/Content/kendo/2017.1.118/kendo.cardiosence.css",
                      "~/Content/kendo/2017.1.118/kendo.dataviz.default.min.css"));

        }
    }
}
