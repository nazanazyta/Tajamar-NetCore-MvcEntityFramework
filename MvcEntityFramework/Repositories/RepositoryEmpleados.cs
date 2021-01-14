using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public List<String> GetOficios()
        {
            var consulta = (from datos in this.context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public void IncrementarSalario(String oficio, int incremento)
        {
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);
            foreach(Empleado emp in empleados)
            {
                emp.Salario = emp.Salario + incremento;
            }
            this.context.SaveChanges();
        }

        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }
    }
}
