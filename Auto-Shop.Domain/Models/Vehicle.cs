namespace Auto_Shop.Domain.Models
{
    public class Vehicle : BaseModel
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public string Year { get; set; }
    }
}
