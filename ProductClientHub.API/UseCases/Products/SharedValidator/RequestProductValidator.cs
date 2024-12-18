using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator;

public class RequestProductValidator : AbstractValidator<RequestProductJson>
{
    public RequestProductValidator()
    {
        RuleFor(product =>  product.Name).NotEmpty().WithMessage("Invalid product name");
        RuleFor(product =>  product.Brand).NotEmpty().WithMessage("Invalid product brand");
        RuleFor(product =>  product.Price).GreaterThan(0).WithMessage("Invalid product price");
    }
}
