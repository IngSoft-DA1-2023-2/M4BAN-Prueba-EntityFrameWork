namespace DataAccess;

public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public IList<Usuario> Usuarios { get; set; }
}

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }

    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }

    public IList<CargaHoras> CargasHoras { get; set; }
}

public class CargaHoras
{
    public int CargaHorasId { get; set; }
    public int Horas { get; set; }
    public string Descripcion { get; set; }

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}