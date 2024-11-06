using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class CartRepo : ICartRepo
    {
        private CartDAO dao;
        public CartRepo()
        {
            dao = new();
        }
        public async Task<bool> AddCart(Cart cart) => await dao.AddCart(cart);

        public async Task<bool> Delete(string cId) => await dao.Delete(cId);

        public async Task<Cart?> GetCart(string cId) => await dao.GetCart(cId);

        public async Task<List<Cart>> ListCartUser(string userId) => await dao.ListCartUser(userId);

        public async Task<bool> Update(Cart cart) => await dao.Update(cart);
    }
}
