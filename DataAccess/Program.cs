using DataAccess2;
using AppContext = DataAccess2.Context.AppContext;

Console.WriteLine("Hello, World!");

using (var context = new AppContext())
{
    var proyecto1 = new Proyecto { Nombre = "Proyecto 1" };
    var proyecto2 = new Proyecto { Nombre = "Proyecto 2" };

    context.Proyectos.AddRange(proyecto1, proyecto2);
    context.SaveChanges();

    var usuario1 = new Usuario { Nombre = "Usuario 1", ProyectoId = proyecto1.ProyectoId };
    var usuario2 = new Usuario { Nombre = "Usuario 2", ProyectoId = proyecto2.ProyectoId };

    context.Usuarios.AddRange(usuario1, usuario2);
    context.SaveChanges();

    var cargaHoras1 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Tarea A", ProyectoId = proyecto1.ProyectoId, UsuarioId = usuario1.UsuarioId };
    var cargaHoras2 = new CargaHoras { HorasTrabajadas = 6, Descripcion = "Tarea B", ProyectoId = proyecto1.ProyectoId, UsuarioId = usuario1.UsuarioId };

    var cargaHoras3 = new CargaHoras { HorasTrabajadas = 7, Descripcion = "Tarea C", ProyectoId = proyecto2.ProyectoId, UsuarioId = usuario2.UsuarioId };
    var cargaHoras4 = new CargaHoras { HorasTrabajadas = 5, Descripcion = "Tarea D", ProyectoId = proyecto2.ProyectoId, UsuarioId = usuario2.UsuarioId };

    context.CargasHoras.AddRange(cargaHoras1, cargaHoras2, cargaHoras3, cargaHoras4);
    context.SaveChanges();
}
