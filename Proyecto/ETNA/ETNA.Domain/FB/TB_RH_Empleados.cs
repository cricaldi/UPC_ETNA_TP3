using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    public class TB_RH_Empleados
    {
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Cargo { get; set; }
        public int UserId { get; set; }
        public int GrupoVentaId { get; set; }
        public string DocIdentidad { get; set; }
        public int Activo { get; set; }
        public string Disponibilidad { get; set; }
        
    }
}
