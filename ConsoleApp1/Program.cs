// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using (var context = new ProyectosDbContext())
{
    var proyecto1 = new Proyecto()
    {
        Nombre = "Proyecto 1"
    };

    var proyecto2 = new Proyecto()
    {
        Nombre = "Proyecto 2"
    };

    var proyecto3 = new Proyecto()
    {
        Nombre = "Proyecto 3"
    };

    context.Proyectos.Attach(proyecto1);
    context.Proyectos.Attach(proyecto2);
    context.Proyectos.Attach(proyecto3);

    var usuario1 = new Usuario()
    {
        Nombre = "Usuario 1",
        Proyecto = proyecto1
    };

    var usuario2 = new Usuario()
    {
        Nombre = "Usuario 2",
        Proyecto = proyecto2
    };

    var usuario3 = new Usuario()
    {
        Nombre = "Usuario 3",
        Proyecto = proyecto3
    };

    context.Usuarios.Attach(usuario1);
    context.Usuarios.Attach(usuario2);
    context.Usuarios.Attach(usuario3);

    context.Proyectos.Add(proyecto1);
    context.Proyectos.Add(proyecto2);
    context.Proyectos.Add(proyecto3);

    context.Usuarios.Add(usuario1);
    context.Usuarios.Add(usuario2);
    context.Usuarios.Add(usuario3);

    context.CargasHoras.AddRange(
        new CargaHoras()
        {
            Usuario = usuario1,
            Proyecto = proyecto1,
            HorasTrabajadas = 5,
            Descripcion = "Actividad 1",
            Fecha = DateTime.Now
        },
        new CargaHoras()
        {
            Usuario = usuario1,
            Proyecto = proyecto1,
            HorasTrabajadas = 3,
            Descripcion = "Actividad 2",
            Fecha = DateTime.Now
        }
       );

   
        context.SaveChanges();
}


