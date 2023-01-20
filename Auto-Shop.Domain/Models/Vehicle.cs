namespace Auto_Shop.Domain.Models
{
    public class Vehicle : BaseModel
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
        public Brand Brand { get; set; }

        // TODO: Create DTO
        public string BrandName { get; set; }
    }
}
