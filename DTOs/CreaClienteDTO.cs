using System.ComponentModel.DataAnnotations;

namespace WebApiProvaFaseA.DTOs
{
    public class CreaClienteDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public DateTime DataDiNascita { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
