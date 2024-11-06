using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class CategoryDAO : Connector<CategoryDAO>
    {
        public async Task<List<Category>> ListCategory()
        {
            return await DB.Categories.ToListAsync();
        }

        public async Task<bool> AddNew(Category category)
        {
            if (category == null) return false;

            category.Id = new GenerateID("Category").Value;
            DB.Categories.Add(category);
            await DB.SaveChangesAsync();

            return false;
        }

        public async Task<bool> Update(Category category)
        {
            if (category == null) return false;
            Category? c = await DB.Categories.FindAsync(category.Id);
            if (c == null) return false;

            DB.Entry(c).CurrentValues.SetValues(category);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            Category? c = await DB.Categories.FindAsync(id);
            if (c == null) return false;

            DB.Categories.Remove(c);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
