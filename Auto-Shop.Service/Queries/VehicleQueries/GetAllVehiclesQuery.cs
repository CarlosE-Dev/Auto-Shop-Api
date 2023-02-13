using Auto_Shop.Domain.Enums;
using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models.DTOs;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Queries.VehicleQueries
{
    public class GetAllVehiclesQuery : IRequest<IEnumerable<VehicleDTO>>
    {
        public string OrderBy { get; set; }
        public EOrderType? OrderType { get; set; }
    }

    public class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQuery, IEnumerable<VehicleDTO>>
    {
        private readonly IVehicleService _service;

        public GetAllVehiclesQueryHandler(IVehicleService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<VehicleDTO>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetAllVehiclesAsync(request.OrderBy, request.OrderType);
        }
    }
}