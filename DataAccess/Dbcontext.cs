using Microsoft.EntityFrameworkCore;
using Entities;
public class ApplicationDbContext : DbContext
{
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CargaHoras> CargasHoras { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=RegistroDB; Trusted_Connection=True; Integrated Security=true; Encrypt=False;");
    }
    
}
