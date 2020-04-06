#region Using namespaces

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessInputAPI.Controllers;
using ProcessInputAPI.Models;
using System.Web.Http.Results;

#endregion

#region Namespace

namespace ProcessInputAPI.Test
{
    #region Unit test class containing unit test method for web api

    [TestClass]
    public class UnitTestAPI
    {
        #region Public unit test methods

        [TestMethod]
        public void ProcessPersonDetail()
        {
            //Arrange
            RenderPersonController renderPersonController = new RenderPersonController();
            Person person = new Person();
            person.Name = "John Smith";
            person.Amount = "123.45";
            string expectedResult = "One Hundred And Twenty-Three Dollars And Fourty-Five Cents";
            
            //Act
            var response = renderPersonController.ProcessPerson(person);
            var contentResult = response as OkNegotiatedContentResult<Person>;
            
            //Assert
            Assert.AreEqual(expectedResult, person.AmountInWord);
        }

        #endregion
    }

    #endregion
}

#endregion
