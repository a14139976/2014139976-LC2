using EmpresaTransporte.Entities;
using EmpresaTransporte.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Persistence.Repositories
{
    public class EmpleadoRepository : IRepository<Empleado>, IEmpleadoRepository
    {


        private readonly EmpresaTransporteDbContext _Context;

        private EmpleadoRepository() : base()
		{

        }

        public EmpleadoRepository(EmpresaTransporteDbContext context)
        {
            _Context = context;
        }

        void IRepository<Empleado>.Add(Empleado entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.AddRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Empleado> IRepository<Empleado>.Find(System.Linq.Expressions.Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Empleado IRepository<Empleado>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Empleado> IRepository<Empleado>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.Remove(Empleado entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.RemoveRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.Update(Empleado entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.UpdateRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }
    }
}
