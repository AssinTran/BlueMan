using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ReviewDAO : Connector<ReviewDAO>
    {
        public async Task<List<Review>> ListReview()
        {
            return await DB.Reviews.ToListAsync();
        }

        public async Task<List<Review>> ListReviewProduct(string proid)
        {
            return await DB.Reviews.Where(r => r.ProductId.Equals(proid)).ToListAsync();
        }

        public async Task<Review?> GetReview(string id)
        {
            return await DB.Reviews.FindAsync(id);
        }

        public async Task<bool> AddReview(Review review)
        {
            if (review == null) return false;

            review.Id = new GenerateID("Review").Value;
            DB.Reviews.Add(review);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var review = await GetReview(id);
            if (review == null) return false;

            DB.Reviews.Remove(review);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
