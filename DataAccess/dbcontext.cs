using Microsoft.EntityFrameworkCore;

public class Ejer : DbContext
{
    //entities
    public DbSet<Proyect> Proyect { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Hours> Hours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=OBLDb;Integrated Security=True;Trusted_Connection=True;Encrypt=False");
    }
}

