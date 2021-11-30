using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Refaccion
    {
        [Key]
        public int IdRefaccion { get; set; }

        [MaxLength(40)]
        [Required]
        public string Nombre  { get; set; }

        [Required]
        public decimal Precio { get; set; }


        public int IdCategoria { get; set; }

        public double Existencia { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        public virtual List<EntradaDetalle> EntradaDetalle { get; set; }
    }
}
