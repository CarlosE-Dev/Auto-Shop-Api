using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using AutoMapper;
using MediatR;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Queries.VehicleQueries
{
    public class GetVehicleByIdQuery : IRequest<VehicleDTO>
    {
        [JsonIgnore]
        public string Id { get; set; }
    }

    public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery, VehicleDTO>
    {
        private readonly IVehicleService _service;

        public GetVehicleByIdQueryHandler(IVehicleService service)
        {
            _service = service;
        }

        public async Task<VehicleDTO> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetVehicleByIdAsync(request.Id);
        }
    }
}