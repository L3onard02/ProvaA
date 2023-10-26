using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Repository
{
    public interface ICarrelloRepository
    {
        Task<int> Aggiunta(Carrello carrello,int id);
        Task<Carrello> Visualizzazione(int id);
       
    }
}
