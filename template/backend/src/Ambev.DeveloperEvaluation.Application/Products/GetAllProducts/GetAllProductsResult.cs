using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Response model for GetAllProducts operation
/// </summary>
public class GetAllProductsResult
{
    /// <summary>
    /// List of all products
    /// </summary>
    public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
}
