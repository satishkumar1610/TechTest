#region Using namespace

using System.Web.Http;

#endregion

#region Namespace

/// <summary>
/// Process input Api namespace
/// </summary>
namespace ProcessInputAPI
{
    #region WebApiConfig class

    /// <summary>
    /// Static class for web api configuration
    /// </summary>
    public static class WebApiConfig
    {
        #region Public methods

        /// <summary>
        /// statuc method to register routes attributes
        /// </summary>
        /// <param name="config">Pass http configuration</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Index",
                routeTemplate: "{id}.html",
                defaults: new { id = "index" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        #endregion
    }

    #endregion
}

#endregion
