using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// AutoMapper profile for CreateProduct operations
/// </summary>
public class CreateProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of CreateProductProfile
    /// </summary>
    public CreateProductProfile()
    {
        CreateMap<CreateProductCommand, Product>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Rating, opt => opt.Ignore()); // Rating is handled manually in the handler

        CreateMap<Product, CreateProductResult>();
    }
}
