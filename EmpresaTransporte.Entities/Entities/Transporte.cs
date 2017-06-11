using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Transporte : Servicio
    {
        public String origen { set; get; }
        public String destino { set; get; }
        public TipoViaje tipoViaje { set; get; }
        public String fecha { set; get; }
        public Bus bus { set; get; }
        public LugarViaje lugarViaje { set; get; }
        public Cliente cliente { set; get; }
        public TipoServicio tipoServicio { set; get; }
        public double montoTotal { set; get; }

        public Transporte(String origen, String destino, TipoViaje tipoViaje, Bus bus, LugarViaje lugarViaje, Cliente cliente, String fecha, double montoTotal)
        {
            this.origen = origen;
            this.destino = destino;
            this.tipoViaje = tipoViaje;
            this.fecha = fecha;
            this.bus = bus;
            this.lugarViaje = lugarViaje;
            this.cliente = cliente;
            this.montoTotal = montoTotal;

        }

        public Transporte()
        {

        }


        public TipoServicio ObtenerTipoServicio { get { return tipoServicio; } }

        public int servicioId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
