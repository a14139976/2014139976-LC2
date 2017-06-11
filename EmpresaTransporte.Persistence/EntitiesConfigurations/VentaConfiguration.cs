using EmpresaTransporte.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.EntitiesConfigurations
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
          {
		public VentaConfiguration()
        {
            //Table Configurations
            ToTable("Ventas");

            HasKey(a => a.ventaId);
            Property(a => a.fechaRegistro).HasMaxLength(255);

        }
    }
}
