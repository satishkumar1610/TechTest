#region Using namespace

using System.Web.Mvc;

#endregion

#region Namespace

/// <summary>
/// TechTest namespace
/// </summary>
namespace TechTest
{
    #region FilterConfig class

    /// <summary>
    /// FilterConfig pulic class
    /// </summary>
    public class FilterConfig
    {
        #region Public static methods

        /// <summary>
        /// Static method to register global filters
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        #endregion
    }

    #endregion
}

#endregion

