using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntityFramework.Models;

namespace MvcEntityFramework.Data
{
    public class HospitalContext: DbContext
    {
        //TENDRÁ UN CONSTRUCTOR OBLIGATORIO
        //CON OPTIONS PARA EL CONTEXT
        public HospitalContext(DbContextOptions options)
            :base(options)
        {}
        //DEBEMOS MAPEAR CON DbSet CADA ENTIDAD PARA
        //QUE SEA ACCESIBLE (OBLIGATORIO PROPIEDADES)
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
