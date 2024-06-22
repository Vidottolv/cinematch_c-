using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DurationController : ControllerBase
    {
        private readonly IDurationMovie _durationMovie;
        public DurationController (IDurationMovie durationMovie)
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
