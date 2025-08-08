using AutoMapper;
using MediatR;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProductsByCategory;

/// <summary>
/// Handler for processing GetProductsByCategoryCommand requests
/// </summary>
public class GetProductsByCategoryHandler : IRequestHandler<GetProductsByCategoryCommand, GetProductsByCategoryResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetProductsByCategoryHandler
    /// </summary>
    /// <param name="productRepository">The product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public GetProductsByCategoryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetProductsByCategoryCommand request
    /// </summary>
    /// <param name="command">The GetProductsByCategory command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of products in the specified category</returns>
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryCommand command, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetByCategoryAsync(command.Category, cancellationToken);
        var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
        
        return new GetProductsByCategoryResult
        {
            Category = command.Category,
            Products = productDtos
        };
    }
}
