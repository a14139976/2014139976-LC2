using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Cliente
    {
        public String dni { set; get; }
        public String nombre { set; get; }
        public String apePaterno { set; get; }
        public String apeMaterno { set; get; }
        public String direccion { set; get; }
        public String telefono { set; get; }

        public String ObtenerNombreCompleto()
        {
            return this.nombre+" "+this.apePaterno+" "+this.apeMaterno; 
        }

        public String ObtenerNombre()
        {
            return this.nombre + " " + this.apePaterno;
        }

        public Cliente()
        {

        }

        public Cliente(String dni, String nombre, String apePaterno, String apeMaterno, String direccion, String telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apePaterno = apePaterno;
            this.apeMaterno=apeMaterno;
            this.direccion=direccion;
            this.telefono=telefono;
        }


    }
}
