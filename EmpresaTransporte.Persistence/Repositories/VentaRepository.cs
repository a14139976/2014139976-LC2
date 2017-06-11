using EmpresaTransporte.Entities;
using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class VentaRepository : IRepository<Venta>, IVentaRepository
    {
        private readonly EmpresaTransporteDbContext _Context;

        private VentaRepository() : base ()
		{

        }

        public VentaRepository(EmpresaTransporteDbContext context)
        {
            _Context = context;
        }

        void IRepository<Venta>.Add(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.AddRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Venta> IRepository<Venta>.Find(System.Linq.Expressions.Expression<Func<Venta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Venta IRepository<Venta>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Venta> IRepository<Venta>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Remove(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.RemoveRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Update(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.UpdateRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetVentaByServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }
    }
}
