using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Taller_Heladio.api.DTOS;

namespace Taller_Heladio.api.Modelos
{
    public class EntradaDetalle
    {
        public EntradaDetalle()
        {

        }

        public EntradaDetalle(EntradaDetalleDTO nuevo)
        {
            this.IdRefaccion = nuevo.IdRefaccion;
            this.Cantidad = nuevo.Cantidad;
            this.Precio = nuevo.Precio;
            this.Activo = true;
        }

        [Key]
        public int IdEntradaDetalle { get; set; }


        public int IdEntrada { get; set; }

        public int IdRefaccion { get; set; }

        [Required]
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
