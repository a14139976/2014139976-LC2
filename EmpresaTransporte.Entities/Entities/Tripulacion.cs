using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Tripulacion : Empleado
    {
        public TipoTripulacion tipoTripulacion { set; get; }
        public String dni { set; get; }
        public String nombre { set; get; }
        public String apePaterno { set; get; }
        public String apeMaterno { set; get; }
        public String fecNacimiento { set; get; }
        public String fechaIngreso { set; get; }
        public int empleadoId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
