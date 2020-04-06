#region Using namespace

using System.Web.Http;

#endregion

#region Namespace

/// <summary>
/// Process input api namespace
/// </summary>
namespace ProcessInputAPI
{
    #region WebApiApplication class

    /// <summary>
    /// Web api application class
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        #region Protected metods

        /// <summary>
        /// Application start protected method
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        #endregion
    }

    #endregion
}

#endregion
