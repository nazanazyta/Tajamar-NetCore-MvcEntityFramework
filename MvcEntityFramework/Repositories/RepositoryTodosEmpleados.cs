using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

#region
//create procedure procetodosempleados
//(@nombre nvarchar(30), @suma int out, @media int out)
//as
//    select* from todosempleados
//    where nombre = @nombre
//    select @suma = sum(salario), @media = AVG(salario)
//    from todosempleados
//    where nombre = @nombre
//go

//create procedure procehospitalesdepartamentos
//as
//	select distinct nombre from todosempleados
//go
#endregion

#region VISTAS
//create view todosempleados
//as
//    select isnull(empleado_no, 0) as IdEmpleado
//	  , apellido, funcion, salario, (select nombre from hospital
//	  where (hospital.hospital_cod = plantilla.hospital_cod)) as nombre
//    from plantilla
//    union
//    select emp_no, apellido, oficio, salario, (select dnombre from dept
//	  where (dept.dept_no = emp.dept_no))
//	  from emp
//    union
//    select doctor_no, apellido, especialidad,
//    salario, (select nombre from hospital
//	  where (hospital.hospital_cod = doctor.hospital_cod))
//	  from doctor
//go
#endregion

namespace MvcEntityFramework.Repositories
{
    public class RepositoryTodosEmpleados
    {
        HospitalContext context;

        public RepositoryTodosEmpleados(HospitalContext context)
        {
            this.context = context;
        }

        public List<String> GetNombres()
        {
            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand())
            {
                String sql = "procehospitalesdepartamentos";
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = sql;
                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();
                List<string> nombres = new List<string>();
                while (reader.Read())
                {
                    nombres.Add(reader["NOMBRE"].ToString());
                }
                reader.Close();
                com.Connection.Close();
                return nombres;
            }
        }

        public ProcedimientoTodosEmpleados GetTodosEmpleados(String nombre)
        {
            String sql = "procetodosempleados @nombre, "
                + "@suma out, @media out";
            SqlParameter pamnom = new SqlParameter("@nombre", nombre);
            //LOS PARÁMETROS DE SALIDA DEBEN TENER UN VALOR POR DEFECTO
            //PARA PODER EJECUTAR LOS PROCEDIMIENTOS
            SqlParameter pamsum = new SqlParameter("@suma", -1);
            //INDICAMOS LA DIRECCIÓN DEL PARÁMETRO
            pamsum.Direction = System.Data.ParameterDirection.Output;
            SqlParameter pammed = new SqlParameter("@media", -1);
            pammed.Direction = System.Data.ParameterDirection.Output;
            List<TodosEmpleados> empleados =
                this.context.TodosEmpleados.FromSqlRaw(sql, pamnom, pamsum, pammed).ToList();
            ProcedimientoTodosEmpleados salida = new ProcedimientoTodosEmpleados();
            salida.Empleados = empleados;
            salida.SumaSalarial = Convert.ToInt32(pamsum.Value);
            salida.MediaSalarial = Convert.ToInt32(pammed.Value);
            return salida;
        }
    }
}
