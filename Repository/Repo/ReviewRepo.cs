using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class ReviewRepo : IReviewRepo
    {
        private ReviewDAO dao;

        public ReviewRepo()
        {
            dao = new();
        }
        public async Task<bool> AddReview(Review review) => await dao.AddReview(review);

        public async Task<bool> Delete(string reviewId) => await dao.Delete(reviewId);

        public async Task<Review?> GetReview(string productId) => await dao.GetReview(productId);

        public async Task<List<Review>> ListReview() => await dao.ListReview();

        public async Task<List<Review>> ListReviewProduct(string productId) => await dao.ListReviewProduct(productId);
    }
}
