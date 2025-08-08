using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// AutoMapper profile for GetProduct operations
/// </summary>
public class GetProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetProductProfile
    /// </summary>
    public GetProductProfile()
    {
        CreateMap<Product, GetProductResult>();
        CreateMap<Rating, RatingDto>();
    }
}
