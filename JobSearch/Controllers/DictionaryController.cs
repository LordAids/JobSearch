using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperJob.API.Interfaces;

namespace JobSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        private readonly IDictionaryService _dictionaryService;
        public DictionaryController(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        [HttpGet("GetCities")]
        public async Task<IActionResult> GetCities()
        {
            var res = await _dictionaryService.GetCities();
            return Ok(res);
        }



    }
}
