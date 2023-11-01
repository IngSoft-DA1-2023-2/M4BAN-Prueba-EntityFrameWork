namespace Entities;
public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }

    public List<Usuario> Usuarios { get; set; }

}
