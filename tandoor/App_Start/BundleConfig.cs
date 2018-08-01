using System.Web;
using System.Web.Optimization;

namespace tandoor
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/animate.css",
                "~/Content/icomoon.css",
                "~/Content/bootstrap.css",
                "~/Content/owl.carousel.min.css",
                "~/Content/owl.theme.default.min.css",
                "~/Content/magnific-popup.css",
                "~/Content/flexslider.css",
                "~/Content/bootstrap-datepicker.css",
                "~/Content/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Indexjs").Include(
                "~/Scripts/modernizr-2.6.2.min.js",
              "~/Scripts/jquery-3.3.1.min.js",
              "~/Scripts/jquery.easing.1.3.js",
              "~/Scripts/bootstrap.min.js",
              "~/Scripts/jquery.waypoints.min.js",
              "~/Scripts/jquery.stellar.min.js",
              "~/Scripts/owl.carousel.min.js",
              "~/Scripts/jquery.flexslider-min.js",
              "~/Scripts/bootstrap-datepicker.js",
              "~/Scripts/main.js",
              "~/Scripts/magnific-popup-options.js",
              "~/Scripts/jquery.magnific-popup.min.js"
              ));
        }
    }
}