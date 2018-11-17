using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using KFUPMSS.Model;
using Newtonsoft.Json;

namespace KFUPMSS.Services
{
    public class ApiServices
    {


        public ApiServices()
        {
        }

        internal async Task<bool> RegisterAsync(string firstName, string lastName, string id, string password)
        {

            var client = new HttpClient();

            var user = new User
            {

                FirstName = firstName,

                LastName = lastName,

                ID = id,

                Password = password

            };

            var json = JsonConvert.SerializeObject(user);


            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync("https://seniorproject003kfupm.firebaseio.com/Users", content);

            return response.IsSuccessStatusCode;  

        }
    }
}
