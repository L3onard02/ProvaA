using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Entities;
using WebAPIVenditaLibri.DataSource;

namespace WebApiProvaFaseA.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private ProvaContext _context;
        public ClienteRepository(ProvaContext context)//injection
        {
            _context = context;

        }
        public async Task<int> AggiornaCliente(int id, Cliente c)
        {
            try
            {
                c.IdentificativoCliente = id;
                _context.Entry(c).State = EntityState.Modified;
                int numeroRecordsModificati = await _context.SaveChangesAsync();
                if (numeroRecordsModificati != 1)
                {
                    string messaggioErrore = "Operazione di modifica non effettuata";
                    throw new Exception(messaggioErrore);
                }
                return numeroRecordsModificati;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> CreaCliente(Cliente c)
        {
            try
            {
                _context.Entry(c).State = EntityState.Added;
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


        public async Task<Cliente> RestituisciCliente(int id)
        {
            try
            {
                Cliente c = await _context.Clienti.FindAsync(id);
                return c;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Cliente>> RestituisciClienti()
        {
            try
            {
                var lista = await _context.Clienti.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
