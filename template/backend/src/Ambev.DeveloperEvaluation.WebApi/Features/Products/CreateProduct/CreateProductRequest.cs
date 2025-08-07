using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Represents a request to create a new product in the system.
    /// </summary>
    public class CreateProductRequest
    {
        /// <summary>
        /// Gets or sets the tittle.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description the product.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string? Image { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        public RatingDto Rating { get; set; } = new();
    }
}
