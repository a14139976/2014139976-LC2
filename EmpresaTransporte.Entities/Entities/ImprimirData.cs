using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class ImprimirData
   {
        

        public void imprimirListaVentas(List<Venta> listaVentas)
        {
            Console.WriteLine("REPORTE DE VENTAS PASAJES/ENCOMIENDAS");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------Pasajes---------------------------------");
            Console.WriteLine();
            Console.WriteLine( "NombrePasajero".PadRight(16) + "Origen".PadRight(8) + "Destino".PadRight(10)+ "TipoPago".PadRight(9)+ "Tipoviaje".PadRight(11) + "TipoComprobante".PadRight(16) + "MontoTotal".PadRight(6));

            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].servicio.tipoServicio == TipoServicio.Transporte)
                {
                    Transporte transporte = (Transporte)listaVentas[i].servicio;
                    Console.WriteLine(transporte.cliente.ObtenerNombre().PadRight(16) + transporte.origen.PadRight(8) + transporte.destino.PadRight(10) + listaVentas[i].tipoPago.ToString().PadRight(9) + transporte.tipoViaje.ToString().PadRight(11) + listaVentas[i].tipoComprobante.ToString().PadRight(16) + listaVentas[i].montoTotal.ToString().PadRight(6));
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------Encomiendas---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Serie".PadRight(6) + "CodEncomienda".PadRight(14) + "Origen".PadRight(9) + "Destino".PadRight(10) + "TipoComprobante".PadRight(17) + "TipoPago".PadRight(12) + "MontoTotal".PadRight(6));
            Console.WriteLine();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].servicio.tipoServicio == TipoServicio.Encomienda)
                {
                  Encomienda encomienda = (Encomienda)listaVentas[i].servicio;
                  Console.WriteLine(encomienda.nroSerie.ToString().PadRight(6) + encomienda.codEncomienda.ToString().PadRight(14) + encomienda.origen.PadRight(9) + encomienda.destino.PadRight(10) + listaVentas[i].tipoComprobante.ToString().PadRight(17) + listaVentas[i].tipoPago.ToString().PadRight(12) + listaVentas[i].montoTotal.ToString().PadRight(6));
                }

            }


        }
        }
    }


    

