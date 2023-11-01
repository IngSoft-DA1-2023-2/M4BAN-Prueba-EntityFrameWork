namespace DataAccess2;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }
    public int ProyectoId { get; set; }
    public virtual Proyecto Proyecto { get; set; }
    public virtual ICollection<CargaHoras> CargasHoras { get; set; }
}

