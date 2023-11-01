// See https://aka.ms/new-console-template for more information

using DataAccess;

Console.WriteLine("Hello, World!");

using (var context = new GestionDeProyectosContext())
{
    var proyecto1 = new Proyecto()
    {
        Nombre = "Proyecto 1",
        Descripcion = "Descripcion 1",
    };
    var proyecto2 = new Proyecto()
    {
        Nombre = "Proyecto 2",
        Descripcion = "Descripcion 2",
    };
    
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
    
    var cargaHoras1 = new CargaHoras()
    {
        Horas = 1,
        Descripcion = "Descripcion 1",
        Usuario = usuario1
    };
    var cargaHoras2 = new CargaHoras()
    {
        Horas = 2,
        Descripcion = "Descripcion 2",
        Usuario = usuario2
    };
    
    context.Proyectos.Add(proyecto1);
    context.Proyectos.Add(proyecto2);
    context.SaveChanges();
}
