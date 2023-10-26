using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Repository
{
    public interface IClienteRepository
    {
        Task<int> CreaCliente(Cliente c);
        Task<List<Cliente>> RestituisciClienti();
        Task<Cliente> RestituisciCliente(int id);
        Task<int> AggiornaCliente(int id,Cliente c);

    }
}
