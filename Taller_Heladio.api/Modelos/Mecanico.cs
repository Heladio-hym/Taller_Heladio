using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Mecanico
    {
        [Key]
        public int IdMecanico { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
