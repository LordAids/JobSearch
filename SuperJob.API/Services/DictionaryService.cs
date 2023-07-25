using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperJob.API.DTO;
using SuperJob.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperJob.API.Services
{
    public class DictionaryService : IDictionaryService
    {
        static HttpClient httpClient = new HttpClient();
        public DictionaryService() { }

        public async Task<List<CityDTO>> GetCities()
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.superjob.ru/2.0/towns/?all=1&id_country=1");
            using var responce = httpClient.SendAsync(request).Result;
            string responseText = await responce.Content.ReadAsStringAsync();

            JObject citiesJSON = JObject.Parse(responseText);

            var cities = JsonConvert.DeserializeObject<List<ApiCityDTO>>(citiesJSON["objects"].ToString());

            var res = cities.Select(r => new CityDTO()
            {
                Id = r.id,
                Name = r.title,
                NameEng = r.title_eng
            }).ToList();


            return res;
        }
    }
}
