using Microsoft.Extensions.Options;
using Netflix.WPFApp.Interfaces;
using Netflix.WPFApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Netflix.WPFApp
{
    public class Client : IClient
    {

        public readonly AppSettings Settings;
        // TODO: Add logging
        //public readonly ILogger<Client> _logger;

        public Client(IOptions<AppSettings> Settings)
        //, ILogger<Client> logger
        {
            this.Settings = Settings.Value;
            //_logger = logger;

        }

        public async Task<IEnumerable<Netflix.WPFApp.Models.Netflix>> BindEmployeeList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.BaseAddress = new Uri(Settings.APIURI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(Settings.APIResource).Result;
            if (response.IsSuccessStatusCode)
            {
                var employees = await response.Content.ReadAsAsync<IEnumerable<Netflix.WPFApp.Models.Netflix>>();

                return employees;
            }
            else
            {
                //_logger.LogError("API response is unsuccessfu");
                throw new Exception("API response is unsuccessfu");
            }

        }
    }
}
