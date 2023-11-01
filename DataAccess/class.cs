
public class Proyect
{
    public int Id { get; set; }
    public List<User> Users { get; set; }
    public string Name { get; set; }
}
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}

public class Hours
{
    public int Id { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }

    public User User { get; set; }
    public string Description { get; set; }
}