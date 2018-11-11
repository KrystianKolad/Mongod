using FluentValidation;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Validators
{
    public class AdValidator : AbstractValidator<AdModel>
    {
        public AdValidator()
        {
            RuleFor(x=>x.Title)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.Description)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.Address)
                .SetValidator(new AddressValidator());

            RuleFor(x=>x.Owner)
                .SetValidator(new UserValidator());
        }
    }
}