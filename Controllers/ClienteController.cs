using Microsoft.AspNetCore.Mvc;
using WebApiProvaFaseA.DTOs;
using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProvaFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetAll()
        {
            try
            {
                var lista = await _service.GetClienti();
                return lista;

            }
            catch (Exception ex)
            {

                return Problem("Al momento non è possibile soddisfare la richiesta");
            }
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestituisciClienteDTO>> Get(int id)
        {
            if (id < 1) return NotFound("id minore a 1");

            try
            {
                var lista = await _service.GetCliente(id);
                return lista;

            }
            catch (Exception ex)
            {

                return Problem("Al momento non è possibile soddisfare la richiesta");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreaClienteDTO cliente)
        {
            int numeroRecord = 0;
            
            try
            {

                
                numeroRecord = await _service.AddCliente(cliente);
                return Ok();
            }
            catch (Exception ex)
            {
                if (numeroRecord != 1)
                {
                    return Problem("Operazione non effettuata");
                }
                else
                {
                    return Problem("Problemi di connessione");

                }

            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AggiornamentoPasswordDTO password)
        {
            if (id < 1) return NotFound("id minore a 1");

            int numeroRecord = 0;

            try
            {

                numeroRecord = await _service.UpdatePassword(id,password);
                return Ok();
            }
            catch (Exception ex)
            {
                
                if (numeroRecord != 1)
                {
                    return Problem("Operazione non effettuata");
                }
                else
                {
                    return Problem("Problemi di connessione");

                }

            }
        }

        
    }
}
