using BusinessLogic.IService;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class CartService : ICartService
    {
        private ICartRepo repo;
        public CartService()
        {
            repo = new CartRepo();
        }
        public async Task<bool> AddCart(Cart cart) => await repo.AddCart(cart);

        public async Task<bool> Delete(string cId) => await repo.Delete(cId);

        public async Task<Cart?> GetCart(string cId) => await repo.GetCart(cId);

        public async Task<List<Cart>> ListCartUser(string userId) => await repo.ListCartUser(userId);

        public async Task<bool> Update(Cart cart) => await repo.Update(cart);
    }
}
