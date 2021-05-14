using HRM.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly IHRMRepository _hrmRepository;

        public CountryController(IHRMRepository hrmRepository)
        {
            _hrmRepository = hrmRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_hrmRepository.GetAllCountries());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetCountryById(int id)
        {
            return Ok(_hrmRepository.GetCountryById(id));
        }
    }
}
