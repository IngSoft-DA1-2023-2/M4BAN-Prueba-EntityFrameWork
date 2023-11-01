namespace Backend;

public class RegistroHora
{
    public int RegistroHoraId { get; set; }
    public int HorasTrabajadas { get; set; }
    public string Descripcion { get; set; }
    
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}