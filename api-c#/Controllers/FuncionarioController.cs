using api_c_.Models;
using api_c_.Service.FuncionarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_c_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioInterface _funcionarioInterface;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;

        }


        [HttpGet]

        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _funcionarioInterface.GetFuncionarios());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
        }
    }
}
