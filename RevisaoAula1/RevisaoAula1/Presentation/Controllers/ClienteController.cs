using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevisaoAula1.Application.Interfaces;

namespace RevisaoAula1.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClienteController(IClientService clientService)
        {
            _clientService=clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clientService.GetAllClientes();
            return Ok(clientes);
        }
    }
}
