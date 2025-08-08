using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// AutoMapper profile for UpdateProduct operations
/// </summary>
public class UpdateProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of UpdateProductProfile
    /// </summary>
    public UpdateProductProfile()
    {
        CreateMap<Product, UpdateProductResult>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
