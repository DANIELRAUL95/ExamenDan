using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenDan.Models
{
    public class Sucursales
    {

        public int ID { get; set; }

        public string Nombre { get; set; }

        public int Codigo_Barra { get; set; }

        public int Cantidad_Producto_Sucursal_A { get; set; }

        public int Cantidad_Producto_Sucursal_B { get; set; }

        public int Precio_Unitario { get; set; }
    }
}
