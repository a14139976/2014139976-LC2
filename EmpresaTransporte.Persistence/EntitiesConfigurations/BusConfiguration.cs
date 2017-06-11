using EmpresaTransporte.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.EntitiesConfigurations
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
          {
		public BusConfiguration()
        {
            //Table Configurations
            ToTable("Buses");

            HasKey(a => a.busId);


        }
    }
}
