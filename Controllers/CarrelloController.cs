using Microsoft.AspNetCore.Mvc;
using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProvaFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrelloController : ControllerBase
    {
        private ICarrelloService _service;
        public CarrelloController(ICarrelloService service)
        {
            _service = service;
        }

        // GET api/<CarrelloController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrello>>Get(int id)
        {
            if (id < 1) return NotFound("id minore a 1");

            try
            {
                var lista = await _service.GetFromId(id);
                return lista;

            }
            catch (Exception ex)
            {

                return Problem("Al momento non è possibile soddisfare la richiesta");
            }
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Carrello c)
        {
            if (id < 1) return NotFound("id minore a 1");

            int numeroRecord = 0;

            try
            {

                numeroRecord = await _service.Update(c,id);
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
