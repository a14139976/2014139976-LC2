using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrativo vendedor = new Administrativo();
            vendedor.nombre = "Alberto";
            vendedor.apePaterno = "Portocarrero";
            
            var encomienda1 = new Encomienda();
            encomienda1.origen = "Lima";
            encomienda1.destino = "Arequipa";
            encomienda1.nroSerie = 4203;
            encomienda1.codEncomienda = 700439010;

            var encomienda2 = new Encomienda();
            encomienda2.origen = "Lima";
            encomienda2.destino = "Tumbes";
            encomienda2.nroSerie = 4204;
            encomienda2.codEncomienda = 740493989;

            var transporte1 = new Transporte();
            transporte1.origen = "Lima";
            transporte1.destino = "Piura";

            var transporte2 = new Transporte();
            transporte2.origen = "Lima";
            transporte2.destino = "Cuzco";
            
            var transporte3 = new Transporte();
            transporte3.origen = "Lima";
            transporte3.destino = "Huanuco";

           
            Data data= new Data();
            List<Cliente>listaClientes= data.ObtenerListaClientes();
            transporte1.cliente = listaClientes[0];
            transporte1.tipoViaje = TipoViaje.Normal;
            transporte2.cliente = listaClientes[1];
            transporte2.tipoViaje = TipoViaje.VIP;
            transporte3.cliente = listaClientes[2];
            transporte3.tipoViaje = TipoViaje.VIP;

            List<Servicio> listaservicio = new List<Servicio>();
            List<Venta> listaVentas = new List<Venta>();
            Servicio servicio1 = transporte1;
            servicio1.tipoServicio = TipoServicio.Transporte;
            Venta venta1 = new Venta();
            venta1.administrativo = vendedor;
            venta1.servicio = servicio1;
            venta1.tipoPago = TipoPago.Credito;
            venta1.tipoComprobante = TipoComprobante.Factura;
            venta1.montoTotal = 90;

            Servicio servicio2 = transporte2;
            servicio2.tipoServicio = TipoServicio.Transporte;
            Venta venta2 = new Venta();
            venta2.administrativo = vendedor;
            venta2.servicio = servicio2;
            venta2.tipoPago = TipoPago.Contado;
            venta2.tipoComprobante = TipoComprobante.Boleta;
            venta2.montoTotal = 130;

            Servicio servicio3 = transporte3;
            servicio3.tipoServicio = TipoServicio.Transporte;
            Venta venta3 = new Venta();
            venta3.administrativo = vendedor;
            venta3.servicio = servicio3;
            venta3.tipoPago = TipoPago.Contado;
            venta3.tipoComprobante = TipoComprobante.Factura;
            venta3.montoTotal = 90;

            Servicio servicio4 = encomienda1;
            servicio4.tipoServicio = TipoServicio.Encomienda;
            Venta venta4 = new Venta();
            venta4.administrativo = vendedor;
            venta4.servicio = servicio4;
            venta4.tipoPago = TipoPago.Credito;
            venta4.tipoComprobante = TipoComprobante.Boleta;
            venta4.montoTotal = 70;

            Servicio servicio5 = encomienda2;
            servicio5.tipoServicio = TipoServicio.Encomienda;
            Venta venta5 = new Venta();
            venta5.administrativo = vendedor;
            venta5.servicio = servicio5;
            venta5.tipoPago = TipoPago.Contado;
            venta5.tipoComprobante = TipoComprobante.Factura;
            venta5.montoTotal = 50;


            listaVentas.Add(venta1);
            listaVentas.Add(venta2);
            listaVentas.Add(venta3);
            listaVentas.Add(venta4);
            listaVentas.Add(venta5);
                
            ImprimirData impr = new ImprimirData();
            impr.imprimirListaVentas(listaVentas);
                         
            Console.ReadKey();

        }
    }
}
