using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// AutoMapper profile for DeleteProduct operations in WebApi
/// </summary>
public class DeleteProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of DeleteProductProfile
    /// </summary>
    public DeleteProductProfile()
    {
        CreateMap<DeleteProductResult, DeleteProductResponse>();
    }
}
