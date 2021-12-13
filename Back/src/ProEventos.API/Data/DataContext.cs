using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
  
    public class DataContext : DbContext // herdando classe de contexto do EF
    {
          public DataContext(DbContextOptions<DataContext> options ) : base(options) //passando a conexão para DbContext
    {
        
    }
        public DbSet<Evento> Eventos { get; set; }
    }
}