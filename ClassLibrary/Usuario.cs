namespace ClassLibrary;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }

    // Relación uno a uno: Un usuario pertenece a un proyecto.
    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }

    // Relación uno a muchos: Un usuario puede registrar múltiples cargas de horas.
    public List<CargaHoras> CargasHoras { get; set; }
}
