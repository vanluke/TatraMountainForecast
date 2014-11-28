using System.Web.Optimization;

namespace App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"
                 ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-loader.js",
                "~/Scripts/angular-resource.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(//.IncludeDirectory("~/app/controllers", "*js")
                "~/app/app.js",
                "~/app/register-module.js"
                ));
            BundleTable.EnableOptimizations = true;

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css"
                ));
        }
    }
}