using System;

namespace Auto_Shop.Domain.Models.DTOs
{
    public class VehicleDTO : BaseModel
    { 
        public string Name { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string Km { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string BrandName { get; set; }
        public string BrandId { get; set; }
    }
}
