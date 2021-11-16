using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Servicios
    {
        [Key]
        public int IdServicios { get; set; }
        [MaxLength(30)]
        [Required]
        public String Nombre { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int TipoServicio { get; set; }
        [Required]
        public bool Activo { get; set; }
    }   
}
