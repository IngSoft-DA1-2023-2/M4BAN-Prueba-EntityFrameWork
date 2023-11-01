using Microsoft.Identity.Client;

using (var context = new Ejercicio())
{

	var proyecto1 = new Proyecto { Nombre = "Proyecto1" };
	var proyecto2 = new Proyecto { Nombre = "Proyecto2" };

	context.Proyectos.Add(proyecto1);
	context.Proyectos.Add(proyecto2);


	var usuario1 = new Usuario { Nombre = "Usuario1", Proyecto = proyecto1 };
	var usuario2 = new Usuario { Nombre = "Usuario2", Proyecto = proyecto2 };
	context.Usuarios.Attach(usuario1);
	context.Usuarios.Attach(usuario2);
	context.Usuarios.Add(usuario1);
	context.Usuarios.Add(usuario2);

	context.CargaHoras.AddRange(
		new CargaHoras { Fecha = DateTime.Now, Horas = 8, Descripcion = "Trabajo1", Usuario = usuario1 },
		new CargaHoras { Fecha = DateTime.Now, Horas = 6, Descripcion = "Trabajo1", Usuario = usuario2 }
	);
	context.SaveChanges();
}