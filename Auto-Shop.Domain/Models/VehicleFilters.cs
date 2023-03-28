namespace Auto_Shop.Domain.Models
{
    public class VehicleFilters
    {
        public PaginationModel Pagination { get; set; }
        public string FilterByBrandName { get; set; }
        public string FilterByVehicleName { get; set; }
    }
}
