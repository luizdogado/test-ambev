using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetAllProducts;

/// <summary>
/// AutoMapper profile for GetAllProducts operations in WebApi
/// </summary>
public class GetAllProductsProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetAllProductsProfile
    /// </summary>
    public GetAllProductsProfile()
    {
        CreateMap<GetAllProductsResult, GetAllProductsResponse>();
    }
}
