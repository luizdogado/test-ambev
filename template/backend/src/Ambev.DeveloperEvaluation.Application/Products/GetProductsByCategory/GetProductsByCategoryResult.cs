using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProductsByCategory;

/// <summary>
/// Response model for GetProductsByCategory operation
/// </summary>
public class GetProductsByCategoryResult
{
    /// <summary>
    /// The category that was searched
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// List of products in the specified category
    /// </summary>
    public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
}
