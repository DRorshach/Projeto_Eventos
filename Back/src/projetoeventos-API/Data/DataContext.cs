using Microsoft.EntityFrameworkCore;
using projetoeventos_API.Models;

namespace projetoeventos_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Evento> Eventos { get; set; }

    }
}