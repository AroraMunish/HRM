using HRM.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : Controller
    {
        private readonly IHRMRepository _hrmRepository;

        public JobCategoryController(IHRMRepository hrmRepository)
        {
            _hrmRepository = hrmRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetJobCategories()
        {
            return Ok(_hrmRepository.GetAllJobCategories());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetJobCategoryById(int id)
        {
            return Ok(_hrmRepository.GetJobCategoryById(id));
        }
    }
}
