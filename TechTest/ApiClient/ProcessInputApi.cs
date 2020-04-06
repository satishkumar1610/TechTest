#region Using namespace

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using TechTest.App_Start;
using TechTest.Models;

#endregion

#region Namespace

/// <summary>
/// TechTest Api Client namespace
/// </summary>
namespace TechTest.ApiClient
{
    #region Public class ProcessInputApi

    /// <summary>
    /// Process input api class
    /// </summary>
    public class ProcessInputApi
    {
        #region Public methods

        /// <summary>
        /// Process person input
        /// </summary>
        /// <param name="person">Input person object</param>
        /// <returns>Returns person object after processing</returns>
        public Person ProcessPerson(Person person)
        {
            using (HttpClient client = new HttpClient())
            {
                AppSettings appSettings = new AppSettings();
                client.BaseAddress = new Uri(appSettings.ApiUrl + "/api/RenderPerson/ProcessPerson");

                var jsonPerson = JsonConvert.SerializeObject(person);
                var data = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
                var response = client.PostAsync("person", data);
                response.Wait();

                if (!response.Result.IsSuccessStatusCode)
                {
                    return person;
                }

                var result = response.Result.Content.ReadAsStringAsync().Result;
                Person personResult = JsonConvert.DeserializeObject<Person>(result);
                
                return personResult;
            }
        }

        #endregion
    }

    #endregion
}

#endregion
