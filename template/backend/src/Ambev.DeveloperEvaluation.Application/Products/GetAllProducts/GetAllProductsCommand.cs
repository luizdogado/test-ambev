using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Command for retrieving all products
/// </summary>
public record GetAllProductsCommand : IRequest<GetAllProductsResult>
{
    /// <summary>
    /// Initializes a new instance of GetAllProductsCommand
    /// </summary>
    public GetAllProductsCommand()
    {
    }
}
