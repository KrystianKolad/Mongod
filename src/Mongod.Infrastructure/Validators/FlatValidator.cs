using FluentValidation;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Validators
{
    public class FlatValidator : AbstractValidator<FlatModel>
    {
        public FlatValidator()
        {
            RuleFor(x=>x.RoomsCount)
                .Must(x => x > 0);

            RuleFor(x=>x.Address)
                .SetValidator(new AddressValidator());

            RuleFor(x=>x.Owner)
                .SetValidator(new UserValidator());
        }
    }
}