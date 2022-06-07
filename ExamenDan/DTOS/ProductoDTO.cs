using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenDan.DTOS
{
    
    public class ProductoDTO
    {
        public int ProductoId { get; set; }

        public int SucursalId { get; set; }

        public string NombreSucursal { get; set; }

        public string NombreProducto { get; set; }

        public int CodigoBarra { get; set; }

        public int Existencia { get; set; }

        public decimal Precio_Unitario { get; set; }
    }
}
