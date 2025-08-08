using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// AutoMapper profile for GetAllProducts operations
/// </summary>
public class GetAllProductsProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetAllProductsProfile
    /// </summary>
    public GetAllProductsProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Rating, RatingDto>();
    }
}
