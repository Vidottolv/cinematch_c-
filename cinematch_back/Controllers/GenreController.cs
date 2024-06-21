using Microsoft.AspNetCore.Mvc;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;
    
        public GenreController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
    
        [HttpGet]
        public async Task<ActionResult<List<GenreModel>>> GetGenres()
        {
            List<GenreModel> getReturn = await _genreRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
