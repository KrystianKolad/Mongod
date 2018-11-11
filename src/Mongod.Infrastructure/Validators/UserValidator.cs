using FluentValidation;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Validators
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(x=>x.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(x=>x.Surname)
                .NotNull()
                .NotEmpty();
        }
    }
}