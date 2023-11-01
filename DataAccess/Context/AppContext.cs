using Microsoft.EntityFrameworkCore;
namespace DataAccess2.Context;


public class AppContext: DbContext
{
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CargaHoras> CargasHoras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer(
                        "Server=(localdb)\\mssqllocaldb;Database=AppContext;Trusted_Connection=True;Encrypt=False;");
        }
}

