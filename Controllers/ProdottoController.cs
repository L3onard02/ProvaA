using Microsoft.AspNetCore.Mvc;
using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProvaFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottoController : ControllerBase
    {
        private IProdottoService _service;
        public ProdottoController(IProdottoService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Prodotto p)
        {
            int numeroRecord = 0;
            try
            {
                numeroRecord = await _service.AddProdotto(p);
                return Ok();
            }
            catch (Exception ex)
            {
                //return Problem(ex.Message);
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
