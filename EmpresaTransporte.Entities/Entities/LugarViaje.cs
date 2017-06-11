using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities {
    public class LugarViaje
    {
        public int lugarViajeId { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public TipoLugar tipolugar { get; set; }
        public String telefono { get; set; }
    }
}
