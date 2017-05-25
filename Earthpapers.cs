using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic; // Dictionary type
using System.Text;                // UTF8Encoding()
using System.Net.Http;            // HTTP Requests
using System.Net.Http.Headers;

namespace Earthpapers {
    public class Program {
        static void Main() {
            AsyncPost().Wait();

            Application.Run(new MainWindow());
        }

        static async Task AsyncPost() {
            // Setting address, and sets the Accept header to receive data in JSON format
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.reddit.com/");

            // Set up HTTP Basic Auth, Headers, and POST Parameters
            var byteArray = new UTF8Encoding().GetBytes("3t_-WJLzczPgpA:_JaZMwTVcjGpNoDialnkLecFoX8");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            client.DefaultRequestHeaders.Add("User-Agent", "Testing POST requests for app");
            var data = new Dictionary<string, string>() {
                {"grant_type", "client_credentials"}
            };
            var content = new FormUrlEncodedContent(data);

            // Let's see if it works
            var response = await client.PostAsync("api/v1/access_token", content);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response);
        }
    }
}