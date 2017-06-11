using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public interface Servicio
    {
        int servicioId { get; set; }
        TipoServicio tipoServicio { set; get; }
       
    }
}
