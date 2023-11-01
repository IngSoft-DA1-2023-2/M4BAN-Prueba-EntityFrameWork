namespace Entities;
public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }

    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }

    public List<CargaHoras> CargasHoras { get; set; }
}