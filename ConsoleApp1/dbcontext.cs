using Microsoft.EntityFrameworkCore;

public class ProyectosDbContext : DbContext
{
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CargaHoras> CargasHoras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PruebaEntity;Integrated Security=True;Trusted_Connection=True;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Proyecto)
            .WithMany(p => p.Usuarios)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CargaHoras>()
            .HasOne(u => u.Usuario)
            .WithMany(p => p.CargasHoras)
            .OnDelete(DeleteBehavior.Restrict);
    }
}