using BusinessLogic.IService;
using DataAccess.DAO;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepo repo;
        public CategoryService()
        {
            repo = new CategoryRepo();
        }
        public async Task<bool> AddNew(Category category) => await repo.AddNew(category);

        public async Task<bool> Delete(string categoryId) => await repo.Delete(categoryId);

        public async Task<List<Category>> ListCategory() => await repo.ListCategory();

        public async Task<bool> Update(Category category) => await repo.Update(category);
    }
}
