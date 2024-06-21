using Microsoft.AspNetCore.Mvc;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryTypeController : ControllerBase
    {
        private readonly IStoryTypeRepository _storytypeRepository;
    
        public StoryTypeController(IStoryTypeRepository storytypeRepository)
        {
            _storytypeRepository = storytypeRepository;
        }
    
        [HttpGet]
        public async Task<ActionResult<List<StoryTypeModel>>> GetGenres()
        {
            List<StoryTypeModel> getReturn = await _storytypeRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
