using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
        public class Proyecto
        {
            public int ProyectoId { get; set; }
            public string Nombre { get; set; }
            public List<Usuario> Usuarios { get; set; } 
            public List<CargaHoras> CargasDeHoras { get; set; }
        }

     
        public class Usuario
        {
            public int UsuarioId { get; set; }
            public string Nombre { get; set; }
            public int ProyectoId { get; set; } 
            public Proyecto Proyecto { get; set; }
        }

        public class CargaHoras
        {
            public int CargaHorasId { get; set; }
            public int HorasTrabajadas { get; set; }
            public string Descripcion { get; set; }
            public int UsuarioId { get; set; } 
            public Usuario Usuario { get; set; } 
            public int ProyectoId { get; set; } 
            public Proyecto Proyecto { get; set; } 
        }

    
}
