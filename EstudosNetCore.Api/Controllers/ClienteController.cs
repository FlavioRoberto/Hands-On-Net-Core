using EstudosNetCore.Api.Application.UserCases.Clientes.Consultar;
using Microsoft.AspNetCore.Mvc;

namespace EstudosNetCore.Api.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IConsultarClienteUserCase _consultarClienteUserCase;

        public ClienteController(IConsultarClienteUserCase consultarClienteUserCase)
        {
            _consultarClienteUserCase = consultarClienteUserCase;
        }

        /*
         * CLEAN ARCHITECTURE - Domain Driven Design (DDD)
         * Hexagonal -> microserviços
         * Apresentation => ignorar pois vai ser a api (Controller)
         * Application => preparar os dados que serão apresentados -> httpServices, mapeamentos de vm para model, etc
         * Infra => comunicação externa, serviços de terceiros (HTTP, TCP, BUS, BD)
         * Domain => entidades e regras de negócio
        */

        [HttpGet("{numero_documento}")]
        public ActionResult Consultar(string numero_documento)
        {
            return Ok(_consultarClienteUserCase.Executar(numero_documento));
        }

        [HttpGet]
        public ActionResult ConsultarQuery([FromQuery] string numero_documento)
        {
            return Ok($"Funcionando query parameter... {numero_documento}");
        }
    }

   
}
