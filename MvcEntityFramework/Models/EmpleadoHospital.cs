using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("empleadoshospital")]
    public class EmpleadoHospital
    {

        [Key]
        [Column("idempleado")]
        public int IdEmpleado { get; set; }
        [Column("apellido")]
        public String Apellido { get; set; }
        [Column("funcion")]
        public String Funcion { get; set; }
        [Column("salario")]
        public int Salario { get; set; }
        [Column("hospital_cod")]
        public int Hospital { get; set; }
    }
}
