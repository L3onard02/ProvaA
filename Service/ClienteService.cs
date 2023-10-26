using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using WebApiProvaFaseA.DTOs;
using WebApiProvaFaseA.Entities;
using WebApiProvaFaseA.Repository;

namespace WebApiProvaFaseA.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;
        private ILogger<string> _logger;
        public ClienteService(IClienteRepository repository,ILogger<string> logger)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<int> AddCliente(CreaClienteDTO cDTO)
        {
            DateTime presente = DateTime.Now;
            int età = presente.Year - cDTO.DataDiNascita.Year;
            string email = cDTO.Email;
            try
            {
                if (età < 18)
                {
                    _logger.LogError("età minima 18 anni!");
                }
               
                
                Cliente cl = new Cliente();
                cl.Nome = cDTO.Nome;
                cl.Cognome = cDTO.Cognome;
                cl.DataDiNascita = cDTO.DataDiNascita;
                cl.Email = cDTO.Email;
                cl.Password = cDTO.Password;

                return await _repository.CreaCliente(cl);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<RestituisciClienteDTO> GetCliente(int id)
        {
            try
            {
                var cliente=await _repository.RestituisciCliente(id);
                RestituisciClienteDTO clienteDTO=new RestituisciClienteDTO();
                clienteDTO.Nome = cliente.Nome;
                clienteDTO.Nome = cliente.Nome;
                clienteDTO.Cognome = cliente.Cognome;
                clienteDTO.DataDiNascita = cliente.DataDiNascita;
                clienteDTO.Email = cliente.Email;
                return clienteDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Cliente>> GetClienti()
        {
            
            try
            {
               

                
 
               return await _repository.RestituisciClienti();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdatePassword(int id, AggiornamentoPasswordDTO cDTO)
        {
            try
            {
                Cliente c = new Cliente();
                c.Password = cDTO.Password;
                return await _repository.AggiornaCliente(id,c);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
