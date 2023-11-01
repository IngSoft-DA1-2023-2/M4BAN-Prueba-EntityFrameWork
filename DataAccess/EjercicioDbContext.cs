using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EjercicioDbContext : DbContext
    {
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CargaHoras> CargasDeHoras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .\\SQLEXPRESS;Database=Prueba2;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CargaHoras>()
                .HasOne(e => e.Proyecto)
                .WithMany(e => e.CargasDeHoras)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
               .Entity<Usuario>()
               .HasOne(e => e.Proyecto)
               .WithMany(e => e.Usuarios)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
