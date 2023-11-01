namespace Backend;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }
    
    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }
    
    public List<RegistroHora> RegistrosHora { get; set; }
}