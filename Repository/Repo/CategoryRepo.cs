using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        private CategoryDAO dao;
        public CategoryRepo()
        {
            dao = new();
        }
        public async Task<bool> AddNew(Category category) => await dao.AddNew(category);

        public async Task<bool> Delete(string categoryId) => await dao.Delete(categoryId);

        public async Task<List<Category>> ListCategory() => await dao.ListCategory();

        public async Task<bool> Update(Category category) => await dao.Update(category);
    }
}
