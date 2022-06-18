using System.Web;
using System.Web.Optimization;

namespace SmartStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/vendors/modernizr/modernizr.js"));


            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                      "~/Content/vendors/underscore/underscore.js",
                       "~/Content/vendors/underscore/underscore.string.js",
                       "~/Content/vendors/jquery/jquery.addeasing.js",
                       "~/Content/vendors/jquery-ui/effect.js",
                       "~/Content/vendors/jquery-ui/effect-shake.js",
                       "~/Content/vendors/jquery/jquery.unobtrusive-ajax.js",
                       "~/Content/vendors/jquery/jquery.validate.js",
                       "~/Content/vendors/jquery/jquery.validate.unobtrusive.js",

                       "~/Content/vendors/jquery/jquery.ba-outside-events.js",
                       "~/Content/vendors/jquery/jquery.scrollTo.js",
                       "~/Content/vendors/moment/moment.js",
                       "~/Content/vendors/datetimepicker/js/tempusdominus-bootstrap-4.js",
                       "~/Content/vendors/select2/js/select2.js",
                       "~/Content/vendors/select2/js/i18n/*.js",
                       "~/Content/vendors/moment/locale/*.js",
                       "~/Content/vendors/pnotify/js/pnotify.js",
                       "~/Content/vendors/pnotify/js/pnotify.mobile.js",
                        "~/Content/vendors/pnotify/js/pnotify.buttons.js",
                        "~/Content/vendors/pnotify/js/pnotify.animate.js",
                        "~/Content/vendors/slick/slick.js",
                        "~/Content/vendors/touchspin/jquery.bootstrap-touchspin.js",
                        "~/Content/vendors/aos/js/aos.js",

                      "~/Content/bs4/js/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                      "~/Scripts/underscore.mixins.js",
                       "~/Scripts/smartstore.system.js",
                       "~/Scripts/smartstore.touchevents.js",
                       "~/Scripts/smartstore.jquery.utils.js",
                       "~/Scripts/smartstore.globalization.js",
                       "~/Scripts/smartstore.globalization.adapter.js",
                       "~/Scripts/jquery.validate.unobtrusive.custom.js",
                       "~/Scripts/smartstore.viewport.js",

                       "~/Scripts/smartstore.doAjax.js",
                       "~/Scripts/smartstore.eventbroker.js",
                       "~/Scripts/smartstore.hacks.js",
                       "~/Scripts/smartstore.common.js",
                       "~/Scripts/smartstore.dialogs.js",
                       "~/Scripts/smartstore.selectwrapper.js",
                       "~/Scripts/smartstore.throbber.js",
                       "~/Scripts/smartstore.thumbzoomer.js",
                       "~/Scripts/smartstore.responsiveNav.js",
                        "~/Scripts/smartstore.keynav.js",
                        "~/Scripts/smartstore.articlelist.js",
                        "~/Scripts/smartstore.megamenu.js",
                        "~/Scripts/smartstore.offcanvas.js",
                        "~/Scripts/smartstore.parallax.js",

                      "~/Scripts/smartstore.media.js"));

            bundles.Add(new ScriptBundle("~/bundles/shop").Include(
                "~/Scripts/public.common.js",
                "~/Scripts/public.search.js",
                "~/Scripts/public.offcanvas-cart.js",
                "~/Scripts/public.offcanvas-menu.js",
                "~/Scripts/public.product.js"));

            bundles.Add(new StyleBundle("~/Content/pnotify").Include(
                     "~/Content/vendors/pnotify/css/pnotify.css",
                     "~/Content/vendors/pnotify/css/pnotify.mobile.css",
                     "~/Content/vendors/pnotify/css/pnotify.buttons.css",
                     "~/Content/vendors/fa5/css/all.css",
                     "~/Content/fontastic/fontastic.css"
                     ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/theme.css",
                      "~/Content/site.css"));
        }
    }
}
