namespace WebApiProvaFaseA.DTOs
{
    public class RestituisciClienteDTO
    {
        public int IdentificativoCliente { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime DataDiNascita { get; set; }
        public string Email { get; set; }

    }
}
