using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    public class ProcedimientoTodosEmpleados
    {
        public List<TodosEmpleados> Empleados { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
    }
}
