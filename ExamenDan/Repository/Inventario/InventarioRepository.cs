using ExamenDan.Domain;
using ExamenDan.DTOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenDan.Repository.Inventario
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly TestContext _Context;

        public InventarioRepository(TestContext context)
        {
            _Context = context;
        }

        public async Task<int> ActualizaExistencia(Domain.Inventario inv)
        {
            _Context.Inventarios.Attach(inv);
            _Context.Entry(inv).State = EntityState.Modified;

            return await _Context.SaveChangesAsync();


            
        }

        public async Task<List<Domain.Inventario>> ObtenerProductos(int? iDProducto)
        {
            return await _Context.Inventarios.Include(x => x.Producto).Include(y => y.Sucursal )
                .Where(x => x.ProductoId == (iDProducto.HasValue ? iDProducto.Value : x.ProductoId))
                .ToListAsync();
        }
      public async  Task<Domain.Inventario> ObtenerInventario(int idProducto, int idSucursal)
        {
            return await _Context.Inventarios.Include(x => x.Producto).Include(y => y.Sucursal)
           .FirstOrDefaultAsync(x => x.ProductoId == idProducto && x.SucursalId == idSucursal);
        }
    }



}
