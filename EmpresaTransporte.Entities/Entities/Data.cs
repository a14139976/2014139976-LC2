using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Data
    {

        public List<LugarViaje> ObtenerListaLugarViaje()
        {
            List<LugarViaje> listaLugar = new List<LugarViaje>();
            return listaLugar;
        }


        public List<Tripulacion> ObtenerListaTripulacion()
        {
            List<Tripulacion> listaTripulacion = new List<Tripulacion>();
            return listaTripulacion;
        }



        public List<Cliente>ObtenerListaClientes(){
            List<Cliente> listaclientes = new List<Cliente>();

            Cliente cliente1 = new Cliente("70656961","Moises", "Alva","Caceres", "Av. Universitaria 342 Los Olivos","975326442");
            Cliente cliente2 = new Cliente("10231233", "Angie", "Herrera", "Velazco", "Av. Pershing 190 Breña", "933241211");
            Cliente cliente3 = new Cliente("70331231", "Milena", "Perez", "Lazo", "Av. Los Constructores 114 La Molina", "954544113");


            listaclientes.Add(cliente1);
            listaclientes.Add(cliente2);
            listaclientes.Add(cliente3);

            return listaclientes;
        }
           

}
}
