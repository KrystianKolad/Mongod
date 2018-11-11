using FluentValidation;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Validators
{
    public class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            RuleFor(x=>x.City)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.Street)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.ZipCode)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.FlatNumber)
                .Must(y=>y>0);

            RuleFor(x=>x.BuildingNumber)
                .Must(y=>y>0);
        }
    }
}