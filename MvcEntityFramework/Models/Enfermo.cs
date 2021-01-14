using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("enfermo")]
    public class Enfermo
    {
        [Key]
        [Column("inscripcion")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Inscripcion { get; set; }
        [Column("apellido")]
        public String Apellido { get; set; }
        [Column("direccion")]
        public String Direccion { get; set; }
        [Column("fecha_nac")]
        public DateTime FechaNacimiento { get; set; }
        [Column("s")]
        public String Sexo { get; set; }
        [Column("nss")]
        public String SeguridadSocial { get; set; }
    }
}
