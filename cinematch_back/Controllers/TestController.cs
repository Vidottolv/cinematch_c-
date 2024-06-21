using Microsoft.AspNetCore.Mvc;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;

namespace cinematch_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ITestRepository _testRepository;

        public TesteController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TestModel>>> BuscarTodosOsUsuarios()
        {
            List<TestModel> getReturn = await _testRepository.GetAll();
            return Ok(getReturn);
        }
    }
}
