using JobSearch.Data;
using SuperJob.API.Interfaces;

namespace JobSearch
{
    public class DataSeeder
    {
        private IDictionaryService _dictionaryService;

        public DataSeeder(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        public async void SeedCities(ApplicationDbContext context)
        {
            var cities = await _dictionaryService.GetCities();
            var citiesDb = context.City;

            if(!cities.Any())
            {
                await context.City.AddRangeAsync(cities.Select(s => new Data.Entities.City
                {
                    SuperJobId = s.Id,
                    Name = s.Name,
                }));
                return; 
            }

            foreach (var c in cities)
            {
                var city = citiesDb.FirstOrDefault(s => s.Name == c.Name);
                if(city != null)
                {
                    city.SuperJobId = c.Id;
                    context.City.Update(city);
                }
            }




        }

    }
}
