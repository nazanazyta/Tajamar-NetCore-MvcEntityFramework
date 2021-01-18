using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure CambiarEspecialidad (@iddoctor int, @especialidad nvarchar(30))
//as
//    update DOCTOR set ESPECIALIDAD = @especialidad
//	where DOCTOR_NO = @iddoctor
//go

//---------------------------
//create procedure doctoresespecialidad (@especialidad nvarchar(30))
//AS
//	select * from DOCTOR where ESPECIALIDAD = @especialidad
//GO

//create procedure updatesalarioespecialidaddoctor (@cantidad int, @especialidad nvarchar(30))
//as
//    update DOCTOR set SALARIO = SALARIO + @cantidad where ESPECIALIDAD = @especialidad
//go

//create procedure mostrarespecialidades
//as
//	select distinct especialidad from doctor
//go
#endregion

namespace MvcEntityFramework.Repositories
{
    public class RepositoryDoctores
    {
        HospitalContext context;

        public RepositoryDoctores(HospitalContext context)
        {
            this.context = context;
        }

        public void UpdateEspecialidad(int iddoctor, String espe)
        {
            this.context.ModificarEspecialidad(iddoctor, espe);
        }

        //PROCEDIMIENTO ALMACENADO CON SELECT
        public List<Doctor> GetDoctores()
        {
            //EN ESTE CASO NO TIENE PARÁMETROS, PERO LA CONSULTA
            //ES IGUAL QUE CON PARÁMETROS
            String sql = "mostrardoctores";
            //LA CONSULTA SE EJECUTA A PARTIR DE UN DbSet DE
            //COLECCIÓN Y AUTOMÁTICAMENTE MAPEARÁ LOS CAMPOS
            //DE LOS DATOS QUE DEVUELVA EL PROCEDURE
            List<Doctor> doctores = this.context.Doctores.FromSqlRaw(sql).ToList();
            return doctores;
        }

        public List<Doctor> GetDoctoresEspecialidad(String espe)
        {
            String sql = "doctoresespecialidad @especialidad";
            SqlParameter pamesp = new SqlParameter("@especialidad", espe);
            List<Doctor> doctores = this.context.Doctores.FromSqlRaw(sql, pamesp).ToList();
            //var consulta = from datos in this.context.Doctores
            //               where datos.Especialidad == especialidad
            //               select datos;
            //return consulta.ToList();
            return doctores;
        }

        public void UpdateSalario(int cantidad, String espe)
        {
            String sql = "updatesalarioespecialidaddoctor @cantidad, @especialidad";
            SqlParameter pamcan = new SqlParameter("@cantidad", cantidad);
            SqlParameter pamesp = new SqlParameter("@especialidad", espe);
            this.context.Database.ExecuteSqlRaw(sql, pamcan, pamesp);
        }

        public List<String> GetEspecialidades()
        {
            //var consulta = (from datos in this.context.Doctores
            //                select datos.Especialidad).Distinct();
            //return consulta.ToList();

            //PARA LLAMAR A PROCEDIMIENTOS SELECT
            //QUE NO TENEMOS MAPEADOS MEDIANTE DbSet
            //NECESITAMOS HACERLO A LA "ANTIGUA"
            //Y MAPEAR NOSOTROS MANUALMENTE LA RESPUESTA
            //(UTILIZANDO COMANDOS NO ESPECIALIZADOS,
            //NO OBJETOS PROPIOS DE SQL O MYSQL)
            //SE UTILIZAN OBJETOS STANDARD DE ADO PERO DE CORE
            //TAMBIÉN SE DEBE UTILIZAR LA CONEXIÓN DE LINQ
            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand())
            {
                String sql = "mostrarespecialidades";
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = sql;
                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();
                List<String> especialidades = new List<String>();
                while (reader.Read())
                {
                    especialidades.Add(reader["especialidad"].ToString());
                }
                reader.Close();
                com.Connection.Close();
                return especialidades;
            }
        }
    }
}
