using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Entities;
using WebAPIVenditaLibri.DataSource;

namespace WebApiProvaFaseA.Repository
{
    public class ProdottoRepository : IProdottoRepository
    {
        private ProvaContext _context;
        public ProdottoRepository(ProvaContext context)//injection
        {
            _context = context;

        }

        public async Task<int> AggiungiProdotto(Prodotto p)
        {
            try
            {
                _context.Entry(p).State = EntityState.Added;
                int numeroRecordsInseriti = await _context.SaveChangesAsync();
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inserimento non effettuata";
                    //_logger.LogError("operazione non andata a buon fine");
                    throw new Exception(messaggioErrore);
                }
                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
