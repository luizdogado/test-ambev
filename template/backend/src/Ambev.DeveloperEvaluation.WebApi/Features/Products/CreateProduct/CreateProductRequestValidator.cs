using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(product => product.Title).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(product => product.Price).InclusiveBetween(0, 999999999999999.99m)
                .WithMessage("The amount must be between 0 and 99999.99.");
            RuleFor(product => product.Description).MaximumLength(500);
            RuleFor(product => product.Image).MaximumLength(2500);
            RuleFor(product => product.Category).NotEmpty().NotNull().MaximumLength(100);
        }
    }
}
