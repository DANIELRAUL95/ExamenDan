using ExamenDan.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenDan.Domain;

namespace ExamenDan.Repository.Inventario
{
    public interface IInventarioRepository
    {
        Task<List<Domain.Inventario>> ObtenerProductos(int? iDProducto);

        Task<int> ActualizaExistencia(Domain.Inventario inv);

        Task<Domain.Inventario> ObtenerInventario(int idProducto, int idSucursal);

    }
}
