using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Models
{
    [Table("hospital")]

    public class Hospital
    {
        [Key]
        //OBLIGATORIO PORQUE TIENEN NOMBRES
        //DIFERENTES LA COLUMNA Y LA PROPIEDAD
        [Column("hospital_cod")]
        public int IdHospital { get; set; }
        [Column("nombre")]
        public String Nombre { get; set; }
        [Column("direccion")]
        public String Direccion { get; set; }
        [Column("telefono")]
        public String Telefono { get; set; }
        //OBLIGATORIO PORQUE TIENEN NOMBRES
        //DIFERENTES LA COLUMNA Y LA PROPIEDAD
        [Column("num_cama")]
        public int NumCama { get; set; }
    }
}
