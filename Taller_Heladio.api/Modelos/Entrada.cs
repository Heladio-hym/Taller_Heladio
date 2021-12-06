using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Taller_Heladio.api.DTOS;

namespace Taller_Heladio.api.Modelos
{
    public class Entrada
    {

        public Entrada()
        {

        }

        public Entrada(EntradaDTO nuevo)
        {
            this.Fecha = DateTime.Now;
            this.Activo = true;
            this.Estatus = nuevo.Estado;
            this.IdProveedor = nuevo.IdProveedor;

            foreach(var item in nuevo.Detalle)
            {
                this.EntradaDetalle.Add(new EntradaDetalle
                {
                    IdRefaccion = item.IdRefaccion,
                    Cantidad = item.Cantidad,
                    Precio = item.Precio,
                    Activo = true
                }) ;
                
            }
        }

        [Key]
        public int IdEntrada { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public int IdProveedor { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdProveedor")]
        public virtual Proveedor Proveedor { get; set; }

        public virtual List<EntradaDetalle> EntradaDetalle { get; set; }
    }
}
