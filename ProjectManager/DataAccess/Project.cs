namespace DataAccess
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<User> Users { get; set; } = null!;

    }
}