using AutoMapper;
using ExamenDan.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenDan.Mappings
{
    public class InventarioProfile: Profile
    {
        public InventarioProfile()
        {
            CreateMap<Domain.Inventario, ProductoDTO>()
                .ForMember(x => x.CodigoBarra, y => y.MapFrom (z => z.Producto.CodigoBarra))
                .ForMember(x => x.NombreSucursal, y => y.MapFrom(z => z.Sucursal.Nombre))
                .ForMember(x => x.Precio_Unitario, y => y.MapFrom(z => z.Producto.PrecioUnitario))
                .ForMember(x => x.NombreProducto, y => y.MapFrom(z => z.Producto.Descripcion)).ReverseMap();

        }

    }
}
