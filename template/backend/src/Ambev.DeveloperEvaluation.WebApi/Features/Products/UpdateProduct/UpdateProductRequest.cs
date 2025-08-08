using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// Represents a request to update an existing product in the system.
/// </summary>
public class UpdateProductRequest
{
    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the description the product.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the image.
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    public string Category { get; set; } = string.Empty;

    public RatingDto Rating { get; set; } = new();
}
