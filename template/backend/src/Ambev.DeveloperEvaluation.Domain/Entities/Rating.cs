using System.ComponentModel.DataAnnotations;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Rating
    {
        public int ProductId { get; set; }

        public decimal? Rate { get; set; }

        public int Count { get; set; }

        public Product Product { get; set; } = null!;
    }
}
