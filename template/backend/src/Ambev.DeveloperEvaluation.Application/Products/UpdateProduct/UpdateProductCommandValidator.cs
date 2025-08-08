using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductCommand that defines validation rules for product update command.
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Must be greater than 0
    /// - Title: Required, must be between 1 and 100 characters
    /// - Price: Must be greater than 0
    /// - Description: Optional, must be between 0 and 500 characters if provided
    /// - Image: Optional, must be a valid URL if provided
    /// - Category: Required, must be between 1 and 100 characters
    /// - Rating: Optional, rate must be between 0 and 5 if provided, count must be non-negative
    /// </remarks>
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.Id)
            .GreaterThan(0).WithMessage("Product ID must be greater than 0");

        RuleFor(product => product.Title)
            .NotEmpty().WithMessage("Title is required")
            .Length(1, 100).WithMessage("Title must be between 1 and 100 characters");

        RuleFor(product => product.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0");

        RuleFor(product => product.Description)
            .MaximumLength(500).WithMessage("Description must not exceed 500 characters");

        RuleFor(product => product.Image)
            .Must(BeValidUrl).When(product => !string.IsNullOrEmpty(product.Image))
            .WithMessage("Image must be a valid URL");

        RuleFor(product => product.Category)
            .NotEmpty().WithMessage("Category is required")
            .Length(1, 100).WithMessage("Category must be between 1 and 100 characters");

        RuleFor(product => product.Rating.Rate)
            .InclusiveBetween(0, 5).When(product => product.Rating.Rate.HasValue)
            .WithMessage("Rating rate must be between 0 and 5");

        RuleFor(product => product.Rating.Count)
            .GreaterThanOrEqualTo(0).WithMessage("Rating count must be non-negative");
    }

    private static bool BeValidUrl(string? url)
    {
        if (string.IsNullOrEmpty(url))
            return true;

        return Uri.TryCreate(url, UriKind.Absolute, out _);
    }
}
