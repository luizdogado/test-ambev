using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// AutoMapper profile for UpdateProduct operations in WebApi
/// </summary>
public class UpdateProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of UpdateProductProfile
    /// </summary>
    public UpdateProductProfile()
    {
        CreateMap<UpdateProductRequest, UpdateProductCommand>();
        CreateMap<UpdateProductResult, UpdateProductResponse>();
        CreateMap<RatingDto, RatingDto>();
    }
}
