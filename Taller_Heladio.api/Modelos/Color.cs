using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Color
    {
        [Key]
        public int IdColor { get; set; }
        [MaxLength(30)]
        [Required]
        public String Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }

        public virtual List<Vehiculo> Vehiculo { get; set; }
    }
}
