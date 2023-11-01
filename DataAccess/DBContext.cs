using Backend;
using Microsoft.EntityFrameworkCore;

public class RegistroDB : DbContext
{
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<RegistroHora> RegistrosHora { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Proyecto>().HasData(
            new Proyecto { ProyectoId = 1, Nombre = "Proyecto 1" },
            new Proyecto { ProyectoId = 2, Nombre = "Proyecto 2" }
        );
        
        modelBuilder.Entity<Usuario>().HasData(
            new Usuario { UsuarioId = 1, Nombre = "Usuario 1", ProyectoId = 1 },
            new Usuario { UsuarioId = 2, Nombre = "Usuario 2", ProyectoId = 2 }
        );
        
        modelBuilder.Entity<RegistroHora>().HasData(
            new RegistroHora { RegistroHoraId = 1, UsuarioId = 1, HorasTrabajadas = 8, Descripcion = "Trabajo 1" },
            new RegistroHora { RegistroHoraId = 2, UsuarioId = 2, HorasTrabajadas = 7, Descripcion = "Trabajo 2" }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=RegistroDB; Trusted_Connection=True; Integrated Security=true; Encrypt=False;");
    }
}

