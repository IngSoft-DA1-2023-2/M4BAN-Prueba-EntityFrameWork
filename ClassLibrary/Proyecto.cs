namespace ClassLibrary;

public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }

    // Relación uno a muchos: Un proyecto puede tener múltiples cargas de horas.
    public List<CargaHoras> CargasHoras { get; set; }
}