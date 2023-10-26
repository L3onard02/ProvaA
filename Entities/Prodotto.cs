using System.ComponentModel.DataAnnotations;

namespace WebApiProvaFaseA.Entities
{
    public class Prodotto
    {
        [Key]
        public int IdentificativoProdotto { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }
        public IEnumerable<Carrello>? Carrelli { get; set; }
    }
}
