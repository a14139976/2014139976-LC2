using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTransporte.Entities;
using System.Linq.Expressions;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class BusRepository : IRepository<Bus>, IBusRepository
    {

        private readonly EmpresaTransporteDbContext _Context;

        private BusRepository() : base()
		{

        }

        public BusRepository(EmpresaTransporteDbContext context)
        {
            _Context = context;
        }

        public void Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bus> Find(Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Bus Get(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bus> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.Find(System.Linq.Expressions.Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Bus IRepository<Bus>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Remove(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.RemoveRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }
    }
}
