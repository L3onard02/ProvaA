using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Service
{
    public interface ICarrelloService
    {
        Task<int> Update(Carrello carrello, int id);
        Task<Carrello> GetFromId(int id);
    }
}
