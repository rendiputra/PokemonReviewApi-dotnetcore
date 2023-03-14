using PokemonReviewApi.Models;

namespace PokemonReviewApi.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int reviewId);
        bool ReviewExists(int reviewId);
    }
}
