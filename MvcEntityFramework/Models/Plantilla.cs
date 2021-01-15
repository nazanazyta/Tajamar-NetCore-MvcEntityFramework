using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("plantilla")]
    public class Plantilla
    {
        [Key]
        [Column("empleado_no")]
        public int IdEmpleado { get; set; }
        [Column("apellido")]
        public String Apellido { get; set; }
        [Column("funcion")]
        public String Funcion { get; set; }
        [Column("salario")]
        public int Salario { get; set; }
    }
}
