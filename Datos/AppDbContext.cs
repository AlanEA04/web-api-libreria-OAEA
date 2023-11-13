using ChambaOAEA.Datos.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ChambaOAEA.Datos
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }

    }
}
