using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Repository
{
    public interface IProdottoRepository
    {
        Task<int> AggiungiProdotto(Prodotto p);
    }
}
