using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Repositories
{
    public class RepositoryHospital
    {
        //CLASE ENCARGADA DE REALIZAR LAS CONSULTAS
        //A BBDD MEDIANTE LINQ TO ENTITY FRAMEWORK (EF)
        private HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        //MÉTODO PARA DEVOLVER LOS HOSPITALES
        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }
    }
}
