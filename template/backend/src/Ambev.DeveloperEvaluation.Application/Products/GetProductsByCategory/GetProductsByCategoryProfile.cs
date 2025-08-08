using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProductsByCategory;

/// <summary>
/// AutoMapper profile for GetProductsByCategory operations
/// </summary>
public class GetProductsByCategoryProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetProductsByCategoryProfile
    /// </summary>
    public GetProductsByCategoryProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Rating, RatingDto>();
    }
}
