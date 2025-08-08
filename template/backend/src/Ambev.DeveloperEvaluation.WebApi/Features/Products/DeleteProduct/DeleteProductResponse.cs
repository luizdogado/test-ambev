namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// Response model for DeleteProduct operation
/// </summary>
public class DeleteProductResponse
{
    /// <summary>
    /// Gets or sets a value indicating whether the product was successfully deleted.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Gets or sets the message describing the result of the delete operation.
    /// </summary>
    public string Message { get; set; } = string.Empty;
}
