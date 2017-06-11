﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.IRepositories
{
    public interface IVentaRepository : IRepository<Venta>
    {
        IEnumerable<Venta> GetVentaByServicio(Servicio servicio);

    }
}