using cinematch_back.Data.Map;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindController : ControllerBase
    {
        private readonly IKindRepository _kindRepository;
        public KindController(IKindRepository kindRepository)
        {
            _kindRepository = kindRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<KindModel>>> GetKind()
        {
            List<KindModel> getReturn = await _kindRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
