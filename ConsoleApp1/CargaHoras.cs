public class CargaHoras
{
    public int CargaHorasId { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public int ProyectoId { get; set; }
    public virtual Proyecto Proyecto { get; set; }
    public decimal HorasTrabajadas { get; set; }
    public string Descripcion { get; set; }
    public DateTime Fecha { get; set; }
}