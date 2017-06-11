using EmpresaTransporte.Entities;
using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class LugarViajeRepository : IRepository<LugarViaje>, ILugarViajeRepository
    {
        private EmpresaTransporteDbContext _Context;

        public LugarViajeRepository(EmpresaTransporteDbContext context)
        {
            _Context = context;
        }

        void IRepository<LugarViaje>.Add(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.AddRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<LugarViaje> IRepository<LugarViaje>.Find(System.Linq.Expressions.Expression<Func<LugarViaje, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        LugarViaje IRepository<LugarViaje>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<LugarViaje> IRepository<LugarViaje>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Remove(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.RemoveRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Update(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.UpdateRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }
    }
}
