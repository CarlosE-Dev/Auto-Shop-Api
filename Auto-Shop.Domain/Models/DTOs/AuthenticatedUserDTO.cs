namespace Auto_Shop.Domain.Models.DTOs
{
    public class AuthenticatedUserDTO
    {
        public string UserId { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
