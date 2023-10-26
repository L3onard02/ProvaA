using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Service
{
    public interface IProdottoService
    {
        Task<int> AddProdotto(Prodotto prodotto);
    }
}
