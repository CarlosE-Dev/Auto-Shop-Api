using Auto_Shop.Domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Commands.VehicleCommands
{
    public class DeleteVehicleCommand : IRequest
    {
        [JsonIgnore]
        public string Id { get; set; }
    }

    public class DeleteVehicleCommandHandler : IRequestHandler<DeleteVehicleCommand>
    {
        private readonly IVehicleService _service;
        private readonly IMapper _mapper;

        public DeleteVehicleCommandHandler(
            IVehicleService service,
            IMapper mapper
            )
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteVehicleCommand request, CancellationToken cancellationToken)
        {
            await _service.DeleteAsync(request.Id);

            return await Task.FromResult(Unit.Value);
        }
    }
}
