
public class Proyecto
{
	public int ProyectoId { get; set; }
	public string Nombre { get; set; }
	public List<Usuario> Usuarios { get; set; }
}
public class CargaHoras
{
	public int CargaHorasId { get; set; }
	public DateTime Fecha { get; set; }
	public int Horas { get; set; }
	public string Descripcion { get; set; }
	public int UsuarioId { get; set; }
	public Usuario Usuario { get; set; }
}
public class Usuario
{
	public int UsuarioId { get; set; }
	public string Nombre { get; set; }
	public int ProyectoId { get; set; }
	public Proyecto Proyecto { get; set; }
	public List<CargaHoras> CargasHoras { get; set; }
}
