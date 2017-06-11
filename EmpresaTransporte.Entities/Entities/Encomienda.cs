using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Encomienda : Servicio
    {

        public int nroSerie { set; get; }
        public int codEncomienda { set; get; }
        public LugarViaje lugarViaje { set; get; }
        public String origen { set; get; }
        public String destino { set; get; }
        public double montoTotal { set; get; }
        public String descripcion { set; get; }
        public TipoServicio tipoServicio { set; get; }
        
        

        public Encomienda(int nroSerie, int codEncomienda, String origen, String destino, LugarViaje lugarViaje, double montoTotal, String descripcion)
        {
            this.nroSerie = nroSerie;
            this.codEncomienda = codEncomienda;
            this.origen = origen;
            this.destino = destino;
            this.lugarViaje = lugarViaje;
            this.montoTotal = montoTotal;
            this.descripcion = descripcion;
        }

        public Encomienda()
        {

        }


        public TipoServicio ObtenerTipoServicio { get { return tipoServicio;} }

        public int servicioId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
