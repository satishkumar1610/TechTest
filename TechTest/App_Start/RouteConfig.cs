#region Using namespace

using System.Web.Mvc;
using System.Web.Routing;

#endregion

#region Namespace

/// <summary>
/// Techtest namespace
/// </summary>
namespace TechTest
{
    #region RouteConfig class

    /// <summary>
    /// Route config class
    /// </summary>
    public class RouteConfig
    {
        #region Public static methods

        /// <summary>
        /// static method to register routes path
        /// </summary>
        /// <param name="routes">Input RouteCollection object</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        #endregion
    }

    #endregion
}

#endregion
