using AutoMapper;
using ExamenDan.DTOS;
using ExamenDan.Repository.Inventario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenDan.CQRS.Inventario.Queries
{
    public class ObtenerInventarioQuery: IRequest<List<ProductoDTO>>
    {

        public int? ProductoId { get; set; } = null;

        public ObtenerInventarioQuery()
        {
           
        }

        public ObtenerInventarioQuery(int? productoId)
        {
            ProductoId = productoId;

        }

    }

    public class ObtenerInventarioQueryHandler : IRequestHandler<ObtenerInventarioQuery, List<ProductoDTO>>
    {
        private readonly IInventarioRepository _repo;
        private readonly IMapper _Mapper;

        public ObtenerInventarioQueryHandler(IInventarioRepository repo, IMapper mapper)
        {
            _repo = repo;
            _Mapper = mapper;
        }

        public async Task<List<ProductoDTO>> Handle(ObtenerInventarioQuery request, CancellationToken cancellationToken)
        {
            var Inventarios = await  _repo.ObtenerProductos(request.ProductoId);
            var Productos = _Mapper.Map<List<ProductoDTO>>(Inventarios);

            return Productos;
           
        }

    }
}
