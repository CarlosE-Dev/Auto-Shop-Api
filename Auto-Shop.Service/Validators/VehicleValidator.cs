using Auto_Shop.Domain.Models;
using FluentValidation;

namespace Auto_Shop.Service.Validators
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Field Name is required.")
                .NotNull()
                .WithMessage("Field Name is required.")
                .MinimumLength(3)
                .MaximumLength(225);

            RuleFor(p => p.State)
                .NotEmpty()
                .WithMessage("Field State is required.")
                .NotNull()
                .WithMessage("Field State is required.")
                .Length(2);

            RuleFor(p => p.City)
                .NotEmpty()
                .WithMessage("Field City is required.")
                .NotNull()
                .WithMessage("Field City is required.")
                .MinimumLength(3)
                .MaximumLength(100);

            RuleFor(p => p.ImageUrl)
                .MinimumLength(5)
                .MaximumLength(500);

            RuleFor(p => p.Year)
                .NotEmpty()
                .WithMessage("Field Year is required.")
                .NotNull()
                .WithMessage("Field Year is required.")
                .MinimumLength(4)
                .MaximumLength(9);

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("Field Price is required.")
                .NotNull()
                .WithMessage("Field Price is required.")
                .GreaterThanOrEqualTo(0);

            RuleFor(p => p.Model)
                .NotEmpty()
                .WithMessage("Field Model is required.")
                .NotNull()
                .WithMessage("Field Model is required.")
                .MinimumLength(3)
                .MaximumLength(30);

            RuleFor(p => p.Km)
                .NotEmpty()
                .WithMessage("Field Km is required.")
                .NotNull()
                .WithMessage("Field Km is required.")
                .MinimumLength(2)
                .MaximumLength(9);

            RuleFor(p => p.BrandId)
                .NotEmpty()
                .WithMessage("Field BrandId is required.")
                .NotNull()
                .WithMessage("Field BrandId is required.")
                .Length(8);
        }
    }
}
