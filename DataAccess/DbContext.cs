using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class GestionDeProyectosContext : DbContext
{
    //entities
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CargaHoras> CargasHoras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=GestionDeProyectos;User=sa;Password=reallyStrongPwd123");
    }
}