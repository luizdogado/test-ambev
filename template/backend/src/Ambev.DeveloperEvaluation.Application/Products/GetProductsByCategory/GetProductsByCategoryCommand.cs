using MediatR;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProductsByCategory;

/// <summary>
/// Command for retrieving products by category
/// </summary>
public record GetProductsByCategoryCommand : IRequest<GetProductsByCategoryResult>
{
    /// <summary>
    /// The category to filter products by
    /// </summary>
    public string Category { get; }

    /// <summary>
    /// Initializes a new instance of GetProductsByCategoryCommand
    /// </summary>
    /// <param name="category">The category to filter by</param>
    public GetProductsByCategoryCommand(string category)
    {
        Category = category;
    }
}
