using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IBusRepository Buses { get; }
        IEmpleadoRepository Empleados { get; }
        ILugarViajeRepository LugaresViajes { get; }
        IServicioRepository Servicios { get; }
        IVentaRepository Ventas { get; }

        int SaveChanges();
        void StateModified(Bus bus);
        void StateModified(Empleado empleado);
        void StateModified(LugarViaje lugarviaje);
        void StateModified(Servicio servicio);
        void StateModified(Venta venta);
    }
}
