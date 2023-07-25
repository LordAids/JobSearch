using SuperJob.API.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJob.API.Interfaces
{
    public interface IDictionaryService
    {
        public Task<List<CityDTO>> GetCities();
    }
}
