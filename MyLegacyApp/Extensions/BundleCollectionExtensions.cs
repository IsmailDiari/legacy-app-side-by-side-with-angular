using System.Web.Optimization;

namespace MyLegacyApp.Extensions
{
    public static class BundleCollectionExtensions
    {
        public static void AddScripts(this BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new Bundle("~/bundles/angular/common").Include(
                      "~/Scripts/Angular/build_package/polyfills.*",
                      "~/Scripts/Angular/build_package/runtime.*"
                      ));

            bundles.Add(new Bundle("~/bundles/angular/hello-world").Include(
                      "~/Scripts/Angular/build_package/hello_world.*"
                      ));
            bundles.Add(new Bundle("~/bundles/angular/shared/another-module").Include(
                      "~/Scripts/Angular/build_package/another_module.*"
                      ));
        }
        public static void AddStyles(this BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/angular/common").Include(
                "~/Scripts/Angular/build_package/styles.*"));
        }
    }
}