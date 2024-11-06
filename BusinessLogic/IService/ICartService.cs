using Models;

namespace BusinessLogic.IService
{
    public interface ICartService
    {
        Task<List<Cart>> ListCartUser(string userId);
        Task<Cart?> GetCart(string cId);
        Task<bool> AddCart(Cart cart);
        Task<bool> Delete(string cId);
        Task<bool> Update(Cart cart);
    }
}
