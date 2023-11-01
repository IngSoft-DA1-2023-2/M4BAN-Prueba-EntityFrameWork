using Entities;
using (var context = new ApplicationDbContext())
{
    var proyecto1 = new Proyecto { Nombre = "Proyecto 1" };
    var proyecto2 = new Proyecto { Nombre = "Proyecto 2" };
    var carga1 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Descripcion 1",  Proyecto = proyecto1 };
    var carga2 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Descripcion 2",  Proyecto = proyecto1 };
    var carga3 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Descripcion 3",  Proyecto = proyecto2 };
    var carga4 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Descripcion 4",  Proyecto = proyecto2 };
    
    
    var usuario1 = new Usuario { Nombre = "Usuario 1", Proyecto = proyecto1, CargasHoras = new List<CargaHoras> { carga1, carga2 } };
    var usuario2 = new Usuario { Nombre = "Usuario 2", Proyecto = proyecto2, CargasHoras = new List<CargaHoras> { carga3, carga4 } };

    

    context.Proyectos.AddRange(proyecto1, proyecto2);
    context.Usuarios.AddRange(usuario1, usuario2);
    context.CargasHoras.AddRange(carga1, carga2, carga3, carga4);

    context.SaveChanges();
}