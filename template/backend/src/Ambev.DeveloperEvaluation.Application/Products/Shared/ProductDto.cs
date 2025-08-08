namespace Ambev.DeveloperEvaluation.Application.Products.Shared;

/// <summary>
/// DTO for product information to be reused across different product-related commands/results
/// </summary>
public class ProductDto
{
    /// <summary>
    /// The unique identifier of the product
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The product's title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The product's price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// The product's description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The product's image URL
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// The product's category
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// The product's rating information
    /// </summary>
    public RatingDto Rating { get; set; } = new();
}
