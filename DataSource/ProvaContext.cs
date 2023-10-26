using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Entities;

namespace WebAPIVenditaLibri.DataSource
{
    public class ProvaContext : DbContext
    {
    
        
            public ProvaContext()
            {
            }
            public ProvaContext(DbContextOptions<ProvaContext> options)
            : base(options)
            {
            }


            public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Carrello> Carrelli { get; set; }
    }
    
}
