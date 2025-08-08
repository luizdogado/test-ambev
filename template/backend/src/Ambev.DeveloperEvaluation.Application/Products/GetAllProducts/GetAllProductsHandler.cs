using AutoMapper;
using MediatR;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Application.Products.Shared;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Handler for processing GetAllProductsCommand requests
/// </summary>
public class GetAllProductsHandler : IRequestHandler<GetAllProductsCommand, GetAllProductsResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetAllProductsHandler
    /// </summary>
    /// <param name="productRepository">The product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public GetAllProductsHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetAllProductsCommand request
    /// </summary>
    /// <param name="command">The GetAllProducts command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of all products</returns>
    public async Task<GetAllProductsResult> Handle(GetAllProductsCommand command, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync(cancellationToken);
        var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
        
        return new GetAllProductsResult
        {
            Products = productDtos
        };
    }
}
