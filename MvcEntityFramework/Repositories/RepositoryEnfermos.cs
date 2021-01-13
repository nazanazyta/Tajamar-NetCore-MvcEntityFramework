using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;

        public RepositoryEnfermos(EnfermosContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            var consulta = from datos in this.context.Enfermos
                           select datos;
            return consulta.ToList();
        }

        public Enfermo BuscarEnfermo(int inscripcion)
        {
            var consulta = from datos in this.context.Enfermos
                           where datos.Inscripcion == inscripcion
                           select datos;
            //CUÁNTOS DATOS DEVOLVERÁ LA CONSULTA??? 1 o ninguno
            //DEBERÍAMOS PREGUNTAR SI TENEMOS DATOS O NO
            //UTILIZAMOS EL MÉTODO Count() DE Linq PARA PREGUNTAR
            //Norma: SI NO EXISTEN DATOS, SIEMPRE SE DEVUELVE
            //null DESDE LOS REPOSITORIOS
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                //DEVOLVEMOS EL PRIMER ELEMENTO ENCONTRADO
                //UNA CONSULTA NUNCA SABRÁ SI TIENE UNO O VARIOS ELEMENTOS
                //MEDIANTE EL MÉTODO .First() DEVOLVEMOS EL PRIMERO
                return consulta.First();
            }
        }
    }
}
