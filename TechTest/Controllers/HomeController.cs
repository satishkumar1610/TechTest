#region Using namespace

using System;
using System.Web.Mvc;
using TechTest.ApiClient;
using TechTest.Models;

#endregion

#region Namespace

/// <summary>
/// TechTest controller namespace
/// </summary>
namespace TechTest.Controllers
{
    #region HomeController class

    /// <summary>
    /// Home controller class
    /// </summary>
    public class HomeController : Controller
    {
        #region Public action methods

        /// <summary>
        /// Index action method
        /// </summary>
        /// <returns>Returns index view</returns>
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Person action method process form input
        /// </summary>
        /// <param name="person">Input Person object</param>
        /// <returns>Returns Person object after processing</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Person(Person person)
        {
            ProcessInputApi processInput = new ProcessInputApi();
            ModelState.Remove("AmountInWord");

            if (ModelState.IsValid)
            {
                person = processInput.ProcessPerson(person);
                
                if (string.IsNullOrEmpty(person.AmountInWord))
                {
                    ModelState.AddModelError("Amount", "Unable to convert amount into word");
                    return View("Index");
                }
                
                return View(person);
            }

            return View("Index");
        }

        #endregion
    }

    #endregion
}

#endregion
