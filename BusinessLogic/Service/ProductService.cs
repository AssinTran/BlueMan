using BusinessLogic.IService;
using DataAccess.DAO;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class ProductService : IProductService
    {
        private IProductRepo repo;
        public ProductService()
        {
            repo = new ProductRepo();
        }
        public async Task<bool> AddNew(Product product) => await repo.AddNew(product);

        public async Task<bool> Delete(string productId) => await repo.Delete(productId);

        public async Task<Product?> GetProduct(string productId) => await repo.GetProduct(productId);

        public async Task<List<Product>> ListProducts() => await repo.ListProducts();

        public async Task<bool> Update(Product product) => await repo.Update(product);
    }
}
