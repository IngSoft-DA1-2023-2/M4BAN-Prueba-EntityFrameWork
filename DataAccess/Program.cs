using Entities;
using (var context = new ApplicationDbContext())

    {
        
        var carga1 = new CargaHoras { HorasTrabajadas = 8, Descripcion = "Descripcion 1" };
        var carga2 = new CargaHoras {HorasTrabajadas = 8, Descripcion = "Descripcion 2" };
        var carga3 = new CargaHoras {HorasTrabajadas = 8,  Descripcion = "Descripcion 3" };
        var carga4 = new CargaHoras {  HorasTrabajadas = 8, Descripcion = "Descripcion 4" };
       
        var usuario1 = new Usuario {Nombre = "Usuario 1",CargasHoras = new List<CargaHoras> {carga1, carga2} };
        var usuario2 = new Usuario { Nombre = "Usuario 2", CargasHoras = new List<CargaHoras> { carga3, carga4 }};
        var proyecto1 = new Proyecto { Nombre = "Proyecto 1" , Usuarios = new List<Usuario> {usuario1}};
        var proyecto2 = new Proyecto {Nombre = "Proyecto 2", Usuarios = new List<Usuario> {usuario2}};
        
        context.Proyectos.AddRange(proyecto1, proyecto2);

        context.SaveChanges();
    }
