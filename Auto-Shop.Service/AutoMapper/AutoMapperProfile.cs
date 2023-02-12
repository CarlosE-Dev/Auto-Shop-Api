using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Commands.VehicleCommands;
using AutoMapper;

namespace Auto_Shop.Service.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VehicleDTO, Vehicle>().ReverseMap();
            CreateMap<CreateVehicleCommand, Vehicle>().ReverseMap();
        }
    }
}
