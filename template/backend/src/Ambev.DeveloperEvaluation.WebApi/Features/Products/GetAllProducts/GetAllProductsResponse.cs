using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetAllProducts;

/// <summary>
/// Response model for GetAllProducts operation
/// </summary>
public class GetAllProductsResponse
{
    /// <summary>
    /// List of all products
    /// </summary>
    public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
}
