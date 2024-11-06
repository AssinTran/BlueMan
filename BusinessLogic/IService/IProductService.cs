using Models;

namespace BusinessLogic.IService
{
    public interface IProductService
    {
        Task<List<Product>> ListProducts();
        Task<Product?> GetProduct(string productId);
        Task<bool> AddNew(Product product);
        Task<bool> Delete(string productId);
        Task<bool> Update(Product product);
    }
}
