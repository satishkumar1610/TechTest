#region Using namespace

using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

#endregion

#region Namespace

/// <summary>
/// TechTest namespace
/// </summary>
namespace TechTest
{
    #region Public class

    /// <summary>
    /// MvcApplication class
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Protected methods

        /// <summary>
        /// Application start protexcted method to register area, filter, route config and bundle config
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        #endregion
    }

    #endregion
}

#endregion
