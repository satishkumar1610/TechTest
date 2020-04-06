#region Using namespace

using System.Web.Optimization;

#endregion

#region Namespace

/// <summary>
/// TechTest namespace
/// </summary>
namespace TechTest
{
    #region Public BundleConfig class

    /// <summary>
    /// BundleConfig class
    /// </summary>
    public class BundleConfig
    {
        #region Public static methods

        /// <summary>
        /// Static method to register scripts, css files in bundle
        /// </summary>
        /// <param name="bundles">Input bundle collection object</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }

        #endregion
    }

    #endregion
}

#endregion
