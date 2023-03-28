namespace Auto_Shop.Domain.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
    }
}
