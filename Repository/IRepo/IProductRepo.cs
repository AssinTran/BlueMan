using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IProductRepo
    {
        Task<List<Product>> ListProducts();
        Task<Product?> GetProduct(string productId);
        Task<bool> AddNew(Product product);
        Task<bool> Delete(string productId);
        Task<bool> Update(Product product);
    }
}
