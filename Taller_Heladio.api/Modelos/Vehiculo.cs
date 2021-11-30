using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }

        [Required]
        public int IdMarca { get; set; }

        [Required]
        [MaxLength(10)]
        public string Placas { get; set; }

        [Required]
        public int IdColor { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Range(0,double.MaxValue)]
        public double Kilometraje { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdMarca")]
        public virtual Marca Marca { get; set; }

        [ForeignKey("IdColor")]
        public virtual Color Color { get; set; }

    }
}
