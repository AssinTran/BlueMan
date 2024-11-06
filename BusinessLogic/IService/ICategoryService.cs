using Models;

namespace BusinessLogic.IService
{
    public interface ICategoryService
    {
        Task<List<Category>> ListCategory();
        Task<bool> AddNew(Category category);
        Task<bool> Update(Category category);
        Task<bool> Delete(string categoryId);
    }
}
