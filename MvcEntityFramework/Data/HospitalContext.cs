using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntityFramework.Models;
using Microsoft.Data.SqlClient;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure MostrarDoctores
//as
//	select * from DOCTOR
//go
#endregion

namespace MvcEntityFramework.Data
{
    public class HospitalContext: DbContext
    {
        //TENDRÁ UN CONSTRUCTOR OBLIGATORIO
        //CON OPTIONS PARA EL CONTEXT
        public HospitalContext(DbContextOptions<HospitalContext> options)
            :base(options)
        {}
        
        //DEBEMOS MAPEAR CON DbSet CADA ENTIDAD PARA
        //QUE SEA ACCESIBLE (OBLIGATORIO PROPIEDADES)
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Plantilla> Plantilla { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<EmpleadoHospital> EmpleadosHospital { get; set; }
        public DbSet<TodosEmpleados> TodosEmpleados { get; set; }
        
        //CREAMOS EL PRIMER PROCEDIMIENTO DE ACCIÓN
        public void ModificarEspecialidad(int iddoctor, String espe)
        {
            String sql = "cambiarespecialidad @iddoctor, @especialidad";
            //NECESITAMOS PARÁMETROS PARA ENVIAR LOS DATOS AL PROCEDIMIENTO
            SqlParameter pamid = new SqlParameter("@iddoctor", iddoctor);
            SqlParameter pamesp = new SqlParameter("@especialidad", espe);
            //List<SqlParameter> parametros = new List<SqlParameter>();
            //parametros.Add(pamid);
            //parametros.Add(pamesp);
            //EL OBJETO CONTEXT CONTIENE UNA PROPIEDAD DATABASE QUE ES LA
            //ENCARGADA DE EJECUTAR LAS CONSULTAS DE ACCIÓN SOBRE LA BBDD
            this.Database.ExecuteSqlRaw(sql, pamid, pamesp);
            //this.Database.ExecuteSqlRaw(sql, parametros);
        }
    }
}
