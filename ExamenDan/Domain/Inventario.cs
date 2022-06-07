using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenDan.Domain
{
    public  class Inventario
    {
        public int ProductoId { get; set; }
        public int SucursalId { get; set; }
        public int Existencia { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Sucursal Sucursal { get; set; }
    }
}
