using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// AutoMapper profile for GetProduct operations in WebApi
/// </summary>
public class GetProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetProductProfile
    /// </summary>
    public GetProductProfile()
    {
        CreateMap<GetProductResult, GetProductResponse>();
    }
}
