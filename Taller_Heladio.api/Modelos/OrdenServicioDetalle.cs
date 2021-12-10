using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class OrdenServicioDetalle
    {

        [Key]
        public int IdOrdenServicioDetalle { get; set; }

        [Required]
        public int IdOrdenServicio { get; set; }

        public int IdServicios { get; set; }
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


        [ForeignKey("IdOrdenServicio")]
        public virtual OrdenServicio OrdenServicio { get; set; }
        [ForeignKey("IdServicios")]
        public virtual Servicios Servicios { get; set; }

    }
}
