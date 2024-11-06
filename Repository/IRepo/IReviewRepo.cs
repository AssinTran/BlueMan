using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IReviewRepo
    {
        Task<List<Review>> ListReview();
        Task<List<Review>> ListReviewProduct(string productId);
        Task<Review?> GetReview(string productId);
        Task<bool> AddReview(Review review);
        Task<bool> Delete(string reviewId);
    }
}
