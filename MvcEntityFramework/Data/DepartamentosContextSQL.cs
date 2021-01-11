using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MvcEntityFramework.Data
{
    public class DepartamentosContextSQL : IDepartamentosContext
    {
        private SqlDataAdapter addept;
        private DataTable tabladept;

        public DepartamentosContextSQL(String cadena)
        {
            //String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            this.addept = new SqlDataAdapter("select * from dept", cadena);
            this.tabladept = new DataTable();
            this.addept.Fill(this.tabladept);
        }

        public List<Departamento> GetDepartamentos()
        {
            //SELECT CON LINQ
            var consulta = from datos in this.tabladept.AsEnumerable()
                           select datos;
            List<Departamento> departamentos = new List<Departamento>();
            //RECORREMOS TODOS LOS DATOS DE LA CONSULTA Y EXTRAEMOS CADA DEPARTAMENTO
            foreach (var dato in consulta)
            {
                //CREAMOS UN OBJETO DEPARTAMENTO Y LO INCLUIMOS EN LA LISTA
                Departamento dept = new Departamento();
                dept.Numero = dato.Field<int>("dept_no");
                dept.Nombre = dato.Field<String>("dnombre");
                dept.Localidad = dato.Field<String>("loc");
                departamentos.Add(dept);
            }
            return departamentos;
        }
    }
}
