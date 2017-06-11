using System;
using EmpresaTransporte.Entities;
using EmpresaTransporte.Entities.IRepositories;


namespace EmpresaTransporte.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly EmpresaTransporteDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        public IBusRepository Buses { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public ILugarViajeRepository LugaresViajes { get; private set; }
        public IServicioRepository Servicios { get; private set; }
        public IVentaRepository Ventas { get; private set; }

        private UnityOfWork()
        {
            _Context = new EmpresaTransporteDbContext();

            Buses = new BusRepository(_Context);

            Empleados = new EmpleadoRepository(_Context);

            LugaresViajes = new LugarViajeRepository(_Context);

            Servicios = new ServicioRepository(_Context);

            Ventas = new VentaRepository(_Context);

        }

        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }


        /* public void Dispose()
         {
             _Context.Dispose();
         }

         public int SaveChanges()
         {
             return _Context.SaveChanges();
         }

         //int IUnityOfWork.SaveChanges()
         //{
         //    return _Context.SaveChanges();
         //}

         public void StateModified(object Entity)
         {
             _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
         }
         */


        public void Dispose()
        {

            _Context.Dispose();
        }

        //metodo que guarda los cambios. lleva los cambios en memoria hacia la base de datos.
        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        //metodo que cambia el estado de una entidad en el entityframework para que luego se cambie en la base de datos
        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void StateModified(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void StateModified(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void StateModified(LugarViaje lugarviaje)
        {
            _Instance.StateModified(lugarviaje);
        }

        public void StateModified(Servicio servicio)
        {
            _Instance.StateModified(servicio);
        }

        public void StateModified(Venta venta)
        {
            _Instance.StateModified(venta);
        }





        /*

public static UnityOfWork Instance
{
    get
    {
        lock (_Lock)
        {
            if (_Instance == null)
                _Instance = new UnityOfWork();
        }

        return _Instance;
    }
}
*/



    }
}
