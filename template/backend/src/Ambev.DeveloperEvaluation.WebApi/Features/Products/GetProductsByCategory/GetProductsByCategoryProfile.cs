using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.GetProductsByCategory;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProductsByCategory;

/// <summary>
/// AutoMapper profile for GetProductsByCategory operations in WebApi
/// </summary>
public class GetProductsByCategoryProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetProductsByCategoryProfile
    /// </summary>
    public GetProductsByCategoryProfile()
    {
        CreateMap<GetProductsByCategoryResult, GetProductsByCategoryResponse>();
    }
}
