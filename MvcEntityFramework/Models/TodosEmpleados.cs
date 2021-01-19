using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("todosempleados")]
    public class TodosEmpleados
    {
        [Key]
        [Column("idempleado")]
        public int IdEmpleado { get; set; }
        [Column("Apellido")]
        public String Apellido { get; set; }
        [Column("funcion")]
        public String Funcion { get; set; }
        [Column("Salario")]
        public int Salario { get; set; }
        [Column("nombre")]
        public String Nombre { get; set; }
    }
}
