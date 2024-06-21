using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cinematch_back.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AgeController : ControllerBase
    {
        private readonly IAgeRepository _ageRepository;

        public AgeController(IAgeRepository ageRepository)
        {
            _ageRepository = ageRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<AgeModel>>> GetGenres()
        {
            List<AgeModel> getReturn = await _ageRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
