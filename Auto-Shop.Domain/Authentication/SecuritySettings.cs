using System;

namespace Auto_Shop.Domain.Authentication
{
    public static class SecuritySettings
    {
        public static string Code { get; private set; } = "F83AD6DB-0530-4D46-A188-9413C2227860";
        public static DateTime TimeToExpire { get; private set; } = DateTime.UtcNow.AddHours(2);
    }
}
