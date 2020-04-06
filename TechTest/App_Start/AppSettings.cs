#region Using Namespase

using System.Configuration;

#endregion

#region Namespace

/// <summary>
/// TechTest app start namespace
/// </summary>
namespace TechTest.App_Start
{
    #region AppSetting class

    /// <summary>
    /// AppSetting class
    /// </summary>
    public class AppSettings
    {
        #region Public properties

        /// <summary>
        /// Public property return Api url from webconfig
        /// </summary>
        public string ApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["PersonInputAPI"].ToString();
            }
        }

        #endregion
    }

    #endregion
}

#endregion
