using System.Web.Optimization;

namespace Website.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-1.2.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/requirejs").Include(
                        "~/Scripts/require.js",
                        "~/Scripts/r.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/styles.css"
                      //"~/Content/ng-table.css",
                      //"~/Content/ng-grid.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css"));
            //"~/Content/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/ng-grid.js",
                        "~/Scripts/ng-table.js",
                        "~/Scripts/angular-ui/ui-bootstrap.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/App/app.js",
                        "~/App/directives/mainDirective.js",
                        "~/App/services/service.js",
                        "~/App/services/modelService.js",
                        "~/App/services/weatherService.js",
                         "~/App/services/weatherService.js",
                          "~/App/controllers/mainController.js",
                        "~/App/controllers/weatherController.js",
                        "~/App/controllers/aboutController.js",
                        "~/App/controllers/contactController.js"));
        }
    }
}