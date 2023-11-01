namespace ClassLibrary;

public class CargaHoras
{
    public int CargaHorasId { get; set; }
    public DateTime Fecha { get; set; }
    public int HorasTrabajadas { get; set; }
    public string Descripcion { get; set; }

    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}