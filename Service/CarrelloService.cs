using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Repository;

namespace WebApiProvaFaseA.Service
{
    public class CarrelloService : ICarrelloService
    {
        private ICarrelloRepository _repository;
        public CarrelloService(ICarrelloRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Update(Carrello carrello, int id)
        {
            try
            {
                
                return await _repository.Aggiunta(carrello,id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Carrello> GetFromId(int id)
        {
            try
            {
                return await _repository.Visualizzazione(id);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
