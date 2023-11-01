using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            optionsBuilder.UseSqlServer("Server= .\\SQLEXPRESS;Database=EjercicioDbContext;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
