using System;

namespace Auto_Shop.Domain.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            CreatedOn = DateTime.Now;
        }

        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
