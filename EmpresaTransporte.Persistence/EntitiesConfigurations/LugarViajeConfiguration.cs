using EmpresaTransporte.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.EntitiesConfigurations
{
    public class LugarViajeConfiguration : EntityTypeConfiguration<LugarViaje>
          {
		public LugarViajeConfiguration()
        {
            //Table Configurations
            ToTable("LugarViaje");

            HasKey(a => a.lugarViajeId);


        }
    }
}
