using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface ICategoryRepo
    {
        Task<List<Category>> ListCategory();
        Task<bool> AddNew(Category category);
        Task<bool> Update(Category category);
        Task<bool> Delete(string categoryId);
    }
}
