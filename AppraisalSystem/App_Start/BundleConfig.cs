using System.Web;
using System.Web.Optimization;

namespace AppraisalSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/sweetalert/js").Include(
                        "~/Content/sweetalert/sweetalert2.all.js"));

            bundles.Add(new ScriptBundle("~/bundles/sweetalert/css").Include(
                        "~/Content/sweetalert/sweetalert2.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-migrate-{version}.js",
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.css.map",
                      "~/Content/bootstrap-grid.css",
                      "~/Content/bootstrap-grid.css.map",
                      "~/Content/bootstrap-grid.min.css",
                      "~/Content/bootstrap-grid.min.css.map",
                      "~/Content/bootstrap-reboot.css",
                      "~/Content/bootstrap-reboot.css.map",
                      "~/Content/bootstrap-reboot.min.css",
                      "~/Content/bootstrap-reboot.min.css.map",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content2/css").Include(
                      "~/Content2/animate.css",
                      "~/Content2/animate.min.css",
                      "~/Content2/font-awesome.min.css",
                      "~/Content2/style.css",
                      "~/Content2/sidebar.css",
                      "~/Content2/w3.css"));

            //Add this for jQueryUI
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
                "~/Content/jquery-ui.css"));
        }
    }
}
