using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("doctor")]
    public class Doctor
    {
        [Key]
        [Column("doctor_no")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDoctor { get; set; }
        [Column("apellido")]
        public String Apellido { get; set; }
        [Column("especialidad")]
        public String Especialidad { get; set; }
        [Column("salario")]
        public int Salario { get; set; }
        [Column("hospital_cod")]
        public int Hospital { get; set; }
    }
}
