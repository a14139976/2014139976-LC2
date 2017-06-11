using EmpresaTransporte.Entities;
using EmpresaTransporte.Persistence.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence
{
    public class EmpresaTransporteDbContext : DbContext
    {
        public DbSet <Venta> Ventas { get; set; }
        public DbSet<LugarViaje> LugaresViajes { get; set; }
        public DbSet<Servicio> Transportes { get; set; }
        public DbSet<Servicio> Encomiendas { get; set; }

       
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Empleado> Tripulaciones { get; set; }
        public DbSet<Empleado> Administativos  { get; set; }

        public EmpresaTransporteDbContext() : base("EmpresaTransporte")
		{
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
