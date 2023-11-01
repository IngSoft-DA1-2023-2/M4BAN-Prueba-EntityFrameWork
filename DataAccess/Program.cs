// See https://aka.ms/new-console-template for more information
using DataAccess;

Console.WriteLine("Hello, World!");

using (var context = new EjercicioDbContext())
{


    var proyecto1 = new Proyecto { Nombre = "Proyecto A" };
    var proyecto2 = new Proyecto { Nombre = "Proyecto B" };

    context.Proyectos.AddRange(proyecto1, proyecto2);
    context.SaveChanges();

    var usuario1 = new Usuario { Nombre = "Usuario 1", Proyecto = proyecto1 };
    var usuario2 = new Usuario { Nombre = "Usuario 2", Proyecto = proyecto2 };

    context.Usuarios.AddRange(usuario1, usuario2);
    context.SaveChanges();

    var cargaHorasUsuario1Proyecto1_1 = new CargaHoras { HorasTrabajadas = 4, Descripcion = "Tareas A", Usuario = usuario1, Proyecto = proyecto1 };
    var cargaHorasUsuario1Proyecto1_2 = new CargaHoras { HorasTrabajadas = 3, Descripcion = "Tareas B", Usuario = usuario1, Proyecto = proyecto1 };
    var cargaHorasUsuario2Proyecto2_1 = new CargaHoras { HorasTrabajadas = 5, Descripcion = "Tareas C", Usuario = usuario2, Proyecto = proyecto2 };
    var cargaHorasUsuario2Proyecto2_2 = new CargaHoras { HorasTrabajadas = 6, Descripcion = "Tareas D", Usuario = usuario2, Proyecto = proyecto2 };

    context.CargasDeHoras.AddRange(
        cargaHorasUsuario1Proyecto1_1,
        cargaHorasUsuario1Proyecto1_2,
        cargaHorasUsuario2Proyecto2_1,
        cargaHorasUsuario2Proyecto2_2
    );

    context.SaveChanges();
}