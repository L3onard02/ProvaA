using System.ComponentModel.DataAnnotations;

namespace WebApiProvaFaseA.Entities
{
    public class Carrello
    {
        [Key]
        
        public int IdentificativoCarrello { get; set; }
        public Cliente IdentificativoCliente { get; set; }
        public int ProdottoIdentificativoProdotto { get; set; }
        public int Quantità {  get; set; }
        public double Prezzo { get; set; }
    }
}
