using Microsoft.EntityFrameworkCore;

namespace ClassLibrary;

public class SqlContext : DbContext
{
    
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<CargaHoras> CargaHoras { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Server=localhost;Database=1nov;User Id=sa;Password=reallyStrongPwd123;Encrypt=False;TrustServerCertificate=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Usuario>()
                        .HasOne(u => u.Proyecto)
                        .WithMany()
                        .HasForeignKey(u => u.ProyectoId)
                        .OnDelete(DeleteBehavior.NoAction);
        }
        
        
}