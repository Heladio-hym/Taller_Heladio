using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class EntradaDetalle
    {
        [Key]
        public int IdEntradaDetalle { get; set; }


        public int IdEntrada { get; set; }

        public int IdRefaccion { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Cantidad { get; set; }
        
        [Required]
        public decimal Precio { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdEntrada")]
        public virtual Entrada Entrada { get; set; }
        
        [ForeignKey("IdRefaccion")]
        public virtual Refaccion Refaccion { get; set; }
    }
}
