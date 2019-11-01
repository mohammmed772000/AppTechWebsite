using System.Web;
using System.Web.Optimization;

namespace AppTech.Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
         
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-1.12.4.min.js",
                "~/Scripts/jquery-ui.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/frenchi/owl.carousel.min.js",
                //"~/Scripts/contact-form.js",
                "~/Scripts/frenchi/ajaxchimp.js",
                "~/Scripts/frenchi/scrollUp.min.js",
                "~/Scripts/frenchi/magnific-popup.min.js",
                "~/Scripts/frenchi/wow.min.js",
                "~/Scripts/frenchi/main.js"

            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome/4.5.0/css/font-awesome.min.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/linearicons.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/animate.css",
                      "~/Content/normalize.css",
                      "~/Content/frenchi.style.css",
                      "~/Content/responsive.css"
                      ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));


        }
    }
}
