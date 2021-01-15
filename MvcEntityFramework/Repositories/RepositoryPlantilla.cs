using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Repositories
{
    public class RepositoryPlantilla
    {
        private HospitalContext context;

        public RepositoryPlantilla(HospitalContext context)
        {
            this.context = context;
        }

        public List<Plantilla> GetPlantilla()
        {
            var consulta = from datos in this.context.Plantilla
                           select datos;
            return consulta.ToList();
        }

        public List<Plantilla> GetPlantillaSalario(int salario)
        {
            var consulta = from datos in this.context.Plantilla
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }

        public ResumenPlantilla FiltrarSalario(int salario)
        {
            var consulta = from datos in this.context.Plantilla
                           where datos.Salario >= salario
                           select datos;
            if(consulta.Count() == 0)
            {
                return null;
            }
            int personas = consulta.Count();
            int maximo = consulta.Max(x => x.Salario);
            int minimo = consulta.Min(x => x.Salario);
            ResumenPlantilla resumen = new ResumenPlantilla();
            resumen.Plantilla = consulta.ToList();
            resumen.Personas = personas;
            resumen.MaximoSalario = maximo;
            resumen.MinimoSalario = minimo;
            return resumen;
        }
    }
}
