using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndController : ControllerBase
    {
        private readonly IEndRepository _endRepository;
        public EndController(IEndRepository endRepository)
        {
            _endRepository = endRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<EndModel>>> GetEnd()
        {
            List<EndModel> getReturn = await _endRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
