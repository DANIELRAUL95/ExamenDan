using AutoMapper;
using ExamenDan.DTOS;
using ExamenDan.Repository.Inventario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenDan.CQRS.Inventario.Commands
{
    public class UpdateInventarioCommand: IRequest<int>
    {
        public ProductoDTO Inventario { get; set; }

        public UpdateInventarioCommand(ProductoDTO inventario)
        {
            Inventario = inventario;
        }
    }

    public class UpdateInventarioCommandHandler : IRequestHandler<UpdateInventarioCommand, int>
    {
        private readonly IInventarioRepository _repo;
        private readonly IMapper _Mapper;

        public UpdateInventarioCommandHandler(IInventarioRepository repo, IMapper mapper)
        {
            _repo = repo;
            _Mapper = mapper;
        }

        public async Task<int> Handle(UpdateInventarioCommand request, CancellationToken cancellationToken)
        {
            var inventario = await _repo.ObtenerInventario(request.Inventario.ProductoId, request.Inventario.SucursalId);
            inventario.Existencia = request.Inventario.Existencia;
            int result =  await _repo.ActualizaExistencia(inventario);


            return result;
        }


    }
}
