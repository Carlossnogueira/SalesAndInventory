using FluentValidation;
using SalesAndInventory.Communication.Request;

namespace SalesAndInventory.Application.UseCase.User.Register;

public class RegisterUserValidator : AbstractValidator<RequestRegisterUserJson>
{
    public RegisterUserValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty();
        RuleFor(u => u.Login)
            .NotEmpty()
            .MinimumLength(5)
            .MaximumLength(12);
        RuleFor(u => u.Password)
            .NotEmpty()
            .MinimumLength(8)
            .MaximumLength(12);
    }
}