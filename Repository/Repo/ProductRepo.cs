using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class ProductRepo : IProductRepo
    {
        private ProductDAO dao;
        public ProductRepo()
        {
            dao = new();
        }
        public async Task<bool> AddNew(Product product) => await dao.AddNew(product);

        public async Task<bool> Delete(string productId) => await dao.Delete(productId);

        public async Task<Product?> GetProduct(string productId) => await dao.GetProduct(productId);

        public async Task<List<Product>> ListProducts() => await dao.ListProducts();

        public async Task<bool> Update(Product product) => await dao.Update(product);
    }
}
