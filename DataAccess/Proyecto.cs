namespace DataAccess2;

public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }
    public virtual ICollection<Usuario> Usuarios { get; set; }
    public virtual ICollection<CargaHoras> CargasHoras { get; set; }
}


