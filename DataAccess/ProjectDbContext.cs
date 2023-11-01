
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<WorkEntry> workEntries { get; set; }
        


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
         optionsBuilder.UseSqlServer("Server=DESKTOP-O4959SS;Database=ProjectDB;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }
    

    
    }
    
}