using Microsoft.EntityFrameworkCore;

public class Ejercicio : DbContext
{
	//entities
	public DbSet<Usuario> Usuarios { get; set; }
	public DbSet<CargaHoras> CargaHoras { get; set; }

	public DbSet <Proyecto> Proyectos { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=OBLDb;Integrated Security=True;Trusted_Connection=True;Encrypt=False");
	}
}