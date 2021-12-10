using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class OrdenServicio
    {

        [Key]
        public int IdOrden { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdMecanico { get; set; }

        [Required]
        public int IdVeiculo { get; set; }

        [Required]
        public bool Autorizado { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdMecanico")]
        public virtual Mecanico Mecanico { get; set; }
        [ForeignKey("IdVeiculo")]
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual List<OrdenServicioDetalle> OrdenServicioDetalle { get; set; }

    }

}
