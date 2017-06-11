using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Bus
    {
        public int busId { get; set; }
        public int codChofer { get; set; }
        public int nroPlaca { get; set; }
        public int nroBus { get; set; }
        public int nroAsientos{get;set;}
        Tripulacion tripulacion { get; set; }
    }
}
