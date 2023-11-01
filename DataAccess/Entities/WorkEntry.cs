using Microsoft.EntityFrameworkCore;
namespace DataAccess{


    public class WorkEntry{
        public int Id { get; set; }

        public User User { get; set; }

        public Project Project { get; set; }

        public double Hours { get; set; }

        
    }
}