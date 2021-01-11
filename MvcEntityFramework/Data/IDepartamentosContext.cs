using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntityFramework.Models;

namespace MvcEntityFramework.Data
{
    public interface IDepartamentosContext
    {
        List<Departamento> GetDepartamentos();
    }
}
