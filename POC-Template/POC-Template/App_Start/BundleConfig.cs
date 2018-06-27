using System.Web;
using System.Web.Optimization;

namespace POC_Template
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //start js file scripts
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/assets/bundles").Include(
                       "~/assets/bundles/libscripts.bundle.js",
                       "~/assets/bundles/vendorscripts.bundle.js",
                       "~/assets/bundles/knob.bundle.js",
                       "~/assets/bundles/sparkline.bundle.js",
                       "~/assets/bundles/mainscripts.bundle.js"
                      ));

            bundles.Add(new ScriptBundle("~/assets/plugins").Include(
                      "~/assets/plugins/chartjs/Chart.bundle.js",
                      "~/assets/plugins/chartjs/polar_area_chart.js"));


            bundles.Add(new ScriptBundle("~/assets/js").Include(
          "~/assets/js/pages/index.js",
          "~/assets/js/pages/profile.js",
          "~/assets/js/pages/blog/blog.js",
          "~/assets/js/pages/calendar/calendar.js",
          "~/assets/js/pages/charts/chart-widgets.js",
          "~/assets/js/pages/charts/chartjs.js",
          "~/assets/js/pages/charts/flot.js",
          "~/assets/js/pages/charts/jquery-knob.js",
          "~/assets/js/pages/charts/morris.js",
          "~/assets/js/pages/charts/polar_area_chart.js",
          "~/assets/js/pages/charts/sparkline.js",
          "~/assets/js/pages/file/filemanager.js",
          "~/assets/js/pages/forms/advanced-form-elements.js",
          "~/assets/js/pages/forms/basic-form-elements.js",
          "~/assets/js/pages/forms/editors.js",
          "~/assets/js/pages/forms/form-validation.js",
          "~/assets/js/pages/forms/form-wizard.js",
          "~/assets/js/pages/maps/google.js",
          "~/assets/js/pages/maps/jvectormap.js",
          "~/assets/js/pages/medias/image-gallery.js",
          "~/assets/js/pages/tables/editable-table.js",
          "~/assets/js/pages/tables/jquery-datatable.js",
          "~/assets/js/pages/ui/dialogs.js",
          "~/assets/js/pages/ui/notifications.js",
          "~/assets/js/pages/ui/range-sliders.js",
          "~/assets/js/pages/ui/sortable-nestable.js",
          "~/assets/js/pages/widgets/infobox/infobox-1.js"
          ));

            //START CSS FILES STYLES

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/assets/plugins").Include(
                      "~/assets/plugins/bootstrap/css/bootstrap.min.css",
                      "~/assets/plugins/morrisjs/morris.css",
                      "~/assets/plugins/jvectormap/jquery-jvectormap-2.0.3.min.css"
                      ));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/blog.css",
                      "~/assets/chatapp.css",
                      "~/assets/color_skins.css",
                      "~/assets/inbox.css",
                      "~/assets/main.css",
                      "~/assets/timeline.css"
                      ));


        }
    }
}
