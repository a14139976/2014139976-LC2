using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly DbContext _Context;
        
        public Repository(DbContext context)
        {
            _Context = context;
        }

        public void Delete(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity Get(int? id)
        {
            return _Context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().Where(predicate);
        }
        /*void IRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        */
        TEntity IRepository<TEntity>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        /*void IRepository<TEntity>.Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
        */
        void IRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
