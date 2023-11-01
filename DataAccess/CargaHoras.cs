namespace DataAccess2;

public class CargaHoras
{
    public int CargaHorasId { get; set; }
    public int HorasTrabajadas { get; set; }
    public string Descripcion { get; set; }
    public int ProyectoId { get; set; }
    public virtual Proyecto Proyecto { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
}