using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Client.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("Name cannot be empty");
        RuleFor(client => client.Email).EmailAddress().WithMessage("Email is not valid");
    }
}
