using (var context = new Ejer())
{

    var user1 = new User()
    {
        Name = "User1",
        LastName = "LastName1",

    };


    var user2 = new User()
    {
        Name = "User2",
        LastName = "LastName2",

    };



    var hour1 = new Hours()
    {
        start = DateTime.Now,
        end = DateTime.Now,
        User = user1,
        Description = "Description1"
    };



    var hour2 = new Hours()
    {
        start = DateTime.Now,
        end = DateTime.Now,
        User = user2,
        Description = "Description2"
    };


    var hour3 = new Hours()
    {
        start = DateTime.Now,
        end = DateTime.Now,
        User = user1,
        Description = "Description3"
    };


    var hour4 = new Hours()
    {
        start = DateTime.Now,
        end = DateTime.Now,
        User = user2,
        Description = "Description4"
    };


    var proyect1 = new Proyect()
    {
        Name = "Proyect1",
        Users = new List<User>() { user1 }
    };


    var proyect2 = new Proyect()
    {
        Name = "Proyect2",
        Users = new List<User>() { user2 }
    };



    context.Proyect.Add(proyect1);
    context.Proyect.Add(proyect2);
    context.SaveChanges();

    context.Hours.Add(hour1);
    context.Hours.Add(hour2);
    context.Hours.Add(hour3);
    context.Hours.Add(hour4);
    context.SaveChanges();
}
