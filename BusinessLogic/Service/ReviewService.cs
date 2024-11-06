using BusinessLogic.IService;
using DataAccess.DAO;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class ReviewService : IReviewService
    {
        private IReviewRepo repo;

        public ReviewService()
        {
            repo = new ReviewRepo();
        }
        public async Task<bool> AddReview(Review review) => await repo.AddReview(review);

        public async Task<bool> Delete(string reviewId) => await repo.Delete(reviewId);

        public async Task<Review?> GetReview(string productId) => await repo.GetReview(productId);

        public async Task<List<Review>> ListReview() => await repo.ListReview();

        public async Task<List<Review>> ListReviewProduct(string productId) => await repo.ListReviewProduct(productId);
    }
}
