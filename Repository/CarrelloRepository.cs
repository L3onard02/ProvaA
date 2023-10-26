using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Entities;
using WebAPIVenditaLibri.DataSource;

namespace WebApiProvaFaseA.Repository
{
    public class CarrelloRepository : ICarrelloRepository
    {
        private ProvaContext _context;
        public CarrelloRepository(ProvaContext context)
        {
            _context = context;

        }
        public async Task<int> Aggiunta(Carrello carrello,int id)
        {
            try
            {
                
                var giacenzap=(from p in _context.Prodotti
                              where p.IdentificativoProdotto==carrello.ProdottoIdentificativoProdotto
                              select p.Giacenza).FirstOrDefault();
                if (giacenzap> carrello.Quantità)
                {
                    string messaggioErrore = "Giacenza insufficente";
                    throw new Exception(messaggioErrore);
                }
                


                _context.Entry(carrello).State = EntityState.Added;
                int numeroRecordsInseriti = await _context.SaveChangesAsync();
               
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inserimento non effettuata";
                    //_logger.LogError("operazione non andata a buon fine");
                    throw new Exception(messaggioErrore);
                }

                var giacenzap1 = from p in _context.Prodotti
                                 where p.IdentificativoProdotto == carrello.ProdottoIdentificativoProdotto
                                 select p.Giacenza - carrello.Quantità;
                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Carrello> Visualizzazione(int id)
        {
            try
            {
                var carrello = await _context.Carrelli.Where(p => p.IdentificativoCarrello == id).SingleAsync();
                //Prodotto p=await _libreria.Prodotti.FindAsync(id);
                return carrello;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
