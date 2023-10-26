using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Repository;

namespace WebApiProvaFaseA.Service
{
    public class ProdottoService : IProdottoService
    {
        private IProdottoRepository _repository;
        public ProdottoService(IProdottoRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> AddProdotto(Prodotto prodotto)
        {
            try
            {
                return await _repository.AggiungiProdotto(prodotto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
