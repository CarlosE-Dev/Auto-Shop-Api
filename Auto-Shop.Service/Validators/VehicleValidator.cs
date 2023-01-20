using Auto_Shop.Domain.Models;
using FluentValidation;

namespace Auto_Shop.Service.Validators
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("The name is required.")
                .NotNull().WithMessage("The name is required.");
        }
    }
}
