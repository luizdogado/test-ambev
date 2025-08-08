namespace Ambev.DeveloperEvaluation.Application.Products.Shared;

/// <summary>
/// DTO for rating information shared across product operations
/// </summary>
public class RatingDto
{
    /// <summary>
    /// Gets or sets the rating value.
    /// </summary>
    public decimal? Rate { get; set; }

    /// <summary>
    /// Gets or sets the count of ratings.
    /// </summary>
    public int Count { get; set; }
}
