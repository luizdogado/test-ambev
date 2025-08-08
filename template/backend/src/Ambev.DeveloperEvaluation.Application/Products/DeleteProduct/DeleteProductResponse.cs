namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Result model for DeleteProduct operation
/// </summary>
public class DeleteProductResult
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
