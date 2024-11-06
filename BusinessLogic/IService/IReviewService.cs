using Models;

namespace BusinessLogic.IService
{
    public interface IReviewService
    {
        Task<List<Review>> ListReview();
        Task<List<Review>> ListReviewProduct(string productId);
        Task<Review?> GetReview(string productId);
        Task<bool> AddReview(Review review);
        Task<bool> Delete(string reviewId);
    }
}
