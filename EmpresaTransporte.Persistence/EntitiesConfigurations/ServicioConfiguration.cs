using EmpresaTransporte.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.EntitiesConfigurations
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
          {
		public ServicioConfiguration()
        {
            //Table Configurations
            ToTable("Servicios");

            HasKey(a => a.servicioId);
            Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));
            Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));


         }
    }
}
