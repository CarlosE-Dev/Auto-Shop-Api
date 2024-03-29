﻿using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using AutoMapper;
using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Commands.VehicleCommands
{
    public class CreateVehicleCommand : IRequest<VehicleDTO>
    {
        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(225, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(8, ErrorMessage = "The length of the field {0} must be {1} characters", MinimumLength = 8)]
        public string BrandId { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(30, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 3)]
        public string Model { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(500, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 5)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(4, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 4)]
        public string Year { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(9, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 2)]
        public string Km { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(100, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        [StringLength(2, ErrorMessage = "The length of the field {0} must be {1} characters", MinimumLength = 2)]
        public string State { get; set; }
    }

    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, VehicleDTO>
    {
        private readonly IVehicleService _service;
        private readonly IMapper _mapper;

        public CreateVehicleCommandHandler(
            IVehicleService service, 
            IMapper mapper
            )
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<VehicleDTO> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateVehicleAsync(_mapper.Map<Vehicle>(request));
        }
    }
}
