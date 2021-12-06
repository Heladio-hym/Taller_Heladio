using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.DTOS
{
    public class EntradaDTO
    {
        public int IdProveedor { get; set; }

        public int Estado { get; set; }

        public List<EntradaDetalleDTO> Detalle { get; set; }
    }
    public class EntradaDetalleDTO 
    {

        public int IdRefaccion { get; set; }

        public double Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}
