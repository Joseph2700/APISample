using APISample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Services
{
    public class ApiService : IApiService
    {
        public async Task<Track> GetTrackInfo(string id)
        {
            const string url = "https://api.deezer.com/track/";
            const string key = "/?key=d2a972c2f5msh113d51ba527d802p15f169jsn1ca2a15eb020";
            HttpClient httpClient = new HttpClient();            
            var result = await httpClient.GetStringAsync($"{url}{id}{key}");
            return JsonConvert.DeserializeObject<Track>(result);
        }
    }
}
