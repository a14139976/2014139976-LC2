using EmpresaTransporte.Entities;
using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class ServicioRepository : IRepository<Servicio>, IServicioRepository
    {
        private EmpresaTransporteDbContext _Context;

        public ServicioRepository(EmpresaTransporteDbContext context)
        {
            _Context = context;
        }

        void IRepository<Servicio>.Add(Servicio entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.AddRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Servicio> IRepository<Servicio>.Find(Expression<Func<Servicio, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Servicio IRepository<Servicio>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Servicio> IRepository<Servicio>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.Remove(Servicio entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.RemoveRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.Update(Servicio entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.UpdateRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }
    }
}
