using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcEntityFramework.Data;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure proceempleadoshospital
//(@hospitalcod int, @suma int out, @media int out)
//as
//    select* from empleadoshospital
//    where hospital_cod = @hospitalcod
//    select @suma = sum(salario), @media = AVG(salario)
//    from empleadoshospital
//    where hospital_cod = @hospitalcod
//go
#endregion

#region VISTAS
//create view empleadoshospital
//as
//    select isnull(empleado_no, 0) as IdEmpleado
//	  , apellido, funcion, salario, hospital_cod
//    from plantilla
//	  union
//	  select doctor_no, apellido, especialidad, salario
//    , hospital_cod
//	  from doctor
//go
#endregion

namespace MvcEntityFramework.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        HospitalContext context;

        public RepositoryEmpleadosHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<EmpleadoHospital> GetEmpleadosHospital()
        {
            var consulta = from datos in this.context.EmpleadosHospital
                           select datos;
            return consulta.ToList();
        }

        public ProcedimientoEmpleadoHospital GetEmpleadosHospital(int hospitalcod)
        {
            String sql = "proceempleadoshospital @hospitalcod, "
                + "@suma out, @media out";
            SqlParameter pamhosp = new SqlParameter("@hospitalcod", hospitalcod);
            //LOS PARÁMETROS DE SALIDA DEBEN TENER UN VALOR POR DEFECTO
            //PARA PODER EJECUTAR LOS PROCEDIMIENTOS
            SqlParameter pamsum = new SqlParameter("@suma", -1);
            //INDICAMOS LA DIRECCIÓN DEL PARÁMETRO
            pamsum.Direction = System.Data.ParameterDirection.Output;
            SqlParameter pammed = new SqlParameter("@media", -1);
            pammed.Direction = System.Data.ParameterDirection.Output;
            List<EmpleadoHospital> empleados =
                this.context.EmpleadosHospital.FromSqlRaw(sql, pamhosp, pamsum, pammed).ToList();
            ProcedimientoEmpleadoHospital salida = new ProcedimientoEmpleadoHospital();
            salida.Empleados = empleados;
            salida.SumaSalarial = Convert.ToInt32(pamsum.Value);
            salida.MediaSalarial = Convert.ToInt32(pammed.Value);
            return salida;
        }
    }
}
