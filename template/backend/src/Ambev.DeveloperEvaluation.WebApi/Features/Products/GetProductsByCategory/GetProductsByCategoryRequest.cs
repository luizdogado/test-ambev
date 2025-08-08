using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProductsByCategory;

/// <summary>
/// Request model for getting products by category
/// </summary>
public class GetProductsByCategoryRequest
{
    /// <summary>
    /// The category to filter products by
    /// </summary>
    public string Category { get; set; } = string.Empty;
}
