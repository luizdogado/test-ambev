using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Handler for processing UpdateProductCommand requests
/// </summary>
public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of UpdateProductHandler
    /// </summary>
    /// <param name="productRepository">The product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public UpdateProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the UpdateProductCommand request
    /// </summary>
    /// <param name="command">The UpdateProduct command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated product details</returns>
    public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateProductCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var existingProduct = await _productRepository.GetByIdAsync(command.Id, cancellationToken);
        if (existingProduct == null)
            throw new InvalidOperationException($"Product with ID {command.Id} not found");

        // Update the product properties
        existingProduct.Title = command.Title;
        existingProduct.Price = command.Price;
        existingProduct.Description = command.Description;
        existingProduct.Image = command.Image;
        existingProduct.Category = command.Category;

        // Update the rating information
        if (command.Rating != null)
        {
            if (existingProduct.Rating == null)
            {
                existingProduct.Rating = new Rating();
            }
            
            existingProduct.Rating.Rate = command.Rating.Rate;
            existingProduct.Rating.Count = command.Rating.Count;
        }

        var updatedProduct = await _productRepository.UpdateAsync(existingProduct, cancellationToken);
        var result = _mapper.Map<UpdateProductResult>(updatedProduct);
        return result;
    }
}
