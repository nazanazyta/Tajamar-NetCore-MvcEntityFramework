using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MvcEntityFramework.Data
{
    public class DepartamentosContextMySql : IDepartamentosContext
    {
        private MySqlDataAdapter addept;
        private DataTable tabladept;

        public DepartamentosContextMySql(String cadena)
        {
            this.addept = new MySqlDataAdapter("select * from dept", cadena);
            this.tabladept = new DataTable();
            this.addept.Fill(this.tabladept);
        }

        public List<Departamento> GetDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            var consulta = from datos in this.tabladept.AsEnumerable()
                           select datos;
            foreach(var fila in consulta)
            {
                Departamento dept = new Departamento();
                dept.Numero = fila.Field<int>("dept_no");
                dept.Nombre = fila.Field<String>("dnombre");
                dept.Localidad = fila.Field<String>("loc");
                departamentos.Add(dept);
            }
            return departamentos;
        }
    }
}
