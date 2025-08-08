using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// AutoMapper profile for CreateProduct operations in WebApi
/// </summary>
public class CreateProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of CreateProductProfile
    /// </summary>
    public CreateProductProfile()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>();
        CreateMap<CreateProductResult, CreateProductResponse>();
        CreateMap<RatingDto, RatingDto>();
    }
}
