using PokemonReviewApp.Model;

namespace PokemonReviewApp.Interface
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        bool CreateReview(Review reviewMap);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool Save();
        bool DeleteReviews(List<Review> reviews);
    }
}
