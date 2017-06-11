using EmpresaTransporte.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.EntitiesConfigurations
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
          {
		public EmpleadoConfiguration()
        {

            //Table Configurations
            ToTable("Empleados");
            HasKey(p => p.empleadoId);
            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));




        }
    }
}
