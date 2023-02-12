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
            #region Vehicle

            CreateMap<Vehicle, VehicleDTO>().ReverseMap();
            CreateMap<Vehicle, CreateVehicleCommand>().ReverseMap();
            CreateMap<Vehicle, UpdateVehicleCommand>().ReverseMap();

            #endregion
        }
    }
}
