using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class OrdenServicioDetalle
    {

        [Key]
        public int IdOrdenServicioDetalle { get; set; }

        [Required]
        public int IdOrden { get; set; }

        [Required]
        public decimal Cantidad { get; set; }

        [Required]
        public decimal Costo { get; set; }

        [Required]
        public DateTime FechaRealizado { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public bool Activo { get; set; }

    }
}
