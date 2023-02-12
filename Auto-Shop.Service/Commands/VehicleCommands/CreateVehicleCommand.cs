using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Validators;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Commands.VehicleCommands
{
    public class CreateVehicleCommand : BaseCommand, IRequest<Vehicle>
    {
        public string Name { get; set; }
        public string BrandId { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string Km { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Vehicle>
    {
        private readonly IVehicleService _service;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CreateVehicleCommandHandler(
            IVehicleService service, 
            IMediator mediator, 
            IMapper mapper
            )
        {
            _service = service;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Vehicle> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateAsync<VehicleValidator>(_mapper.Map<Vehicle>(request));
        }
    }
}
