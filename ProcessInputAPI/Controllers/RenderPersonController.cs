#region Using namespaces

using ProcessInput;
using ProcessInputAPI.Models;
using System;
using System.Web.Http;

#endregion

#region Namespace

/// <summary>
/// Process input api controller namesapce
/// </summary>
namespace ProcessInputAPI.Controllers
{
    #region Render Person API controller

    /// <summary>
    /// Render person api controller class
    /// </summary>
    public class RenderPersonController : ApiController
    {
        #region Private variable

        /// <summary>
        /// Private variable
        /// </summary>
        private ProcessLogic processLogic;

        #endregion

        #region Public constructor

        /// <summary>
        /// Public constructor of render person controller class
        /// </summary>
        public RenderPersonController()
        {
            processLogic = new ProcessLogic();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Public method to process person details
        /// </summary>
        /// <param name="person">Input person object</param>
        /// <returns>Returns person object after processing</returns>
        [HttpPost]
        public IHttpActionResult ProcessPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }

            decimal amount = Convert.ToDecimal(person.Amount);
            person.AmountInWord = processLogic.NumberToWord(amount);

            return Ok(person);
        }

        #endregion
    }

    #endregion
}

#endregion
