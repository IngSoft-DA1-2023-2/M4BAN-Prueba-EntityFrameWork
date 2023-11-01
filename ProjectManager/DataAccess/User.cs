namespace DataAccess;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public Project Project { get; set; } = null!;

}