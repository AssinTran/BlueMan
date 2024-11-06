using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.DAO
{
    public class ProductDAO : Connector<ProductDAO>
    {
        public async Task<List<Product>> ListProducts()
        {
            return await DB.Products.ToListAsync();
        }

        public async Task<Product?> GetProduct(string id)
        {
            Product? pro = await DB.Products.FindAsync(id);
            return pro;
        }

        public async Task<bool> AddNew(Product product)
        {
            if (product == null) return false;

            product.Id = new GenerateID("Product").Value;

            DB.Products.Add(product);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Update(Product product)
        {
            Product? current = await GetProduct(product.Id);
            if (current == null) return false;

            DB.Entry(current).CurrentValues.SetValues(product);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            Product? product = await GetProduct(id);
            if (product == null) return false;

            DB.Products.Remove(product);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
