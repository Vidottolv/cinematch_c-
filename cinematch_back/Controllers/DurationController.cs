using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cinematch_back.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DurationController : ControllerBase
    {
        private readonly IDurationRepository _durationMovie;
        public DurationController (IDurationRepository durationMovie)
        {
            _durationMovie = durationMovie; 
        }
        [HttpGet]
        public async Task<ActionResult<List<DurationModel>>> GetAll()
        {
            List<DurationModel> getReturn = await _durationMovie.GetAll();
            return Ok(getReturn);

        }
    }
}
