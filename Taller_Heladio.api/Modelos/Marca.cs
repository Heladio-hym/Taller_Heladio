using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        public int Nombre { get; set; }
        [Required]
        [MaxLength]
        public bool Activo { get; set; }

    }
}
