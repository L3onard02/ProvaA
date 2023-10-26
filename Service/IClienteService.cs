using WebApiProvaFaseA.DTOs;
using WebApiProvaFaseA.Entities;

namespace WebApiProvaFaseA.Service
{
    public interface IClienteService
    {
        Task<int> AddCliente(CreaClienteDTO cDTO);
        Task<List<Cliente>> GetClienti();
        Task<RestituisciClienteDTO> GetCliente(int id);
        Task<int> UpdatePassword(int id, AggiornamentoPasswordDTO cDTO);
    }
}
