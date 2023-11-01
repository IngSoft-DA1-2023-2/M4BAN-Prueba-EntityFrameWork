// See https://aka.ms/new-console-template for more information
using DataAccess;

Console.WriteLine("Hello, World!");

using (var context = new ProjectDbContext()){
    var user = new User(){
        Name = "Juan",
        LastName = "Perez",
        Email = "JuanPerez@gmail.com",
    };
    context.Users.Add(user);
    context.SaveChanges();

    var user2 = new User(){
        Name = "Pedro",
        LastName = "Perez",
        Email = "PedroPerez@gmail.com",
    };

    context.Users.Add(user2);
    context.SaveChanges();

    var project = new Project(){
        Name = "Proyecto 1",
        Description = "Proyecto de prueba",
    };

    context.Projects.Add(project);
    context.SaveChanges();

    var project2 = new Project(){
        Name = "Proyecto 2",
        Description = "Proyecto de prueba 2",
    };

    context.Projects.Add(project2);
    context.SaveChanges();

    var workEntry = new WorkEntry(){
        User = user,
        Project = project,
        Hours = 5,
    };

    context.Attach(user);
    context.Attach(project);
    context.workEntries.Add(workEntry);
    context.SaveChanges();

    var workEntry2 = new WorkEntry(){
        User = user,
        Project = project2,
        Hours = 10,
    };

    context.Attach(user);
    context.Attach(project2);
    context.workEntries.Add(workEntry2);
    context.SaveChanges();

    var workEntry3 = new WorkEntry(){
        User = user2,
        Project = project,
        Hours = 15,
    };
    
    context.Attach(user2);
    context.Attach(project);
    context.workEntries.Add(workEntry3);
    context.SaveChanges();

    var workEntry4 = new WorkEntry(){
        User = user2,
        Project = project2,
        Hours = 20,
    };

    context.Attach(user2);
    context.Attach(project2);
    context.workEntries.Add(workEntry4);
    context.SaveChanges();



}
    

